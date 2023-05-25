using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using PortalTransparenciaDeps.SharedKernel.Util;
using System;
using System.Text;

namespace PortalTransparenciaDeps.Infrastructure.Identity
{
    public static class JwtStartupSetup
    {
        public static void RegisterJWT(IServiceCollection services)
        {
            var tokenConfigurations = ConfigureToken(services);
            ConfigureAuth(services, tokenConfigurations);
        }

        private static TokenConfigurations ConfigureToken(IServiceCollection services)
        {
            var tokenConfigurations = new TokenConfigurations
            {
                Audience = AmbienteUtil.GetValue("TOKEN_AUDIENCE"),
                Issuer = AmbienteUtil.GetValue("TOKEN_ISSUER")
            };

            services.AddSingleton(tokenConfigurations);

            return tokenConfigurations;
        }

        private static void ConfigureAuth(IServiceCollection services, TokenConfigurations tokenConfigurations)
        {
            var secretKey = "z$C&F)J@NcRfUjXn2r4u7x!A%D*G-KaP";
            var _signinKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(secretKey));

            services.AddAuthentication(authOptions =>
            {
                authOptions.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                authOptions.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(bearerOptions =>
            {
                var paramsValidation = bearerOptions.TokenValidationParameters;
                paramsValidation.IssuerSigningKey = _signinKey;

                paramsValidation.ValidateIssuerSigningKey = true;

                paramsValidation.ValidAudience = tokenConfigurations.Audience;
                paramsValidation.ValidIssuer = tokenConfigurations.Issuer;

                paramsValidation.ValidateLifetime = true;

                paramsValidation.ClockSkew = TimeSpan.Zero;
            });

            services.AddAuthorization(auth =>
            {
                auth.AddPolicy("Bearer", new AuthorizationPolicyBuilder()
                    .AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme‌​)
                    .RequireAuthenticatedUser().Build());
            });
        }
    }
}
