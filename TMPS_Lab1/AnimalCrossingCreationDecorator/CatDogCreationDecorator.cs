using System;
using TMPS_Lab1.Factory;

namespace TMPS_Lab1
{
    public class CatDogCreationDecorator : CatDogAdapter
    {
        public IAnimal Create()
        {
            IFactory newbornAnimalFactory = NewbornAnimalFactory.Instance;
            
            var newbornCat = newbornAnimalFactory.Choose("cat");
            var newbornDog = newbornAnimalFactory.Choose("dog");

            var catDog = Cross(newbornCat, newbornDog);

            PlayTheTheme();

            return catDog;

        }

        private void PlayTheTheme()
        {
            Console.WriteLine("One fine day with a woof and a purr\n" +
                              "A baby was born and it caused a little stir\n" +
                              "No blue buzzard, no three-eyed frog\n" +
                              "Just a feline, canine little catdog\n" +
                              "Catdog\n" +
                              "Catdog\n" +
                              "Alone in the world was a little catdog\n" +
                              "Out on the road, or back in town\n" +
                              "All kinda critters putting catdog down\n" +
                              "Gotta rise above it, gotta try to get along\n" +
                              "Gotta work together, gotta sing this song\n" +
                              "Catdog\n" +
                              "Catdog\n" +
                              "Alone in the world was a little catdog\n" +
                              "Catdog\n" +
                              "Catdog\n" +
                              "Alone in the world was a little catdog\n" +
                              "Alone in the world was a little catdog\n");
        }
    }
}