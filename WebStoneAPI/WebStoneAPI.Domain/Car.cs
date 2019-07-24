using System;
using System.Collections.Generic;
using System.Text;

namespace WebStoneAPI.Domain
{
    public class Car
    {
        public Car(string year, string brand, string model)
        {
            Year = year;
            Brand = brand;
            Model = model;
        }

        public string Year { get; set; }
        public string  Brand { get; set; }
        public string Model { get; set; }
    }
}
