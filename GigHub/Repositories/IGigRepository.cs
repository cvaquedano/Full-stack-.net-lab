using System.Collections.Generic;
using GigHub.Models;

namespace GigHub.Repositories
{
    public interface IGigRepository
    {
        void Add(Gig gig);
        Gig GetGigById(int id);
        IEnumerable<Gig> GetGigsUserAttending(string userId);
        Gig GetGigWithAttendees(int Id);
        IEnumerable<Gig> GetUpComingGigsByArtist(string userId);
    }
}