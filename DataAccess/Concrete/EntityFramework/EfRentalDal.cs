using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarsContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (CarsContext context = new CarsContext())
            {
                var result = from r in context.Rentals
                              join c in context.Cars on r.CarId equals c.Id
                              join cu in context.Customers on r.CustomerId equals cu.Id


                              select new RentalDetailDto
                              {
                                Id=r.Id,
                                CarName=c.CarName,
                                CompanyName=cu.CompanyName,
                                RentDate=r.RentDate,
                                ReturnDate=r.ReturnDate
                              };
                return result.ToList();
            }
        }
    }
}
