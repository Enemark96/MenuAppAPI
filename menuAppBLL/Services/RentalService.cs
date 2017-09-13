using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using menuAppBLL.BusinessObjects;
using menuAppBLL.Converters;
using menuAppDAL;

namespace menuAppBLL.Services
{
    class RentalService : IRentalService
    {
        private RentalConverter conv = new RentalConverter();
        private DALFacade _facade;
        public RentalService(DALFacade facade)
        {
            _facade = facade;
        }

        public List<RentalBO> AddMovies(List<RentalBO> rental)
        {
            throw new NotImplementedException();
        }

        public RentalBO Create(RentalBO rental)
        {
            using (var uow = _facade.UnitOfWork)
            {
               var rentalEntity =  uow.RentalRepository.Create(conv.Convert(rental));
                uow.Complete();
                return conv.Convert(rentalEntity);
            }
        }

        public RentalBO Delete(int Id)
        {
            using (var uow = _facade.UnitOfWork)
            {
                var rentalEntity = uow.RentalRepository.Delete(Id);
                uow.Complete();
                return conv.Convert(rentalEntity);
            }
        }

        public RentalBO Get(int id)
        {
            using (var uow = _facade.UnitOfWork)
            {
                var rentalEntity = uow.RentalRepository.Get(id);
                return conv.Convert(rentalEntity);
            }
        }

        public List<RentalBO> GetAll()
        {
            using (var uow = _facade.UnitOfWork)
            {
              return uow.RentalRepository.GetAll().Select(conv.Convert).ToList();
            }
        }

        public RentalBO Update(RentalBO rental)
        {
            using (var uow = _facade.UnitOfWork)
            {
                var rentalEntity = uow.RentalRepository.Get(rental.Id);
                if (rentalEntity == null)
                {
                    throw new InvalidOperationException("Rental not found");
                }
                rentalEntity.DeliveryDate = rental.DeliveryDate;
                rentalEntity.OrderDate = rental.OrderDate;
                uow.Complete();
                return conv.Convert(rentalEntity);
            }

        }
    }
}
