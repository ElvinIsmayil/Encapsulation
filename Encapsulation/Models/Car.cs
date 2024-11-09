using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Models
{
    public class Car
    {

        public int Id = 1000;

        public string Name { get; set; }

        public double Speed { get; set; }


        public string CarCode;

        public Car()
        {
            
        }

        public Car(string name,double speed)
        {
            Name = name;
            Speed = speed;
            CarCode = Name.Substring(0, 2).ToUpper() + Id;

        }
        public Car(int id,string name, double speed) :this(name,speed)
        {
            Id = id;
            CarCode = Name.Substring(0, 2).ToUpper() + Id;

        }

            //for (int i = 0; i < ; i++)
            //{
            //    Cars[i].Id += i;
            //}

        public void ShowFullData()
        {
            Console.WriteLine($"Id: {Id} Name: {Name} Speed: {Speed} CarCode: {CarCode}");

        }



    }
}
