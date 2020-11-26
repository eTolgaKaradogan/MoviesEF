using MoviesEF.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviesEF.Models;
using MoviesEF.Entities;

namespace MoviesEF.Services
{
    public class ReviewsService
    {
        MoviesContext db = new MoviesContext();
        public List<ReviewModel> List()
        {
            try
            {
                return db.Reviews.Select(review => new ReviewModel()
                {
                    Id = review.Id,
                    Content = review.Content,
                    Rating = review.Rating,
                    Movie = review.Movie
                }).ToList() ;
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }
        public void Add(ReviewModel reviewModel)
        {
            try
            {
                var reviewEntity = new Review()
                {
                    Id = reviewModel.Id,
                    Content = reviewModel.Content,
                    Rating = reviewModel.Rating,
                    Movie = reviewModel.Movie
                };
                db.Reviews.Add(reviewEntity);
                db.SaveChanges();
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }
        public ReviewModel Details(int id)
        {
            try
            {
                Review review = db.Reviews.Find(id);
                ReviewModel reviewModel = new ReviewModel()
                {
                    Id = review.Id,
                    Content = review.Content,
                    Rating = review.Rating,
                    Movie = review.Movie
                };
                return reviewModel;
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

    }
}
