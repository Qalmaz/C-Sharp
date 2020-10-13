using System;
using System.Collections.Generic;

namespace Klasser
{
    public class ListUtskrift:Fordon
    {
        public static void SkrivUtFordon(List<Fordon> FordonsLista)
        {
            if (FordonsLista.Count == 0)
            {
                Console.WriteLine("Inga fordon har blivit registrerade ännu");
                return;
            }
            Console.WriteLine("Registrerade bilar:");
            for (int i = 0; i < FordonsLista.Count; i++)
            {
                if (FordonsLista[i] is Bil bil)
                {
                    Console.WriteLine($"\n\n\tModellen: {bil.Model} \n\tRegistreringsnummer: {bil.RegNr}" +
                        $"\n\n\tAntal mil körda på mätaren: {bil.MilesTravelled} \n\tNär fordonet registrerades: {bil.Registered}");
                    if (bil.DragKrok == true)
                    {
                        Console.WriteLine("\tDragkrok: bilen har en dragkrok");
                    }
                   
                }
                if (FordonsLista[i] is Buss buss)
                {
                    Console.WriteLine($"\n\n\tModellen: {buss.Model} \n\tRegistreringsnummer: {buss.RegNr}" +
                        $"\n\n\tAntal mil körda på mätaren: {buss.MilesTravelled} \n\tNär fordonet registrerades: {buss.Registered} \n\tMax antal passagerare: {buss.MaxPassagerare}");
                }
                if (FordonsLista[i] is Motorcykel motorcykel)
                {
                    Console.WriteLine($"\n\n\tModellen: {motorcykel.Model} \n\tRegistreringsnummer: {motorcykel.RegNr}" +
                        $"\n\n\tAntal mil körda på mätaren: {motorcykel.MilesTravelled} \n\tNär fordonet registrerades: {motorcykel.Registered} \n\tTopphastighet: {motorcykel.MaxFart}");
                }
                if (FordonsLista[i] is Lastbil lastbil)
                {
                    Console.WriteLine($"\n\n\tModellen: {lastbil.Model} \n\tRegistreringsnummer: {lastbil.RegNr}" +
                        $"\n\n\tAntal mil körda på mätaren: {lastbil.MilesTravelled} \n\tNär fordonet registrerades: {lastbil.Registered} \n\tMaxlast i kg: {lastbil.MaxLast}");
                }
            }
        }
    }
}
