using Confluent.Kafka;

class Program
{
    static void Main()
    {
        var config = new ProducerConfig
        {
            BootstrapServers = "localhost:9092"
        };

        using var producer = new ProducerBuilder<Null, string>(config).Build();

        Console.WriteLine("Kafka Producer Started");
        Console.WriteLine("Type messages (type 'exit' to quit)");

        while (true)
        {
            string? message = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(message))
                continue;

            if (message.ToLower() == "exit")
                break;

            producer.Produce("chat-topic", new Message<Null, string>
            {
                Value = message
            });

            producer.Flush(TimeSpan.FromSeconds(5));

            Console.WriteLine("Message Sent Successfully");
        }
    }
}