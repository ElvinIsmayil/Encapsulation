using Encapsulation.Models;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car("Mercedes", 100);

            car1.ShowFullData();

            Car car2 = new Car("Bmw", 80);

            car2.ShowFullData();

            Car car3 = new Car("Audi", 150);

            car3.ShowFullData();

            Gallery gallery = new Gallery();

            gallery.AddCar("audi", 200);
            gallery.AddCar("bmw", 100);
            gallery.AddCar("gmw", 600);

            gallery.AddCar("smw", 500);
            gallery.AddCar("emw", 400);

            gallery.ShowAllCars();

            //gallery.AddCar(car1);
            //gallery.AddCar(car2);
            //gallery.AddCar(car3);



            //gallery.ShowAllCars();
            

        }
    }
}
