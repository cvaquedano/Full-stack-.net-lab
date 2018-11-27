using GigHub.Dto;
using GigHub.Models;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Http;

namespace GigHub.Controllers.Api
{

    [Authorize]
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _context;
        public AttendancesController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Attend(AttendanceDto dto)
        {
            var userId = User.Identity.GetUserId();

         
            if (_context.Attendances.Any(t => t.GigId == dto.GigId && t.AttendeeId == userId))
            {
                return BadRequest("The attendace already exists.");
            }

            var attendace = new Attendance
            {
                GigId = dto.GigId,
                AttendeeId = userId,
            };

            _context.Attendances.Add(attendace);
            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult DeleteAttendance(int id)
        {
            var userId = User.Identity.GetUserId();
            var attendace = _context.Attendances
                .SingleOrDefault(a => a.AttendeeId == userId && a.GigId == id);

            if (attendace == null)
                return NotFound();

            _context.Attendances.Remove(attendace);
            _context.SaveChanges();

            return Ok(id);
        }
    }
}
