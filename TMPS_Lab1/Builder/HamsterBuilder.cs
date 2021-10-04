namespace TMPS_Lab1.Builder
{
    public class HamsterBuilder : IAnimalBuilder
    {
        private Hamster _hamster;

        public HamsterBuilder()
        {
            Reset();
        }
        
        public string Name
        {
            set => _hamster.Name = value;
        }

        public AgeType AgeType
        {
            set => _hamster.AgeType = value;
        }

        public int Price
        {
            set => _hamster.Price = value;
        }
        
        public void Reset()
        {
            _hamster = new Hamster();
        }

        public Hamster Get()
        {
            var hamster = _hamster;
            Reset();

            return hamster;
        }
    }
}