using System;
using Task.Classes;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver[] drivers = new Driver[4];
            drivers[0] = new Driver("Bob", 5);
            drivers[1] = new Driver("Greg", 10);
            drivers[2] = new Driver("Jill", 4);
            drivers[3] = new Driver("Anne", 7);
            Car[] cars = new Car[4];
            cars[0] = new Car("Hyundai", 140, "");
            cars[1] = new Car("Mazda", 190, "");
            cars[2] = new Car("Ferrari", 280, "");
            cars[3] = new Car("Porsche", 230, "");
            Console.WriteLine("Choose a car no.1");
            foreach (Car car in cars)
            {
                Console.WriteLine(car.Model);
            }
            string carOne = Console.ReadLine();
            Console.WriteLine("Choose a driver no.1");
            foreach (Driver driver in drivers)
            {
                Console.WriteLine(driver.Name);
            }
            string driverOne = Console.ReadLine();
            Console.WriteLine("Choose a car no.2");
            foreach(Car car in cars)
            {
                Console.WriteLine(car.Model);
            }
            string carTwo = Console.ReadLine();
            Console.WriteLine("Choose a driver no.2");
            foreach (Driver driver in drivers)
            {
                Console.WriteLine(driver.Name);
            }
            string driverTwo = Console.ReadLine();
            int firstSkill = 0;
            int secondSkill = 0;
            foreach(Driver driver in drivers)
            {
                if(driverOne == driver.Name)
                {
                    firstSkill = driver.Skill;
                    
                }
                if(driverTwo == driver.Name)
                {
                    secondSkill = driver.Skill;
                }
            }
            int firstSpeed = 0;
            int secondSpeed= 0;
            foreach (Car car in cars)
            {
                if (car.Model == carOne)
                {
                    car.Driver = driverOne;
                    firstSpeed = car.CalculateSpeed(firstSkill);
                }
                if (car.Model == carTwo)
                {
                    car.Driver = driverTwo; 
                    secondSpeed = car.CalculateSpeed(secondSkill);
                }
            }
            string faster = RaceCars(firstSpeed, secondSpeed);
            Console.WriteLine(faster);

        }
        public static string RaceCars(int fNum, int sNum)
        {
            if(fNum > sNum)
            {
                return $"Car no.1 was faster";
            }
            else
            {
                return $"Car no.2 was faster";
            }
        }

    }

}

