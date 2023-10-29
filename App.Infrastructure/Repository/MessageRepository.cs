using App.Domain.Models;
using App.Domain.Repository;
using Confluent.Kafka;
using System.Text.Json;

namespace App.Infrastructure.Repository
{
    public class MessageRepository : IMessageRepository
    {
        public void SendMessage(Message message)
        {
            var config = new ProducerConfig { BootstrapServers = "localhost:9092" };

            using (var producer = new ProducerBuilder<string, string>(config).Build())
            {
                string serializedMessage = JsonSerializer.Serialize(message);

                producer.Produce("Teste1", new Message<string, string>
                {
                    Key = message.UniqueId.ToString(),
                    Value = serializedMessage
                });
            }
        }
    }
}
