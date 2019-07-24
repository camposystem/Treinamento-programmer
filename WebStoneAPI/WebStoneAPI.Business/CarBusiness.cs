using System;
using System.Collections.Generic;
using System.Text;
using WebStoneAPI.Domain;
using WebStoneAPI.Repository;
using WebStoneAPI.Business.Interface;

namespace WebStoneAPI.Business
{
    public class CarBusiness : Interface.ICarBusiness
    {    private readonly ICarRepository  _carRepository;
        public CarBusiness(ICarRepository carRepository)
        {
            _carRepository = carRepository;
                
        }
        public Car Get(string brand)
        {
            return _carRepository.Get(brand);
        }

        public List<Car> GetList()
        {
          return  _carRepository.GetList();
        }

        public void Insert(Car c)
        {
            _carRepository.Insert(c);   
        }
    }
}
