using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi.Model;
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
        public void PostUser([FromBody]UserInfo value)
        {
            user.Add(value);
        }

        [HttpGet("{id}")]
        public UserInfo Get(int id)
        {
            return user.Where(x => x.Id == id).FirstOrDefault();
        }


        // GET api/values
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/values/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/values
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
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
