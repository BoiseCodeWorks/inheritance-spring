using System;
using System.Collections.Generic;
using inheritance.Models;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat MrSnibbley = new Cat("Mr. Snibbley", new List<string>(){"grey", "white"}, "soul");
            Dog bingo = new Dog("Bingo", new List<string>(){"brown"}, "bones" );
            Bird tweety = new Bird("Tweety", new List<string>(){"Yellow"}, "bird seed");
            bingo.Eat("bones");
            System.Console.WriteLine(tweety.Legs);

            List<Animal> animals = new List<Animal>();

            animals.Add(MrSnibbley);
            animals.Add(bingo);

            Cat testCat = (Cat)animals.Find(a=> a.Name == "Mr. Snibbley");
            testCat.Hairball();
        }
    }
}
