using System;
using TMPS_Lab1.AnimalCrossingFacade;
using TMPS_Lab1.Factory;

namespace TMPS_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here client starts to work with the application!");
            
            IFactory oldAnimalFactory = OldAnimalFactory.Instance;
            
            var oldCat = oldAnimalFactory.Choose("cat");
            var oldDog = oldAnimalFactory.Choose("dog");
            var oldHamster = oldAnimalFactory.Choose("hamster");

            Console.WriteLine(oldCat.ToString());
            Console.WriteLine(oldDog.ToString()); 
            Console.WriteLine(oldHamster.ToString());
            
            Console.WriteLine("V2!");

            var catDogCrossingFacade = new CatDogCrossingFacade();
            
            Console.WriteLine("Let's create a CatDog!");
            var catDog = catDogCrossingFacade.Create();

            Console.WriteLine(catDog.ToString());
        }
    }
}