﻿using System;
using System.Collections.Generic;
using System.Text;
using WebStoneAPI.Domain;

namespace WebStoneAPI.Business.Interface
{
    public interface ICarService
    {

        void Insert(Car c);
        List<Car> GetList();

        Car Get(string brand);
    }
}
