using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCars : EfEntityRepositoryBase<Car, RentACarDb>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using(RentACarDb context = new RentACarDb())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             select new CarDetailDto
                             {
                                 BrandName = b.Name,
                                 CarId = c.Id,
                                 Description = c.Description,
                             };
                return result.ToList();
            }
        }
    }
}
