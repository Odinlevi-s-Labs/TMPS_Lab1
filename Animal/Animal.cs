namespace TMPS_Lab1
{
    public class Animal : IAnimal
    {
        protected string name;
        protected AgeType ageType;
        protected int price;

        public string Name {get => name;  set => name = value; }
        public AgeType AgeType
        {
            get => ageType;
            set => ageType = value; }
        public int Price
        { get => price; set => price = value; }

        public override string ToString()
        {
            return "Animal" + ": " + 
                   "Name = " + name + ", " + 
                   "Age type = " + ageType + ", " + 
                   "Price = " + price;
        }
    }
}