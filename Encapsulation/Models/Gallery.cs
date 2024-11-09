using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace Encapsulation.Models
{
    public class Gallery
    {
        private int _id = 1000;
        public int GalleryId { get; set; }
        public string Name { get; set; }

        public Car[] Cars = Array.Empty<Car>();

        public Gallery()
        {

        }


        public Gallery(int id, string name, Car[] cars)
        {
            GalleryId = id;
            Name = name;
            Cars = cars;
        }



        public void AddCar(string name, double speed)
        {
            
            Car car = new Car(_id++,name, speed);

            Array.Resize(ref Cars, Cars.Length + 1);
            Cars[^1] = car;

        }


        

        public void ShowAllCars()
        {
            foreach (Car car in Cars)
            {

                Console.WriteLine($"Id: {car.Id}  Name: {car.Name}  Speed: {car.Speed}  ");

            }
        }



        public void FindCarById(int id)
        {
            foreach (Car car in Cars)
            {
                if (car.Id == id)
                {
                    Console.WriteLine(car.Name);
                }
            }
        }


        public void FindCarbyCarCode(string code)
        {
            foreach (Car car in Cars)
            {
                if (car.CarCode == code)
                {
                    Console.WriteLine(car.Name);
                }
            }

        }


        public void FindCarsBySpeedInterval(double minSpeed, double maxSpeed)
        {
            foreach (Car car in Cars)
            {
                if (minSpeed <= car.Speed && car.Speed <= maxSpeed)
                {
                    Console.WriteLine(car.Name);
                }
            }
        }


    }
}
