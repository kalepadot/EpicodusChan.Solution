using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EpicodusChan.Models;

namespace EpicodusChan.Solution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private EpicodusChanContext _db; 
        public MessagesController(EpicodusChanContext db)
        {
          _db = db;
        }

        // GET api/messages
        [HttpGet]
        public ActionResult<IEnumerable<Message>> Get()
        {
          return _db.Messages.ToList();
        }

        // GET api/values/5
        // [HttpGet("{id}")]
        // public ActionResult<string> Get(int id)
        // {
        //     return "value";
        // }

        // POST api/animals
        [HttpPost]
        public void Post([FromBody] Message message)
        {
          _db.Messages.Add(message);
          _db.SaveChanges(); 
        }

        // // PUT api/values/5
        // [HttpPut("{id}")]
        // public void Put(int id, [FromBody] string value)
        // {
        //   message.MessageId = id;
        //   _db.Entry(message).State = EntityState.Modified;
        //   _db.SaveChanges();
        // }

        // // DELETE api/values/5
        // [HttpDelete("{id}")]
        // public void Delete(int id)
        // {
        //   var messageToDelete = _db.Messages.FirstOrDefault(entry => entry.MessageId == id);
        //   _db.Messages.Remove(messageToDelete);
        //   -db.SaveChanges();
        // }
    }
}