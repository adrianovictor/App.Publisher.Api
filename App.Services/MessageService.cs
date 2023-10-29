using App.Domain.Models;
using App.Domain.Repository;
using App.Services.Interface;

namespace App.Services
{
    public class MessageService : IMessageService
    {
        private readonly IMessageRepository _messageRepository;

        public MessageService(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }

        public void SendMessage(Message message)
        {
            _messageRepository.SendMessage(message);
        }
    }
}
