using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakersOfDenmark.Models
{
    public class HomeViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Address{ get; set; }
        public string ImgUrl { get; set; }
    }
}
