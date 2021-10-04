using TMPS_Lab1.Builder;

namespace TMPS_Lab1.Factory
{
    public sealed class NewbornAnimalFactory : IFactory
    {
        #region Singleton
        
        private static NewbornAnimalFactory instance = null;
        private static readonly object padlock = new object();

        NewbornAnimalFactory()
        {
        }

        public static NewbornAnimalFactory Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new NewbornAnimalFactory();
                    }
                    return instance;
                }
            }
        }
        
        #endregion
        
        private BuilderDirector _director = new BuilderDirector();
        
        public IAnimal Choose(string type)
        {
            switch (type)
            {
                case "cat":
                    var catBuilder = new CatBuilder();
                    _director.GetNewBornCat(catBuilder);
                    return catBuilder.Get();
                case "dog":
                    var dogBuilder = new DogBuilder();
                    _director.GetNewBornDog(dogBuilder);
                    return dogBuilder.Get();
                case "hamster":
                    var hamsterBuilder = new HamsterBuilder();
                    _director.GetNewBornHamster(hamsterBuilder);
                    return hamsterBuilder.Get();
                default:
                    return null;
            }
        }
    }
}