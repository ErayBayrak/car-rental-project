using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=100,ModelYear=2020,Description="Güzel araba"},
                new Car{Id=2,BrandId=2,ColorId=2,DailyPrice=200,ModelYear=2021,Description="Güzel araba"},
                new Car{Id=3,BrandId=3,ColorId=1,DailyPrice=300,ModelYear=2019,Description="Güzel araba"},
                new Car{Id=4,BrandId=2,ColorId=3,DailyPrice=400,ModelYear=2023,Description="Güzel araba"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }
        public void Delete(Car car)
        {
            Car carToRemoved = _cars.SingleOrDefault(x => x.Id == car.Id);
            _cars.Remove(carToRemoved);
        }
       
        public void Update(Car car)
        {
            Car updatedToCar = _cars.SingleOrDefault(x => x.Id == car.Id);
            updatedToCar.Id = car.Id;
            updatedToCar.BrandId = car.BrandId;
            updatedToCar.ColorId = car.ColorId;
            updatedToCar.DailyPrice = car.DailyPrice;
            updatedToCar.Description = car.Description;
            updatedToCar.ModelYear = car.ModelYear;
        }
        public Car GetById(int id)
        {
            return _cars.Find(x=>x.Id==id);
        }
        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetailsByDto()
        {
            throw new NotImplementedException();
        }
    }
}
