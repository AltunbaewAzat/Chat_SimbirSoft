using System;
namespace WebApi.Models
{
    public class User
    {
        public int userId { get; set; }
        public string userName { get; set; }
        public string userMessage { get; set; }
        public DateTime dateTime { get; set; }
    }
}