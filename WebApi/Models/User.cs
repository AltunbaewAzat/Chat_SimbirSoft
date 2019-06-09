using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string userName { get; set; }
        public string Message { get; set; }
    }
}