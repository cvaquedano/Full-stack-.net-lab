using AutoMapper;
using GigHub.Core.Dto;
using GigHub.Core.Models;

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