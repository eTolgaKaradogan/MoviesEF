using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviesEF.Contexts;
using MoviesEF.Entities;
using MoviesEF.Models;

namespace MoviesEF.Services
{
    public class MovieService
    {
        MoviesContext db = new MoviesContext();
        public List<MovieModel> List()
        {
            try
            {
                return db.Movies.Select(movie => new MovieModel()
                {
                    Id = movie.Id,
                    Name = movie.Name,
                    ProductionYear = movie.ProductionYear,
                    BoxOfficeReturn = movie.BoxOfficeReturn
                }).ToList();
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }
        public void Add(MovieModel movieModel)
        {
            try
            {
                var movieEntity = new Movie()
                {
                    Id = movieModel.Id,
                    Name = movieModel.Name,
                    ProductionYear = movieModel.ProductionYear,
                    BoxOfficeReturn = movieModel.BoxOfficeReturn,
                    MovieDirectors = movieModel.DirectorIds.Select(directorId => new MovieDirector()
                    {
                        MovieId = movieModel.Id,
                        DirectorId = directorId
                    }).ToList()
                };
                db.Movies.Add(movieEntity);
                db.SaveChanges();
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }
        public MovieModel Details(int id)
        {
            try
            {
                Movie movieEntity = db.Movies.Find(id);
                MovieModel movieModel = new MovieModel()
                {
                    Id = movieEntity.Id,
                    Name = movieEntity.Name,
                    BoxOfficeReturn = movieEntity.BoxOfficeReturn,
                    ProductionYear = movieEntity.ProductionYear
                };
                // 1.YOL
                //movieModel.DirectorIds = new List<int>();
                //foreach (var movieDirector in movieEntity.MovieDirectors)
                //{
                //    movieModel.DirectorIds.Add(movieDirector.DirectorId);
                //}
                //return movieModel;
                // 2.YOL
                movieModel.DirectorIds = movieEntity.MovieDirectors.Select(movieDirector => movieDirector.DirectorId).ToList();
                return movieModel;
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }
    }
}
