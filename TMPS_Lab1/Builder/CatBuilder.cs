namespace TMPS_Lab1.Builder
{
    public class CatBuilder : IAnimalBuilder
    {
        private Cat _cat;

        public CatBuilder()
        {
            Reset();
        }
        
        public string Name
        {
            set => _cat.Name = value;
        }

        public AgeType AgeType
        {
            set => _cat.AgeType = value;
        }

        public int Price
        {
            set => _cat.Price = value;
        }
        
        public void Reset()
        {
            _cat = new Cat();
        }

        public Cat Get()
        {
            var cat = _cat;
            Reset();

            return cat;
        }
    }
}