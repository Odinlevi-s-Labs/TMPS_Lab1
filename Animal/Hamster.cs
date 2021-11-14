namespace TMPS_Lab1
{
    public class Hamster : Animal
    {
        public override string ToString()
        {
            return "Hamster" + ": " + 
                   "Name = " + name + ", " + 
                   "Age type = " + ageType + ", " + 
                   "Price = " + price;
        }
    }
}