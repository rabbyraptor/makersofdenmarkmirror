using System;

namespace MakersOfDenmark.Models
{
    public class Aktivitet
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Date { get; set; }
        public string StartTime { get; set; }
        public string MakerSpace { get; set; }
        public string Address { get; set; }
        public string ImgUrl { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(Id);
    }
}
