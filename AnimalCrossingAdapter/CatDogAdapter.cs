namespace TMPS_Lab1
{
    public class CatDogAdapter : IAnimalCrossingAdapter
    {
        public IAnimal Cross(IAnimal cat, IAnimal dog)
        {
            if (cat is not Cat || dog is not Dog)
                return null;
            
            float averagedAge = ((int)cat.AgeType + (int)dog.AgeType) / 2;
            
            Animal newAnimal = new Animal
            {
                Name = "CatDog",
                AgeType = SetupAge(averagedAge),
                Price = 999999
            };
            
            return newAnimal;
        }

        private AgeType SetupAge(float averagedAge)
        {
            switch (averagedAge)
            {
                case var _ when averagedAge <= 0.5:
                    return AgeType.NewBorn;
                case var _ when averagedAge <= 1.5:
                    return AgeType.Young;
            }

            return AgeType.Old;
        }
    }
}