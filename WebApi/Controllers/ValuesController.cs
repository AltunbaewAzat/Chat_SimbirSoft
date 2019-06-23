using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System;
using Newtonsoft.Json;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        public List<UserInfo> user = new List<UserInfo>();
        public ValuesController()
        {
            user.Add(new UserInfo { Id = 1, UserName = "Azat", Password = "qwerty" });
            user.Add(new UserInfo { Id = 2, UserName = "Masha", Password = "qwerty1234" });
            user.Add(new UserInfo { Id = 3, UserName = "Tom", Password = "1234" });
        }

        [HttpGet]
        public string GetUser(string userName, string password)
        {
            return JsonConvert.SerializeObject(user.Where(x => String.Equals(x.UserName, userName) && String.Equals(x.Password, password)).FirstOrDefault());
        }
        [HttpPost]
        public void PostUser(UserInfo value)
        {
            user.Add(value);
        }
        // GET api/values
        //[HttpGet]
        //public List<UserInfo> Get()
        //{
        //    return user;
        //}

        // GET api/values/5
        [HttpGet("{id}")]
        public UserInfo Get(int id)
        {
            return user.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST api/values
        //[HttpPost]
        //public void Post(UserInfo value)
        //{
        //    user.Add(value);
        //}

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
