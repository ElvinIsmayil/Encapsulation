
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
        private int _id = 1001;
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

            Car car = new Car(_id++, name, speed);

            Array.Resize(ref Cars, Cars.Length + 1);
            Cars[^1] = car;

        }




        public void ShowAllCars()
        {
            foreach (Car car in Cars)
            {

                Console.WriteLine($"Id: {car.Id}  Name: {car.Name}  Speed: {car.Speed}  CarCode: {car.CarCode}");

            }
        }

        public Car[] GetAllCars()
        {
            return Cars;
            
        }


        public Car FindCarById(int id)
        {
            foreach (Car car in Cars)
            {
                if (car.Id == id)
                {
                    return car;
                }
            }
            return null;
        }


        public Car FindCarbyCarCode(string code)
        {
            foreach (Car car in Cars)
            {
                if (car.CarCode == code)
                {
                    return car;
                }
            }
            return null;
        }


        public Car[] FindCarsBySpeedInterval(double minSpeed, double maxSpeed)
        {
            Car[] wantedCars = Array.Empty<Car>();
            foreach (Car car in Cars)
            {
                if (minSpeed <= car.Speed && car.Speed <= maxSpeed)
                {
                    Array.Resize(ref wantedCars, wantedCars.Length + 1);
                    wantedCars[wantedCars.Length - 1] = car;
                }
                
            }
            
            return wantedCars;
        }


    }
}
