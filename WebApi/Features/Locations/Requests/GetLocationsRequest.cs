using System;

namespace WebApi.Features.Locations.Requests
{
    public class GetLocationsRequest
    {
        public DateTime DateBegin { get; set; }
        public DateTime DateEnd { get; set; }
    }
}