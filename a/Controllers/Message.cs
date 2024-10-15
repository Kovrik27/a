using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace a.Controllers
{
    public class Message
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string From { get; set; }

    }

}
