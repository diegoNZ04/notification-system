using MassTransit;
using NotificationSystem.Domain.Entities;

namespace NotificationSystem.Application.Consumers
{
    public class NotificationConsumer : IConsumer<Notification>
    {
        public async Task Consume(ConsumeContext<Notification> context)
        {
            var message = context.Message;

            try
            {
                Console.WriteLine($"Processing Notification: {message.Id}");
                await Task.Delay(500);
                Console.WriteLine($"Notification {message.Id} processed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error processing Notification {message.Id}: {ex.Message}");
                throw;
            }
        }
    }
}