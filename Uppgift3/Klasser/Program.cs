using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Xml.Schema;

namespace Klasser
{
    class Program
    {
        public class Car
        {
            int weight;
            string RegNr;
            string Model { get; set; }
            string Elbil { get; set; }
            
            



            DateTime Registered = DateTime.Now;

            //public List<Car> Cars { get; set; }

            public Car(string model, bool elbil)
            {
                Model = model;
                
                if (elbil)
                {
                    Elbil = "Detta är en elbil";
                }
                else
                {
                    Elbil = "Icke en elbil";
                }




                //Cars = new List<Car>();
            }


            static void Main(string[] args)
            {
               


                Car BMW = new Car("BMW Z3", true) ;
                BMW.weight = 1600;
                BMW.RegNr = "ABC 123";
                BMW.Registered = DateTime.Now;
                

                Car Audi = new Car("Audi TT", false);
                Audi.weight = 1300;
                Audi.RegNr = "UPS 321";
                Audi.Registered = DateTime.Now;
                

                Car Volvo = new Car("Volvo V40",false);
                Volvo.weight = 2000;
                Volvo.RegNr = "CPC 099";
                Volvo.Registered = DateTime.Now;
                

                Car Saab = new Car("Saab 93",false);
                Saab.weight = 1250;
                Saab.RegNr = "FLC 333";
                Saab.Registered = DateTime.Now;

                


                List<Car> Cars = new List<Car>();
                Cars.Add(BMW);
                Cars.Add(Audi);
                Cars.Add(Volvo);
                Cars.Add(Saab);

                


                foreach (var Car in Cars)
                {
                    
                    Console.WriteLine($"Modell:{Car.Model} Vikt:{Car.weight}  Registreringsnummer:{Car.RegNr} Tid registrerad:{Car.Registered} Elbil: {Car.Elbil}" );
                }


            }
            
        }
    }
 
}