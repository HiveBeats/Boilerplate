using System;

namespace WebApi.DTO
{
    public class GetLocationsRequest
    {
        public DateTime DateBegin { get; set; }
        public DateTime DateEnd { get; set; }
    }
}