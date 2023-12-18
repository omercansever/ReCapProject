using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NewMethod();
            CarManager carManager = new CarManager(new EfCars());
            foreach (var car in carManager.GetCarDetailDtos())
            {
                Console.WriteLine(car.CarId + "/" + car.BrandName);
            }
        }

        private static void NewMethod()
        {
            CarManager carManager = new CarManager(new EfCars());

            foreach (var car in carManager.GetByDailyPrice(0, 11000))
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
