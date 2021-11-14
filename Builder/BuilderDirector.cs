namespace TMPS_Lab1.Builder
{
    public class BuilderDirector
    {
        public IAnimalBuilder GetNewBornCat(CatBuilder builder)
        {
            builder.Reset();
            builder.Name = "Marley";
            builder.AgeType = AgeType.NewBorn;
            builder.Price = 750;

            return builder;
        }
        
        public IAnimalBuilder GetNewBornDog(DogBuilder builder)
        {
            builder.Reset();
            builder.Name = "Chico";
            builder.AgeType = AgeType.NewBorn;
            builder.Price = 600;

            return builder;
        }
        
        public IAnimalBuilder GetNewBornHamster(HamsterBuilder builder)
        {
            builder.Reset();
            builder.Name = "WaBa";
            builder.AgeType = AgeType.NewBorn;
            builder.Price = 500;

            return builder;
        } 
        
        public IAnimalBuilder GetYoungCat(CatBuilder builder)
        {
            builder.Reset();
            builder.Name = "Ace";
            builder.AgeType = AgeType.Young;
            builder.Price = 300;

            return builder;
        }
        
        public IAnimalBuilder GetYoungDog(DogBuilder builder)
        {
            builder.Reset();
            builder.Name = "Grace";
            builder.AgeType = AgeType.Young;
            builder.Price = 200;

            return builder;
        }
        
        public IAnimalBuilder GetYoungHamster(HamsterBuilder builder)
        {
            builder.Reset();
            builder.Name = "Coco";
            builder.AgeType = AgeType.Young;
            builder.Price = 100;

            return builder;
        }

        public IAnimalBuilder GetOldCat(CatBuilder builder)
        {
            builder.Reset();
            builder.Name = "Rambo";
            builder.AgeType = AgeType.Old;
            builder.Price = 30;

            return builder;
        }

        public IAnimalBuilder GetOldDog(DogBuilder builder)
        {
            builder.Reset();
            builder.Name = "Thanos";
            builder.AgeType = AgeType.Old;
            builder.Price = 20;

            return builder;
        }
        
        public IAnimalBuilder GetOldHamster(HamsterBuilder builder)
        {
            builder.Reset();
            builder.Name = "Yoda";
            builder.AgeType = AgeType.Old;
            builder.Price = 10;

            return builder;
        }
    }
}