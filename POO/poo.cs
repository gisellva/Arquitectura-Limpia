using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARQUITECTURAS.POO
{
    internal class Poo
    {
        public abstract class Vehicle
        {
            public string Make { get; set; }
            public string Model { get; set; }

            public Vehicle(string make, string model)
            {
                Make = make;
                Model = model;
            }


            public abstract void Horn();
        }


        public class Car : Vehicle
        {
            public Car(string make, string model) : base(make, model) { }

            public override void Horn()
            {
                Console.WriteLine("Coche: Beep Beep!");
            }
        }


        public class Truck : Vehicle
        {
            public Truck(string make, string model) : base(make, model) { }

            public override void Horn()
            {
                Console.WriteLine("Camión: Honk Honk!");
            }
        }


    } }
