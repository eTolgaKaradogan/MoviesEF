using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesEF.Models
{
    public class MovieModel
    {
        public int Id { get; set; }

        [DisplayName("Movie Name")] // tablodaki Name sutununun dgv'de ne isimle gözükeceği kodu. Entities'de de kullanılabilir ama modelde kullanılması doğru.
        public string Name { get; set; }

        [DisplayName("Release Year")]   //ismini değiştireceğin sutunun üstüne yazılır.
        public string ProductionYear { get; set; }

        [DisplayName("Box Office")]
        public double? BoxOfficeReturn { get; set; }
        public List<int> DirectorIds { get; set; }
    }
}
