using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakersOfDenmark.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Date { get; set; }
        public string ImgUrl { get; set; }
    }

    public class DetailsBlog
    {
        public BlogIndlæg BlogIndlæg { get; set; }
        public IEnumerable<TopIndlæg> TopIndlægs { get; set; }
    }

    public class BlogIndlæg
    {
        public string Title{ get; set; }
        public string Subheading { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
    }

    public class TopIndlæg
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Date { get; set; }
        public string ImgUrl { get; set; }
    }
}
