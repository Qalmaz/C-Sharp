using Klasser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.ComponentModel;
using System.Reflection;

namespace ArvOchAbstraktion
{
    class Program
    {
        

        static void Main(string[] args)
        {
            IVerkstad verkstad = new Verkstad();
            //List<Fordon> FordonsLista = new List<Fordon>();
            
            bool körs = true;
            while (körs)
            { 
                Console.WriteLine("\n\t[1] Skapa en bil" +
                "\n\t [2] Skapa en buss" +
                "\n\t [3] Skapa en lastibl" +
                "\n\t [4] Skapa en motorcykel" +
                "\n\t [5] Skriv ut alla fordon" +
                "\n\t [6] Radera ett fordon" +
                "\n\t [7] Avsluta programmet");
            string menyval = Console.ReadLine();
            int input;
            int.TryParse(menyval, out input);
            if (input == 7)
            {
                break;
            }
            Fordon nyttFordon = null;
                
                switch (input)
                {
                    case 1:
                        nyttFordon = SkapaBil();
                        verkstad.AddFordon(nyttFordon);                   
                        break;
                    case 2:
                        nyttFordon = SkapaBuss();
                        verkstad.AddFordon(nyttFordon);
                        break;
                    case 3:
                        nyttFordon = SkapaLastbil();
                        verkstad.AddFordon(nyttFordon);
                        break;
                    case 4:
                        nyttFordon = SkapaMc();
                        verkstad.AddFordon(nyttFordon);
                        break;
                    case 5:
                        ListUtskrift.SkrivUtFordon(Verkstad.FordonsLista);                                
                        break;
                    case 6:
                        
                        Console.WriteLine("Skriv in fordonets Registreringsnummer som du vill ta bort: eg. ABC 123");
                        string regNr = Console.ReadLine();
                        verkstad.HittaFordon(regNr);
                        

                        break;
                    default:
                        break;
                }
            }
        }
        private static void SkapaFordon(Fordon fordon)
        {
            Console.WriteLine("Skriv in modell:");
            string model = Console.ReadLine();
            Console.WriteLine("Ange regnr:");
            string regNr = Console.ReadLine();
            Console.WriteLine("Ange mätare:");
            int milesTravelled = int.Parse(Console.ReadLine());
            DateTime regDatum = DateTime.Now;

            fordon.Model = model;
            fordon.MilesTravelled = milesTravelled;
            fordon.Registered = regDatum;
            fordon.RegNr = regNr;

        }
        public static Bil SkapaBil()
        {
            Bil bil = new Bil();
            SkapaFordon(bil);      

                Console.WriteLine("Har bilen en dragkrok? Y/N");
                string inputDragKrok = Console.ReadLine();
            bool DragKrok = false;
            if (inputDragKrok == "Y")
                {
                    DragKrok = true;
                
                }
            else if (inputDragKrok == "N")
            {
                DragKrok = false;
            }
            bil.DragKrok = DragKrok;
            return bil;
        }
        public static Buss SkapaBuss()
        {
            Buss buss = new Buss();
            SkapaFordon(buss);
            Console.WriteLine("Ange maxantalet passagerare bussen är kapabel till: ");
            string inputPassagerare = Console.ReadLine();
            int maxPassagerare;
            int.TryParse(inputPassagerare, out maxPassagerare);
            buss.MaxPassagerare = maxPassagerare;
            return buss;
        }
        public static Motorcykel SkapaMc()
        {
            Motorcykel motorcykel = new Motorcykel();
            SkapaFordon(motorcykel);
            Console.WriteLine("Vad har MC:en för maxhastighet: ");
            string inputHastighet = Console.ReadLine();
            int maxHastighet;
            int.TryParse(inputHastighet, out maxHastighet);
            motorcykel.MaxFart = maxHastighet;
            return motorcykel;
        }
        public static Lastbil SkapaLastbil()
        {
            Lastbil lastbil = new Lastbil();
            SkapaFordon(lastbil);
            Console.WriteLine("Hur många kg kan lastbilen frakta: ");
            string inputMaxLast = Console.ReadLine();
            int maxLast;
            int.TryParse(inputMaxLast, out maxLast);
            lastbil.MaxLast = maxLast;
            return lastbil;

        }
      
    }
}
