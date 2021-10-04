namespace TMPS_Lab1.Builder
{
    public class DogBuilder : IAnimalBuilder
    {
        private Dog _dog;

        public DogBuilder()
        {
            Reset();
        }
        
        public string Name
        {
            set => _dog.Name = value;
        }

        public AgeType AgeType
        {
            set => _dog.AgeType = value;
        }

        public int Price
        {
            set => _dog.Price = value;
        }
        
        public void Reset()
        {
            _dog = new Dog();
        }

        public Dog Get()
        {
            var dog = _dog;
            Reset();

            return dog;
        }
    }
}