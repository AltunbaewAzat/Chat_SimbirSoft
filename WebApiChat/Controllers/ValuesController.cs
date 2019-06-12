using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApiChat.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        Database _db;
        public ValuesController(Database db)
        {
            this._db = db;
        }
        public void Post([FromBody]string value)
        {
            _db.Add(value);
        }      

        public IEnumerable<string> Get()
        {
            return _db;
        }
                
    //    // GET api/values
    //    [HttpGet]
    //    public IEnumerable<string> Get()
    //    {
    //        return _db;
    //    }

    //    // GET api/values/5
    //    [HttpGet("{index}")]
    //    public string Get(int index)
    //    {
    //        return _db[index];
    //    }

    //    // POST api/values
    //    [HttpPost]
    //    public void Post([FromBody]string value)
    //    {
    //        _db.Add(value);
    //    }

    //    // PUT api/values/5
    //    [HttpPut("{id}")]
    //    public void Put(int id, [FromBody]string value)
    //    {
    //        _db[id] = value;
    //    }

    //    // DELETE api/values/5
    //    [HttpDelete("{value}")]
    //    public void Delete(string value)
    //    {
    //        _db.Remove(value);
    //    }
    }
}
