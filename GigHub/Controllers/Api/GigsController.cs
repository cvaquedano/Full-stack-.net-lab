using GigHub.Models;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Http;
using System.Data.Entity;
using GigHub.ViewModels;

namespace GigHub.Controllers.Api
{
    [Authorize]
    public class GigsController : ApiController
    {
        private ApplicationDbContext _context;
       
        public GigsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpDelete]
        public IHttpActionResult Cancel(int id)
        {
            var userId = User.Identity.GetUserId();
            var gig = _context.Gigs
                .Include(t=>t.Attendances.Select(a=>a.Attendee))
                .Single(g => g.Id==id && g.ArtistId == userId);

            if (gig.IsCanceled)
            {
                return NotFound();
            }

            gig.Cancel();

          

            _context.SaveChanges();

            return Ok();
        }

        public IHttpActionResult Update(GigFormViewModel viewModel)
        { 

            return Ok();
        }
    }
}
