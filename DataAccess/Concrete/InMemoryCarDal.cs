using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>{
                new Car{  Id = 1, DailyPrice = 130, ColorId =  7, Description = "Light Gray Toyota Swift ", ModelYear = 2015 },
                new Car { Id = 2, DailyPrice = 120, ColorId = 26, Description = "Light Cyan (3) Mitsubishi Colt", ModelYear = 2019 },
                new Car { Id = 3, DailyPrice = 180, ColorId = 11, Description = "Red Berry Nissan Juke", ModelYear = 2018 },
                new Car { Id = 4, DailyPrice = 180, ColorId = 69, Description = "Dark Purple (2) Ford Focus", ModelYear = 2017 },
                new Car { Id = 5, DailyPrice = 200, ColorId =  1, Description = "Black Hyundai Accent", ModelYear = 2016 }

            };

        }    
            
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByld(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
