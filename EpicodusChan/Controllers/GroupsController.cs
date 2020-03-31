using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EpicodusChan.Models;
using Microsoft.EntityFrameworkCore;

namespace EpicodusChan.Solution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupsController : ControllerBase
    {
        private EpicodusChanContext _db; 
        public GroupsController(EpicodusChanContext db)
        {
          _db = db;
        }

        // GET api/groups
        [HttpGet]
        public ActionResult<IEnumerable<Group>> Get(string groupName, string topic)
        {
          var query = _db.Groups.AsQueryable(); 

          if (title != null)
          {
            query = query.Where(post => post.GroupName == groupName);
          }
          if (entry != null)
          {
            query = query.Where(post => post.Topic == topic );
          }
          return  query.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Group> Get(int id)
        {
            return _db.Groups.FirstOrDefault(entry => entry.GroupId == id);
        }

        // POST api/messages
        [HttpPost]
        public void Post([FromBody] Group group)
        {
          _db.Groups.Add(group);
          _db.SaveChanges(); 
        }

        // PUT api/messages/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Group group)
        {
          group.GroupId = id;
          _db.Entry(group).State = EntityState.Modified;
          _db.SaveChanges();
        }

        // // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
          var groupToDelete = _db.Groups.FirstOrDefault(entry => entry.GroupId == id);
          _db.Groups.Remove(groupToDelete);
          _db.SaveChanges();
        }
    }
}