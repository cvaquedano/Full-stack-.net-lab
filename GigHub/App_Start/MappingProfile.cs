using AutoMapper;
using GigHub.Dto;
using GigHub.Models;

namespace GigHub
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            var config  = new MapperConfiguration(cfg => {
                cfg.CreateMap<ApplicationUser, UserDto>();
                cfg.CreateMap<Gig,GigDto>();
                cfg.CreateMap<Notification, NotificationDto>();    
                
                
            });
            
        }

    }
}