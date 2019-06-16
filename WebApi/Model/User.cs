using System;
namespace WebApi.Model
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserMessage { get; set; }
        public DateTime DateTime { get; set; }
    }
}
