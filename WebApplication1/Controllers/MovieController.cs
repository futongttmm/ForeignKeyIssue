using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModels;
using System.Data.Entity.Validation;

namespace WebApplication1.Controllers
{
    public class MovieController : Controller
    {
        private ApplicationDbContext _context;
        public MovieController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [HttpPost]
        public ActionResult AddAndUpdate(Movie movie)
        {
            if (movie.Id == 0)
            {
                movie.AddDate = DateTime.Now;
                _context.Movies.Add(movie);
            }
                
            else
            {
                var movieInDb = _context.Movies.SingleOrDefault(m => m.Id == movie.Id);

                movieInDb.Name = movie.Name;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.Number = movie.Number;
                movieInDb.Genre = movie.Genre;
            }


            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                Console.WriteLine(e);
            }
            
            return RedirectToAction("Index", "Movie");
        }

        public ActionResult Add()
        {
            var genre = _context.Genres.ToList();
            var viewModel = new MovieGenreViewModel()
            {
                Genres = genre,
                Movie = new Movie()
            };
            return View("MovieForm", viewModel);
        }

        public ActionResult Index()
        {
            var movieList = _context.Movies.Include(m => m.Genre);
            return View(movieList);
        }

        public ActionResult Edit(int id)
        {
            var movie =_context.Movies.SingleOrDefault(m => m.Id == id);
            if (movie == null)
                return HttpNotFound();

            var viewModel = new MovieGenreViewModel()
            {
                Movie = movie,
                Genres = _context.Genres.ToList()
            };

            return View("MovieForm", viewModel);
        }


        //public ActionResult Details(int id)
        //{
        //    var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);
        //    if (movie == null)
        //        return HttpNotFound();
        //    return View(movie);
        //}

        //public ActionResult Random()
        //{
        //    var movieList = _context.Movies;
        //    return View(movieList);
        //}

        //[Route("Movie/Releases/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1, 12)}")]
        //public ActionResult Released(int? pageInt, string sortBy)
        //{
        //    if (!pageInt.HasValue)
        //    {
        //        pageInt = 1;
        //    }
        //    if(String.IsNullOrWhiteSpace(sortBy))
        //    {
        //        sortBy = "Name";
        //    }
        //    return Content(String.Format("pageInt = {0}  sortBy = {1}", pageInt, sortBy));
        //}
    }
}