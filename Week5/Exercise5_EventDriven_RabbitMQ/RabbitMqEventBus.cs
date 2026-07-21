using System.Text;
using System.Text.Json;
using Shared.Events;
using RabbitMQ.Client;

namespace Shared.Messaging
{
    public class RabbitMqEventBus
    {
        private readonly string _hostname;

        public RabbitMqEventBus(string hostname = "localhost")
        {
            _hostname = hostname;
        }

        public void PublishOrderCreated(OrderCreatedEvent @event)
        {
            var factory = new ConnectionFactory { HostName = _hostname };
            using var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();

            channel.QueueDeclare(
                queue: "order_created_queue",
                durable: false,
                exclusive: false,
                autoDelete: false,
                arguments: null);

            var message = JsonSerializer.Serialize(@event);
            var body = Encoding.UTF8.GetBytes(message);

            channel.BasicPublish(
                exchange: "",
                routingKey: "order_created_queue",
                basicProperties: null,
                body: body);

            Console.WriteLine($"[RabbitMQ] Published OrderCreatedEvent: OrderId {@event.OrderId}");
        }
    }
}
