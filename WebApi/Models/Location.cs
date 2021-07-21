using System;

namespace WebApi.Models
{
    public class Location
    {
        public int LocationId { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public DateTime Timestamp { get; set; }
        public DateTime DateCreated { get; set; }
    }
}