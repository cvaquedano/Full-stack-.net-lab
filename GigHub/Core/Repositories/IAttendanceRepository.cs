using System.Collections.Generic;
using GigHub.Core.Models;

namespace GigHub.Core.Repositories
{
    public interface IAttendanceRepository
    {
        IEnumerable<Attendance> GetAttendace(int id, string userId);
        IEnumerable<Attendance> GetFutereAttendances(string userId);
    }
}