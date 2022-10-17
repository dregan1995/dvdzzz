using dvdzzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Data.Entity;
using System.Web.Http;
using dvdzzz.Dtos;

namespace dvdzzz.Controllers.Apis
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        //[HttpGet]
        //public IEnumerable<NewRentalDto> GetNewRentals()
        //{
        //    var newRentalsDto = _context.NewRentals.ToList().Select(AutoMapper.Mapper.Map<NewRental, NewRentalDto>);

        //    return newRentalsDto;
        //}

        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRentalDto)
        {
            if (newRentalDto.MovieIds.Count == 0)
                return BadRequest("No movie IDs in request");

            var customer = _context.Customers.SingleOrDefault(m => m.Id == newRentalDto.CustomerId);
            if (customer == null)
                return BadRequest("Invalid Customer ID");
            

            var movies = _context.Movies.Where(m => newRentalDto.MovieIds.Contains(m.Id)).ToList();

            if (movies.Count != newRentalDto.MovieIds.Count)
                return BadRequest("Not all movie Ids could be found");

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie out of stock");

                movie.NumberAvailable--;

                Rental rental = new Rental()
                {
                    DateRented = DateTime.Now,
                    Customer = customer,
                    Movie = movie
                };
                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();
            return Ok();
        }
    }
}
