using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace BuildingBlocks.Messaging.MassTransit;

public static class Extensions
{
    public static IServiceCollection AddMessageBroke(this IServiceCollection services, Assembly? assembly = null)
    {
        // Implement RabbitMQ MassTransit configuration
        return services;
    }
}