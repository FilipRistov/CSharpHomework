using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Classes
{
    public class Car
    {


        public string Model { get; set; }
        public int Speed { get; set; }
        public string Driver { get; set; }
        public Car(string model, int speed, string driver)
        {
            Model = model;
            Speed = speed;
            Driver = driver;
        }

        public int CalculateSpeed(int skill)
        {
            return this.Speed *= skill; 
        }
    }
}
