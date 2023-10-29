using App.Domain.Common;

namespace App.Domain.Models
{
    public class Message : Entity<Message>
    {
        public Guid UniqueId { get; protected set; }
        public string Title { get; protected set; }
        public string Body { get; protected set; }

        protected Message()
        {
            UniqueId = Guid.NewGuid();
        }

        public Message(int id, string title, string body)
            : this()
        {
            Id = id;
            Title = title;
            Body = body;
        }

        public static Message Create(int id, string title, string body)
        {
            return new Message(id, title, body);
        }
    }
}
