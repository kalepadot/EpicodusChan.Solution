// using System.Collections.Generic;
// using System.Linq;
// using Microsoft.AspNetCore.Mvc;
// using EpicodusChan.Models;
// using Microsoft.EntityFrameworkCore;

// namespace EpicodusChan.Controllers
// {
//   namespace EpicodusChan.Controllers
//   {
//   [Route("api/[controller]")]
//   [ApiController]
//   public class GroupsController : ControllerBase
//   {
//     private EpicodusChanContext _db;

//     public GroupsController(EpicodusChanContext db)
//     {
//       _db = db;
//     }

//     // GET api/groups
//     [HttpGet]
//     public ActionResult<IEnumerable<Group>> Get()
//     {
//       var query = _db.Groups.AsQueryable();
//       return query.ToList();
//     }

//     // POST api/groups
//     [HttpPost]
//     public void Post([FromBody] Group group)
//     {
//       _db.Groups.Add(group);
//       _db.SaveChanges();
//     }
// }