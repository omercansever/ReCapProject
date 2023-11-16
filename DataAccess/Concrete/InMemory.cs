using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InMemory : ICarDal
    {
        List<Car> _cars;

        public InMemory()
        {
            _cars = new List<Car>()
            {
                new Car { Id = 1, BrandId = 1, ColorId=1, ModelYear=DateTime.Now, DailyPrice = 1500, Description="Porche 911 GT Rs"},
                new Car { Id = 2, BrandId = 2, ColorId=1, ModelYear=DateTime.Now, DailyPrice = 1200, Description="Mustang Shelby"},
                new Car { Id = 3, BrandId = 3, ColorId=2, ModelYear=DateTime.Now, DailyPrice = 1300, Description="Nissan GT R34"},
                new Car { Id = 4, BrandId = 4, ColorId=2, ModelYear=DateTime.Now, DailyPrice = 1400, Description="Toyota Supra"},
                new Car { Id = 5, BrandId = 5, ColorId=2, ModelYear=DateTime.Now, DailyPrice = 1000, Description="Mercedes E250"},
            };
        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p=>p.Id == car.Id ); 
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByBrandId(int BrandId)
        {
            return _cars.Where(p=>p.BrandId == BrandId).ToList();
        }

        public void Update(Car car)
        {
             Car carToUpdate = _cars .SingleOrDefault(p=>p.Id == car.Id);

            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;  
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
        }
    }
}
