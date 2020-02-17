using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Server2.Models;

namespace Server2.Controllers
{
    public class UsersController : ApiController
    {
        private Server2Context db = new Server2Context();

       
        public HttpResponseMessage GetUsers()
        {
            var response = Request.CreateResponse<IEnumerable<User>>(HttpStatusCode.OK, db.Users);
            return response;
        }

        // POST: api/Users
        [ResponseType(typeof(User))]
        public async Task<IHttpActionResult> PostUser(User user)
        {
            if(user.Iin == null)
            {
                Console.WriteLine("error");
                return NotFound();
            }
            if (Duplicate(user.Iin) == true)
            {
                Console.WriteLine("Duplicate");
                return Ok(); 
            }
            else
            {

                db.Users.Add(user);
                await db.SaveChangesAsync();

                return CreatedAtRoute("DefaultApi", new { id = user.Id }, user);
            }
        }
        private bool Duplicate(int iin)
        {
            return db.Users.Count(e => e.Iin == iin) > 0;
        }
    }
}