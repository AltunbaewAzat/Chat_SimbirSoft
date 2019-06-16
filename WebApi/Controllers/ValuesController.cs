using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApi.Model;
using System.Linq;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        public List<User> user = new List<User>();
        public ValuesController()
        {
            user.Add(new User { UserId = 1, UserName = "Azat", Password = "qwerty" });
            user.Add(new User { UserId = 2, UserName = "Masha", Password = "qwerty1234" });
            user.Add(new User { UserId = 3, UserName = "Tom", Password = "1234" });
        }           
        // GET api/values
        [HttpGet]
        public List<User> Get()
        {
            return user;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return user.Where(x => x.UserId == id).FirstOrDefault();
        }

        // POST api/values
        [HttpPost]
        public void Post(User value)
        {
            user.Add(value);
        }

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
