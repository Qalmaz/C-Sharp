using System;
using System.Collections.Generic;

namespace Klasser
{
    public class Bil:Fordon
    {
        public bool DragKrok { get; set; }

        public Bil()
        {
            if (!DragKrok == false)
            {
                Console.WriteLine("Bilen har en dragkrok");
            }
        }   
    }
}
