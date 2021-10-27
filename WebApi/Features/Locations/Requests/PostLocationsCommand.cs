using System;
using WebApi.Features.Locations.Responses;

namespace WebApi.Features.Locations.Requests
{
    public class PostLocationsCommand
    {
        public DateTime Date { get; set; }
        public LocationDto[] Locations { get; set; }
    }    
}