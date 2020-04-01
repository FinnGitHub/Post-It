using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostIt.Models
{
    public class Post
    {
        public int EventID { get; set; }

        public string PostName { get; set; }

        public string Description { get; set; }

        public string Categories { get; set; }

        public string ImageSrc { get; set; }
    }
}
