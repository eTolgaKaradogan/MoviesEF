using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesEF.Models
{
    public class DirectorModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool Retired { get; set; }
        [DisplayName("Full Name")]
        public string FullName 
        {
            get => Name + " " + Surname;
        }
    }
}
