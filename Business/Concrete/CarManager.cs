using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _CarDal;
        private RentACarDb rentACarDb;

        public CarManager(ICarDal carDal, RentACarDb rentACarDb)
        {
            _CarDal = carDal;
            this.rentACarDb = rentACarDb;
        }

        public List<Car> GetAll()
        {
            return _CarDal.GetAll();
        }

        public List<Car> GetAllByBrandId(int id)
        {
            return _CarDal.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            //var asd = from cars in _CarDal.GetAll()
            //          where cars.DailyPrice >= min && cars.DailyPrice <= max
            //          select cars;



            return _CarDal.GetAll(p => p.DailyPrice >= min && p.DailyPrice <= max) ;
        }
    }
}
