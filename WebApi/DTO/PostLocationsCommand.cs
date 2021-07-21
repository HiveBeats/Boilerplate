using System;

namespace WebApi.DTO
{
    public class PostLocationsCommand
    {
        public DateTime Date { get; set; }
        public LocationDto[] Locations { get; set; }
    }
}