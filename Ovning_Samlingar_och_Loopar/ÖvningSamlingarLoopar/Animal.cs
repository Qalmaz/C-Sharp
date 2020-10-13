using System;
using System.Collections.Generic;
using System.Text;

namespace ÖvningSamlingarLoopar.Entities
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        

        public void Run()
        {
            Console.WriteLine("Weee Im running BOI");
        }
        public void Eat()
        {
            Console.WriteLine("Nu har jag ätit och är mätt!");
        }
        public virtual int GetAge()
        {
            return Age;
        }
    }
    public class Dog: Animal
    {
        public override int GetAge()
        {
            return Age * 7;
        }
    }
    public class Cat: Animal
    {
        public override int GetAge()
        {
            return Age * 5;
        }
    }
    public class Rabbit: Animal
    {
        public override int GetAge()
        {
            return Age * 15;
        }
    }
}