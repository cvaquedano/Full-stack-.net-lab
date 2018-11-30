using System.Collections.Generic;
using GigHub.Models;

namespace GigHub.Repositories
{
    public interface IFollowingRepository
    {
        IEnumerable<Following> GetFollowing(string userId, string artistId);
    }
}