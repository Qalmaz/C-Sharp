using System;
using System.Threading;

namespace ÖvningarVillkorLooparGrund
{
    class Program
    {
        static void Main(string[] args)
        {
            //övning 10. Låter användaren pröva logga in med förbestämt användarnamn o lösenord.
            //är inmatningen korrekt skriver den ut "du är inloggad" annars frågar den om användaren vill försöka igen.
            #region
            /*bool körs = true;
            do
            {

            
            const string användarnamn = "abc123";
            const string lösenord = "password";

            Console.WriteLine("Ange användarnamn: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Ange Lösenord: ");
            string passWord = Console.ReadLine();

                if (userName == användarnamn && passWord == lösenord)
                {
                    Console.WriteLine("Du är inloggad");
                    körs = false;
                }
                else if (userName != användarnamn || passWord != lösenord)
                {
                    Console.WriteLine("Detta var felaktigt, vill du försöka igen? Y/N");
                    string tryAgain = Console.ReadLine();
                    if (tryAgain == "Y")
                    {
                        körs = true;
                    }
                    else if (tryAgain == "N")
                    {
                        Console.WriteLine("Avslutar programmet.");
                        Console.ReadLine();
                        körs = false;
                    }
                    else
                    {
                        Console.WriteLine("Du skrev inget av alternativen. Avslutar programmet");
                        körs = false;
                    }
                }
            } while (körs);*/
            #endregion


            //övning 9. Tar in 4 olika användainmatningar och kollar så att något har skrivits på alla, annars får man pröva igen.
            #region
            /*bool körs = true;
            do
            {
                int postnr = 0;
                Console.WriteLine("Ange ditt Namn: ");
                var namn = Console.ReadLine();
                string test1 = namn;
                Console.WriteLine("Ange din Adress: ");
                var adress = Console.ReadLine();
                string test2 = adress;
                Console.WriteLine("Ange ditt postnummer: ");
                postnr = Convert.ToInt32(Console.ReadLine());
                int test3 = postnr;
                Console.WriteLine("Ange din postort: ");
                var postort = Console.ReadLine();
                string test4 = postort;
               
                if (namn == null || adress == null || postnr <= 10000  || postort == null)
                {
                    Console.WriteLine("Du missade något någonstans, försök igen!");
                   
                    
                }
                else 
                {
                    Console.WriteLine($"Ditt namn är {namn} och du bor på adress {adress}, som har postnumret {postnr} och ligger i {postort}");
   
                }
            }
             while (körs);*/
            #endregion

            //övning 8. Användaren matar in ett tal som sedan kollas om det är större eller mindre än 30 eller en felaktig input
            //av användaren. Är talet mindre än 30 skrivs siffrorna som saknas ifrån inputen upp till 30 ut.
            #region
            /*bool körs = true;
            do
            {
                int input;
                Console.WriteLine("Mata in ett tal");
                string inputStr = Console.ReadLine();
                int.TryParse(inputStr, out input);
                if (input < 30)
                {
                    Console.WriteLine("Talet är mindre än 30");
                    for (int i = input; i < 30; i++)
                    {
                        Console.WriteLine(i);
                    }
                }
                else if (input >= 30)
                {
                    Console.WriteLine("Talet är större än 30");
                }
                else
                {
                    Console.WriteLine("Du har inte matat in ett tal");
                }
            } while (körs);*/
            #endregion

            //övning 7 Udda tal upp till 100
            #region
            /*int i = 1;
            while (i < 100)
            {
                i += 2;
                Console.WriteLine(i);
            }*/
            #endregion

            //övning 6 Testar ifall talet är större, mindre eller lika med 10
            #region
            /*bool körs = true;
            do
            {
                Console.WriteLine("Mata in ett tal");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input > 10)
                {
                    Console.WriteLine("Talet är för stort");
                }
                if (input < 10)
                {
                    Console.WriteLine("Värdet är för lågt");
                }
                else if (input == 10)
                {
                    Console.WriteLine("Talet är exakt som det ska vara, 10!");
                    körs = false;

                }
            }
            while (körs);*/
            #endregion

            //övning 5. Räknar ned till 1 ifrån inmatade talet
            #region
            /*Console.WriteLine("Mata in ett tal: ");
            int tal = Convert.ToInt32(Console.ReadLine());
            while(tal>0)
            {
                tal--;
                Console.WriteLine(tal);
            }*/
            #endregion

            //övning 4. Användaren matar in 10 nummer som adderas ihop i slutet.
            #region
            /*int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Skriv in ett tal: ");
                var tal = Convert.ToInt32(Console.ReadLine());
                sum = sum + tal;
            }
            Console.WriteLine(sum);*/
            #endregion

            //övning 3. Användaren matar in två nummer som adderas ihop, sedan får användaren välja att fortsätta eller inte.
            #region
            /*bool körs = true;
            do
            {
                Console.WriteLine("Skriv in två nummer");
                Console.WriteLine("Skriv in det första numret: ");
                int input1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Skriv in det andra numret: ");
                int input2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(input1 + input2);

                Console.WriteLine("Vill du fortsätta J/N");
                string goOrNoGo = Console.ReadLine();
                if (goOrNoGo == "J")
                {
                    körs = true;
                }
                else if (goOrNoGo == "N")
                {
                    körs = false;
                }
            }
            while (körs);*/
            #endregion


            //övning 2. Användaren matar in två nummer som loopas och skriver ut vilka siffror som är mellan de två inmatade siffrorna.
            #region
            /*Console.WriteLine("Skriv in två nummer");
            Console.WriteLine("Skriv in det första numret: ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv in det andra numret: ");
            int input2 = Convert.ToInt32(Console.ReadLine());

            for (int i = input1+1; i < input2; i++)
            {
                Console.WriteLine(i);
            }*/
            #endregion


            //Övning 1. Loopar och skriver ut 1-10.
            #region
            /*for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(i);
            }*/
            #endregion
        }
    }
}
