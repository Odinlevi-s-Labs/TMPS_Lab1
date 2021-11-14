using TMPS_Lab1.Builder;

namespace TMPS_Lab1.Factory
{
    public sealed class YoungAnimalFactory : IFactory
    {
        #region Singleton
        
        private static YoungAnimalFactory instance = null;
        private static readonly object padlock = new object();

        YoungAnimalFactory()
        {
        }

        public static YoungAnimalFactory Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new YoungAnimalFactory();
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
                    _director.GetYoungCat(catBuilder);
                    return catBuilder.Get();
                case "dog":
                    var dogBuilder = new DogBuilder();
                    _director.GetYoungDog(dogBuilder);
                    return dogBuilder.Get();
                case "hamster":
                    var hamsterBuilder = new HamsterBuilder();
                    _director.GetYoungHamster(hamsterBuilder);
                    return hamsterBuilder.Get();
                default:
                    return null;
            }
        }
    }
}