﻿namespace WebApi.Controllers
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }

        //bool isActive = false; // если пользователь вышел
                          //true //если зашел
    }
}