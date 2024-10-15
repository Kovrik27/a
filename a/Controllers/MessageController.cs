using a.Model;
using Microsoft.AspNetCore.Mvc;

namespace a.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageController : ControllerBase
    {
        private readonly Chat chat;
        List<Message> messages = new List<Message>();

        public MessageController(Chat chat)
        {
            this.chat = chat;
        }

        [HttpPost("Éîó×îÇàÌàëûõà")]
        public string SendMessage()
        {
            Message message = new Message();
            messages.Add(message);
            return messages;

        }
    }
}
