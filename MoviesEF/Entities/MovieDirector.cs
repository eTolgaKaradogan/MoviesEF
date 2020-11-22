using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesEF.Entities
{
    public class MovieDirector
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int DirectorId { get; set; }
        public virtual Movie Movie { get; set; }        //lazy loading
        public virtual Director Director { get; set; }      //lazy loading için virtual tanımlamak gerek.
    }
}
