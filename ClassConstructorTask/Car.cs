using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConstructorTask
{
    internal class Car
    {
        public string Brand;
        public string Model;
        public int Year;
        public string FuelType;
        public string Color;

        public Car(string brand,string model,int year,string fuelType,string color)
        {
            Brand = brand;
            Model = model;
            Year = year;
            FuelType = fuelType;
            Color = color;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"{Brand} {Model} {Year} => Fuel: {FuelType}, Color: {Color}");
        }
    }
}
