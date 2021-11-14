namespace TMPS_Lab1.AnimalCrossingFacade
{
    public class CatDogCrossingFacade : IAnimalCrossingFacade
    {
        public IAnimal Create()
        {
            var catDogCreationDecorator = new CatDogCreationDecorator();

            return catDogCreationDecorator.Create();
        }
    }
}