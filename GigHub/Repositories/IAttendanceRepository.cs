using System.Collections.Generic;
using GigHub.Models;

namespace GigHub.Repositories
{
    public interface IAttendanceRepository
    {
        IEnumerable<Attendance> GetAttendace(int id, string userId);
        IEnumerable<Attendance> GetFutereAttendances(string userId);
    }
}