using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using PortalTransparenciaDeps.Infrastructure.Data;
using PortalTransparenciaDeps.UnitTests;
using PortalTransparenciaDeps.SharedKernel;
using System;
using System.Linq;

namespace PortalTransparenciaDeps.FunctionalTests
{
    public class CustomWebApplicationFactory<TStartup> : WebApplicationFactory<TStartup> where TStartup : class
    {
        /// <summary>
        /// Overriding CreateHost to avoid creating a separate ServiceProvider per this thread:
        /// https://github.com/dotnet-architecture/eShopOnWeb/issues/465
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        protected override IHost CreateHost(IHostBuilder builder)
        {
            var host = builder.Build();
            host.Start();

            // Get service provider.
            var serviceProvider = host.Services;

            // Create a scope to obtain a reference to the database
            // context (AppDbContext).
            using (var scope = serviceProvider.CreateScope())
            {
                var scopedServices = scope.ServiceProvider;
                var db = scopedServices.GetRequiredService<AppDbContext>();

                var logger = scopedServices
                    .GetRequiredService<ILogger<CustomWebApplicationFactory<TStartup>>>();

                // Ensure the database is created.
                db.Database.EnsureCreated();

                try
                {
                    SeedData.PopulateTestData(db);
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, "An error occurred seeding the " +
                                        $"database with test messages. Error: {ex.Message}");
                }
            }

            return host;
        }

        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder
                .ConfigureServices(services =>
                {
                    // Remove the app's ApplicationDbContext registration.
                    var descriptor = services.SingleOrDefault(
                    d => d.ServiceType ==
                        typeof(DbContextOptions<AppDbContext>));

                    if (descriptor != null)
                    {
                        services.Remove(descriptor);
                    }

                    // This should be set for each individual test run
                    string inMemoryCollectionName = Guid.NewGuid().ToString();

                    // Add ApplicationDbContext using an in-memory database for testing.
                    services.AddDbContext<AppDbContext>(options =>
                    {
                        options.UseInMemoryDatabase(inMemoryCollectionName);
                    });

                    services.AddScoped<IMediator, NoOpMediator>();

                    services.Configure<JwtBearerOptions>(JwtBearerDefaults.AuthenticationScheme, options =>
                    {
                        var config = new OpenIdConnectConfiguration()
                        {
                            Issuer = MockJwtTokens.Issuer
                        };

                        options.TokenValidationParameters.ValidateAudience = false;

                        config.SigningKeys.Add(MockJwtTokens.SecurityKey);
                        options.Configuration = config;
                    });
                });
        }
    }
}