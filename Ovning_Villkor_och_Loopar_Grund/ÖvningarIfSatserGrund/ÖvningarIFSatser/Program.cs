using System;

namespace ÖvningarIFSatser
{
    class Program
    {
        static void Main(string[] args)
        {

          
            //övning 10
            #region
            /* int pengar;
             string rabatt;
             string input;
             Console.WriteLine("Hur mycket pengar har du: ");
             input = Console.ReadLine();
             int.TryParse(input, out pengar);
             Console.WriteLine("Har du rabatt? J/N");
             rabatt = Console.ReadLine();
             if(pengar >= 15 && pengar < 25 && rabatt == "N")
             {
                 Console.WriteLine("Du kan köpa en liten burgare");
             }
             else if (pengar >= 15 && pengar < 25 && rabatt == "J")
             {
                 Console.WriteLine("Du kan köpa en liten burgare med pommes");
             }
             else if (pengar >= 25 && pengar < 50 && rabatt == "N")
             {
                 Console.WriteLine("Du kan köpa en grande burgare bröther");
             }
             else if (pengar >= 25 && pengar <= 49 && rabatt == "J")
             {
                 Console.WriteLine("Du kan köpa en big burger med pommes fam");
             }
             else if (pengar > 60 || pengar >= 50 && pengar <= 60 && rabatt == "J")
             {
                 Console.WriteLine("Du kan köpa ett meal med en dryck gringo");
             }*/
            #endregion

            //övning 9
            #region
            /* string bil;
            Console.WriteLine("Skriv in ett bilmärke: ");
            bil = Console.ReadLine();
            if (bil != "Volvo")
            {
                Console.WriteLine("Är det en Volkswagen, BMW eller Audi? Skriv J ifall det är det, om inte skriv N : ");
                bil = Console.ReadLine();
                if(bil == "J")
                {
                    Console.WriteLine("Bilen är tysk");
                }
                else if(bil =="N")
                {
                    Console.WriteLine("Är det en Renault, Peugeot eller Citroen? Skriv J ifall det är det, om inte skriv N: ");
                    bil = Console.ReadLine();
                    if(bil == "J")
                    {
                        Console.WriteLine("Bilen är Fransk!");
                    }
                    else if (bil == "N")
                    {
                        Console.WriteLine("Bilen är varken Svensk, Tysk eller fransk");
                    }
                    
                       
                    
                }
               
            }
            else
            {
                Console.WriteLine("Bilen är varken Svensk, Tysk eller fransk");
            }*/
            #endregion
            //övning 8
            #region
            /*string land;
            Console.WriteLine("Vänligen skriv vilket land du bor i:");
            land = Console.ReadLine();
            if (land == "Sverige" || land == "Danmark" || land == "Norge")
            {
                Console.WriteLine("Du bor i Norden");
            }
            else
            {
                Console.WriteLine("Du bor inte i Norden");
            }*/
            #endregion

            //övning 7
            #region
            /*const string användarnamn = "Calle";
            const string lösenord = "Maelan";
            Console.WriteLine("Ange ditt användarnamn");
            string input = Console.ReadLine();
            Console.WriteLine("Ange ditt lösenord");
            string input2 = Console.ReadLine();
            if (input == användarnamn && input2 == lösenord)
            {
                Console.WriteLine("Du är inloggad");
            }
            else if (input != användarnamn || input2 != lösenord)
            {
                Console.WriteLine("Du har skrivit in antingen fel användarnamn eller lösenord");
            }*/
            #endregion

            //övning 6.
            #region
            /*int födelseår;
            Console.WriteLine("Skriv in ditt födelseår: ");
            string input = Console.ReadLine();
            int.TryParse(input, out födelseår);
            if (födelseår >= 1980 && födelseår <= 1989)
            {
                Console.WriteLine("Du är född på 1980-talet");
            }
            else if (födelseår >= 1990 && födelseår <= 1999)
            {
                Console.WriteLine("Du är född på 1990-talet");
            }
            else if(födelseår < 1980 || födelseår >= 2000)
            {
                Console.WriteLine("Du är inte född på 1990 eller 1980-talen");
            }*/
            #endregion

            //övning 5.
            #region
            /* string input;
             int vuxen = 30;
             int studentPensionär = 20;
             Console.WriteLine("Vilken Kategori tillhör du: Vuxen, Pensionär eller Student? Ange här:");
             input = Console.ReadLine();
             if (input == "Student" || input == "Pensionär")
             {
                 Console.WriteLine($"Resan kostar {studentPensionär} kr.");
             }
             else if (input == "Vuxen")
             {
                 Console.WriteLine($"Resan kostar {vuxen} kr.");
             }
             else
             {
                 Console.WriteLine("Du har angett en icke existerande kategori.");
             }*/

            #endregion

            //övning 4.
            #region
            /*bool körs = true;
            do
            {
                int input;
                string ålder;
                Console.WriteLine("Mata in din ålder");
                ålder = Console.ReadLine();
                int.TryParse(ålder, out input);

                if (input > 0 && input < 18)
                {
                    Console.WriteLine("Du är inte myndig pga under 18.");
                }
                else if (input > 65)
                {
                    Console.WriteLine("Du är pensionär");
                }
                else 
                {
                    Console.WriteLine("Du har inte matat in en siffra eller så är du mellan 18-64");
                }
            } while (körs);*/
            #endregion


            //övning 3.
            #region
            /*double input;
            string feberTermo;
            Console.WriteLine("Ange temperaturen ifrån din febertermometer: ");
            feberTermo = Console.ReadLine();
            double.TryParse(feberTermo, out input);
            if (input >= 37.8 && input <= 39.4)
            {
                Console.WriteLine("Du har feber.");
            }
            else if (input >= 39.5)
            {
                Console.WriteLine("Du bör söka upp en läkare");
            }
            else if (input <= 37.7)
            {
                Console.WriteLine("Du har inte feber");
            }*/
            #endregion

            //övning 2.
            #region
            /*int input;
            string mjölkpaket;
            Console.WriteLine("Hur många mjölkpaket finns kvar?");
            mjölkpaket = Console.ReadLine();
            int.TryParse(mjölkpaket, out input);

            if (input <= 10)
            {
                Console.WriteLine("Beställ 30 paket");
            }
            else if (input > 10 && input < 20)
            {
                Console.WriteLine("Beställ 20 paket");
            }
            else
            {
                Console.WriteLine("Du behöver inte beställa någon mjölk");
            }*/
            #endregion

            //Övning 1.
            #region
            /*Console.WriteLine("Ange ett tal: ");
            int tal = Convert.ToInt32(Console.ReadLine());
            if (tal > 10)
            {
                Console.WriteLine("Talet är större än 10");
            }
            else if (tal < 10)
            {
                Console.WriteLine("Talet är mindre än 10");
            }*/
            #endregion
        }
    }
}
