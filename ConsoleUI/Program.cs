using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCars(), new RentACarDb());

            foreach (var car in carManager.GetByDailyPrice(0, 11000))
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
