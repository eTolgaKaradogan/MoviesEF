using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MoviesEF.Entities
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]              // Not null demektir. Veri girilmesini zorunlu yapar.
        [StringLength(200)]     // Bir alttaki string sütunun kaç karakter alacağını belirleme.
        public string Name { get; set; }

        [StringLength(4)]       // ProductionYear sutununun uzunluğunu 4 karakter yapar.
        public string ProductionYear { get; set; }
        public double? BoxOfficeReturn { get; set; }
        public virtual List<Review> Reviews { get; set; }                   //lazy loading
        public virtual List<MovieDirector> MovieDirectors { get; set; }     //lazy loading

    }
}
