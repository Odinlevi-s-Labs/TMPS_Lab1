using TMPS_Lab1.Builder;

namespace TMPS_Lab1.Factory
{
    public sealed class OldAnimalFactory : IFactory
    {
        #region Singleton
        
        private static OldAnimalFactory instance = null;
        private static readonly object padlock = new object();

        OldAnimalFactory()
        {
        }

        public static OldAnimalFactory Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new OldAnimalFactory();
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
                    _director.GetOldCat(catBuilder);
                    return catBuilder.Get();
                case "dog":
                    var dogBuilder = new DogBuilder();
                    _director.GetOldDog(dogBuilder);
                    return dogBuilder.Get();
                case "hamster":
                    var hamsterBuilder = new HamsterBuilder();
                    _director.GetOldHamster(hamsterBuilder);
                    return hamsterBuilder.Get();
                default:
                    return null;
            }
        }
    }
}