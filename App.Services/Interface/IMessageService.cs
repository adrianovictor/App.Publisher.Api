using App.Domain.Models;

namespace App.Services.Interface
{
    public interface IMessageService
    {
        void SendMessage(Message message);
    }
}
