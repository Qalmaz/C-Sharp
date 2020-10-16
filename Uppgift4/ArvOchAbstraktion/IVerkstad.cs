using Klasser;
using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace ArvOchAbstraktion
{
    public interface IVerkstad
    {
        public void AddFordon(Fordon fordon);
        public void RemoveFordon(Fordon fordon);
        Fordon HittaFordon(string regNr);
        public void PrintAllFordon(Verkstad verkstad);
        public void PrintOutFordon(Fordon fordon);
                      
    }
    public class Verkstad : IVerkstad
    {
        
        public static List<Fordon> FordonsLista = new List<Fordon>();
        public void AddFordon(Fordon fordon)
        {
            FordonsLista.Add(fordon);

        }

        public void RemoveFordon(Fordon fordon)
        {
            FordonsLista.Remove(fordon);
        }
            
        /*public void PrintAllFordon(Verkstad verkstad)
        {
            foreach (object item in FordonsLista)
            {
                Console.WriteLine(item.ToString());

            }

        }*/

        /*public void PrintOutFordon(Fordon fordon) 
        {
           if (FordonsLista.Contains(fordon))
            {
                Console.WriteLine(fordon);
            }
        }*/
     
        public Fordon HittaFordon(string regNr)
        {
            foreach (Fordon fordon in FordonsLista)
            {

                if (fordon.RegNr == regNr)
                {
                    FordonsLista.Remove(fordon);
                    return fordon;
                }
            }
            return null;
        }
    } 
}

