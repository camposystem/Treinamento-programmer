using System;
using System.Collections.Generic;
using System.Text;
using WebStoneAPI.Domain;
using WebStoneAPI.Repository.Base;

namespace WebStoneAPI.Repository
{
    public class ICarRepository : Repository<Car>, Interface.IBrandRepository<Car>
    {
        public Car Get(string value)
        {
          return GetList().Find(x => x.Brand == value);
        }

    }
}
