using System;

namespace WebApi.Features.Locations.Responses
{
    public class LocationDto
    {
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public DateTime Timestamp { get; set; }
    }
}