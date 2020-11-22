using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviesEF.Entities;

namespace MoviesEF.Contexts
{
    public class MoviesContext : DbContext  //MoviesContext bir DbContext olmalıdır!
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<MovieDirector> MovieDirectors { get; set; }
        public MoviesContext() : base("MoviesContext")      // (ctor) app.configdeki moviescontext adındaki connectionstring'i bulup onu kullanarak DB'ye bağlanacak.
        {

        }
        // VERİ TABANINDA DAHA DETAYLI ÖZELLEŞTİRMELER YAPMAK İÇİN AŞAĞIDAKİ METHOD KULLANILIR.
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder); 
        //}
    }
}
