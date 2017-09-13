using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using menuAppDAL.Context;
using menuAppDAL.Entities;

namespace menuAppDAL.Repositories
{
    class RentalRepository : IRentalRepository
    {
        private MovieAppContext _context;
        public RentalRepository(MovieAppContext context)
        {
            _context = context;
        }


        public Rental Create(Rental rental)
        {
            _context.Rentals.Add(rental);
            return rental;
        }

        public List<Rental> GetAll()
        {
            return _context.Rentals.ToList();
        }

        public Rental Get(int id)
        {
            return _context.Rentals.FirstOrDefault(o => o.Id == id);
        }

        public Rental Delete(int Id)
        {
            var rental = Get(Id);
            _context.Rentals.Remove(rental);
            return rental;
        }
    }
}
