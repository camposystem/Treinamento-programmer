using System;
using System.Collections.Generic;
using System.Text;
using WebStoneAPI.Domain;
using WebStoneAPI.Business.Interface;

namespace WebStoneAPI.Service
{
    public class CarService : ICarService
    {
        private readonly ICarBusiness _carBusiness;

        public CarService(ICarBusiness carBusiness)
        {
            _carBusiness = carBusiness;

        }
        public Car Get(string brand)
        {
            return _carBusiness.Get(brand);
        }

        public List<Car> GetList()
        {
            return _carBusiness.GetList();
        }

        public void Insert(Car c)
        {
            _carBusiness.Insert(c);
        }
    }
}
