using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ProjectUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            UserManager userManager = new UserManager(new EfUserDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            //carManager.Add(new Car { Id = 5, BrandId = 3, ColorId = 2, DailyPrice = 150, Description = "Nice", ModelYear = 2020 });
            //ListAllCars(carManager);
            //CarsByBrand(carManager);
            //CarsByColor(carManager);
            //GetCarAllDetailsWithDTO(carManager);
            //Car car = new Car {Id=9,BrandId=1,ColorId=2,DailyPrice=250,Description="Güzel",ModelYear=2019 };
            ////carManager.Add(car);
            //car.Description = "Kırmızı Ferrari";
            //carManager.Update(car);
            //User user = new User { FirstName = "Eray", LastName = "Türk", Email = "e@gmail.com", Password = "123" };
            //userManager.Add(user);
            Customer customer = new Customer { UserId = 1, CompanyName = "SpaceX" };
            customerManager.Add(customer);

        }

        private static void GetCarAllDetailsWithDTO(CarManager carManager)
        {
            foreach (var item in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(item.Description + "/" + item.BrandName + "/" + item.ColorName + "/" + carManager.GetCarDetails().Message);
            }
        }

        private static void CarsByColor(CarManager carManager)
        {
            foreach (var item in carManager.GetCarsByColorId(2).Data)
            {
                Console.WriteLine(item.Description);
            }
        }

        private static void CarsByBrand(CarManager carManager)
        {
            foreach (var item in carManager.GetCarsByBrandId(1).Data)
            {
                Console.WriteLine(item.Description);
            }
        }

        private static void ListAllCars(CarManager carManager)
        {
            foreach (var item in carManager.GetAll().Data)
            {
                Console.WriteLine("Id:{0} / Model:{1} / Günlük Ücret:{2}", item.Id, item.ModelYear, item.DailyPrice);
            }
        }
    }
}
