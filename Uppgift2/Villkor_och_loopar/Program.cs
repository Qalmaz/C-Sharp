using System;
using System.Reflection.Metadata.Ecma335;

namespace Villkor_och_loopar
{
    class Program
    {
        static void Main(string[] args)
        { 
            //Variabler för att räkna antal tävlande och vinnaren
            int antalTävlande = 0;
            int vinnareNummer = 0;
            int vinnareTimme = 24;
            int vinnareMinuter = 60;
            int vinnareSekunder = 60;
            bool kör = false;
            //bools för att köra do while loopen och för att beräkna vinnaren i slutet
            bool uppgift2Kör;
            do
            {
                //input som tar in startnummer på tävlande
                Console.WriteLine("Ange startnummer: ");
                string input1 = Console.ReadLine();
                int startnummer = int.Parse(input1);
                uppgift2Kör = startnummer > 0;

                if (uppgift2Kör)
                {
                    //körs om startnumret är över 0 och lägger till +1 till antalet tävlande
                    antalTävlande++;
                    kör = true;
                    //input för att ange timmen den tävlande startade på.
                    Console.WriteLine("Ange timme vid start; ");
                    string input2 = Console.ReadLine();
                    int timmeStart = int.Parse(input2);
                    //int timmeTillSek = timmeStart * 60 * 60; GAMMAL kod som jag inte längre ville använda
                    //men som visar hur jag tänkte ursprungligen
                    //Nedan kommer vara flera inputs för timmar/minuter/sekunder för start/mål
                    //sedan är de som står under själva inputsen utkommenterade för att jag inte använde det sättet i slutändan.
                    Console.WriteLine("Ange minut vid start; ");
                    string input3 = Console.ReadLine();
                    int minutStart = int.Parse(input3);
                    //int minutTillSek = minutStart * 60;

                    Console.WriteLine("Ange sekund vid start; ");
                    string input4 = Console.ReadLine();
                    int sekundStart = int.Parse(input4);


                    Console.WriteLine("Ange timme vid mål; ");
                    string input5 = Console.ReadLine();
                    int timmeMål = int.Parse(input5);
                    //int timmeTillSekMål = timmeMål * 60 * 60;

                    Console.WriteLine("Ange minut vid mål; ");
                    string input6 = Console.ReadLine();
                    int minutMål = int.Parse(input6);
                    //int minutTillSekMål = minutMål * 60;

                    Console.WriteLine("Ange sekund vid mål; ");
                    string input7 = Console.ReadLine();
                    int sekundMål = int.Parse(input7);
                    
                    //Räknar ut timmar som det tog för den tävlande
                    if (timmeMål <= timmeStart)
                        timmeMål = timmeStart + (24 - timmeStart + timmeMål);
                    int timmarTotalt = timmeMål - timmeStart;
                    //räknar ut minuter som det tog för den tävlande.
                    if (minutMål <= minutStart)
                    {
                        timmarTotalt--;
                        minutMål = minutStart + (60 - minutStart + minutMål);
                    }
                    int totalaMinuter = minutMål - minutStart;
                    //räknar ut antalet sekunder det tog för den tävlande.
                    if (sekundMål <= sekundStart)
                    {
                        totalaMinuter--;
                        sekundMål = sekundStart + (60 - sekundStart + sekundMål);
                    }
                    int totalaSekunder = sekundMål - sekundStart;
                    //konverterar sekunder till minuter när sekunder överskrider 60 som uppfyller en minut.
                    if (totalaSekunder == 60)
                    {
                        totalaMinuter++;
                        totalaSekunder = 0;
                    }
                    //konverterar minuter till timmar när minuter överskirder 60 som uppfyller en timme.
                    if (totalaMinuter == 60)
                    {
                        timmarTotalt++;
                        totalaMinuter = 0;
                    }
                    //Räknar ut totala tiden i sekunder för den senaste inputen och vinnar tiden
                    int totalaTidenSekunder = timmarTotalt * 60 * 60 + totalaMinuter * 60 + totalaSekunder;
                    int vinnareTotalaSekunder = vinnareTimme * 60 * 60 + vinnareMinuter * 60 + vinnareSekunder;
                    //jämför senaste inputen med den bästa tiden och byter ut den ifall villkoret uppfylls
                    if (totalaTidenSekunder <= vinnareTotalaSekunder)
                    {
                        vinnareTimme = timmarTotalt;
                        vinnareMinuter = totalaMinuter;
                        vinnareSekunder = totalaSekunder;
                        vinnareNummer = startnummer;
                    }
                }

                
                //Gammal kod utkommenterad nedan
               /* string totalaTiden = ($"Startnummer:{startnummer} Och din totala tid blev: {(timmeTillSekMål + minutTillSekMål + sekundMål) - (timmeTillSek + minutTillSek + sekundStart)}");
                Console.WriteLine($"{totalaTiden}");*/
            } while (uppgift2Kör);
            //körs när startnumret som anges är 0 eller mindre och skriver ut den bästa tiden och antal tävlande
            if (kör)
            {
                Console.WriteLine($"Tävlande med nummer {vinnareNummer} är vinnaren.");
                Console.WriteLine($"Med en tid på:{vinnareTimme}  timmar {vinnareMinuter}  minuter {vinnareSekunder} sekunder.");
                Console.WriteLine($"Antalet deltagare: {antalTävlande}");
            }
            //annars skriver vi ut att det inte var några tävlande som deltog.
            else
            {
                Console.WriteLine("Du skrev inte in någa tävlande.");
            }
           
        }
    }
}



