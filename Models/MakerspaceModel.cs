using System;

namespace MakersOfDenmark.Models
{
    public class Makerspace
    {
        public string makerSpaceId { get; set; }
        public string makerSpaceName { get; set; }
        public string streetName { get; set; }
        public string streetNumber { get; set; }
        public string city { get; set; }
        public string zipCode { get; set; }
        public bool isAccepted { get; set; }
    }
}
