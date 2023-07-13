using Microsoft.AspNetCore.Http;
using NLog;
using PortalTransparenciaDeps.Core.Enums;
using PortalTransparenciaDeps.Core.Exceptions;
using PortalTransparenciaDeps.SharedKernel.Extensions;
using PortalTransparenciaDeps.SharedKernel.Util;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

using PortalTransparenciaDeps.Core.DTO;
using PortalTransparenciaDeps.Core.Interfaces;
using PortalTransparenciaDeps.Core.Models.PortalTransparenciaAggregate;

using System.Net.Http;
using System.Text.Json;


namespace PortalTransparenciaDeps.SharedKernel.Middleware
{
    public class ExceptionHandlerMiddleware
    {
        private readonly Logger _logger;
        private readonly RequestDelegate _next;
        private List<int> AllowedCodes = new() { 400, 401, 403, 404 };

        public ExceptionHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
            _logger = LogManager.GetCurrentClassLogger();
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(httpContext, ex);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.Clear();
            context.Response.ContentType = "application/json";

            var ip = GetIp(context);
            var dadosUsuario = GetDadosUsuario(context);

            _logger.Error(exception, $"{ip} {dadosUsuario} {exception.Message}");

            if (exception is PortalTransparenciaDepsException geralException)
            {
                var statusCode = AllowedCodes.Contains((int)geralException.DetailErrorCode) ? (int)geralException.DetailErrorCode : 400;
                await WriteResponse(context, statusCode, (int)geralException.DetailErrorCode, geralException.Message, geralException.ExtraData);
                return;
            }

            if (exception is AggregateException aggregate && aggregate.InnerExceptions.Any(x => x is PortalTransparenciaDepsException PortalTransparenciaDepsException))
            {
                var first = aggregate.InnerExceptions.Where(x => x is PortalTransparenciaDepsException PortalTransparenciaDepsException).First() as PortalTransparenciaDepsException;
                var statusCode = AllowedCodes.Contains((int)first.DetailErrorCode) ? (int)first.DetailErrorCode : 400;
                await WriteResponse(context, statusCode, (int)first.DetailErrorCode, first.Message, first.ExtraData);
                return;
            }

            await WriteResponse(context, (int)HttpStatusCode.InternalServerError, (int)InternalErrorCode.InternalServerError, "Internal Server Error");
        }

        private async Task WriteResponse(HttpContext context, int statusCode, int detailErrorCode, string message, ExpandoObject extra = null)
        {
            context.Response.StatusCode = statusCode;

            var error = new ErrorDetails
            {
                StatusCode = detailErrorCode,
                Message = message,
                ExtraData = extra
            };

            await context.Response.WriteAsync(error.ToJson());
        }

        internal class ErrorDetails
        {
            public ErrorDetails()
            {
            }

            public int StatusCode { get; set; }
            public string Message { get; set; }
            public ExpandoObject ExtraData { get; set; }
        }

        private string GetIp(HttpContext context)
        {
            var result = string.Empty;

            if (context.Request?.Headers != null)
            {

                var forwardedHeader = context.Request.Headers["X-Forwarded-For"];
                if (!string.IsNullOrEmpty(forwardedHeader))
                    result = forwardedHeader.FirstOrDefault();
            }

            if (string.IsNullOrEmpty(result) && context?.Connection?.RemoteIpAddress != null)
                result = context.Connection.RemoteIpAddress.ToString();

            return result;
        }

        private string GetDadosUsuario(HttpContext context)
        {
            var result = string.Empty;

            var isAuthenticated = context.User?.Identity?.IsAuthenticated ?? false;
            result = isAuthenticated ? $"{context.User.GetClienteId()} - {context.User.GetPerfilUsuario()} - {context.User.GetUsuarioId()}" :
                                       $"Usuário não autenticado";

            return result;
        }
    }
}
