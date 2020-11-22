using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviesEF.Entities;

namespace MoviesEF.Models
{
    public class ReviewModel
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
