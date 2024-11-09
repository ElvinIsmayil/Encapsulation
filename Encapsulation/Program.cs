using Encapsulation.Models;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Gallery gallery = new Gallery();

            gallery.AddCar("Audi", 200);
            gallery.AddCar("Bmw", 100);
            gallery.AddCar("Mercedes", 50);

            gallery.ShowAllCars();
            

            Car[] allCars = gallery.GetAllCars();

            foreach (var car in allCars)
            {
                Console.WriteLine($"Id: {car.Id} Name: {car.Name} Speed: {car.Speed} CarCode: {car.CarCode}");

            }

            Car wantedCar = gallery.FindCarById(1001);

            if (wantedCar != null )
            {
                Console.WriteLine(wantedCar.Name);
            }
            else
            {
                Console.WriteLine("There is no such car which meets Id requirement!");
            }

            Car wantedCar2 = gallery.FindCarbyCarCode("BM1001");

            if (wantedCar != null)
            {
                Console.WriteLine(wantedCar2.Name);
            }
            else
            {
                Console.WriteLine("There is no such car which meets CarCode requirement!");
            }



            Car[] wantedCars = gallery.FindCarsBySpeedInterval(10, 200);


            if (wantedCars != null)
            {
                foreach (var car in wantedCars)
                {
                    Console.WriteLine(car.Name);
                }
            }
            else
            {
                Console.WriteLine("There is no such car which meets speed interval requirements!");
            }

            


        }
    }
}