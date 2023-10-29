using App.Domain.Models;

namespace App.Domain.Repository
{
    public interface IMessageRepository
    {
        void SendMessage(Message message);
    }
}
