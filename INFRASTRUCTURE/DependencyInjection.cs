using Application.Configuration;
using Application.Elasticsearch;
using Application.Interfaces;
using APPLICATION.AutoMapper;
using APPLICATION.Services;
using AutoMapper;
using Elastic.Clients.Elasticsearch;
using Elastic.Transport;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        // Bind settings using Options pattern
        services.Configure<ElasticsearchSettings>(configuration.GetSection("Elasticsearch"));

        // Register Elasticsearch client. For development, accept untrusted TLS certificates.
        services.AddSingleton(sp =>
        {
            var options = sp.GetRequiredService<IOptions<ElasticsearchSettings>>().Value;

            var clientSettings = new ElasticsearchClientSettings(new Uri(options.Url))
                .Authentication(new BasicAuthentication(options.Username, options.Password))
                .ServerCertificateValidationCallback((sender, cert, chain, errors) => true); // dev-only

            return new ElasticsearchClient(clientSettings);
        });
        services.AddSingleton<ElasticIndexInitializer>();
        services.AddAutoMapper(cfg =>
        {
            cfg.AddProfile<AutoMap>();
        });
        //services.AddAutoMapper(typeof(AutoMap).Assembly);
        //services.AddScoped<IBookRepository, BookRepository>();
        services.AddScoped<IBookService, BookService>();
        // <PackageReference Include="AutoMapper.Extensions.Microsoft.DependencyInjection" Version="12.0.0" />
        return services;
    }
}