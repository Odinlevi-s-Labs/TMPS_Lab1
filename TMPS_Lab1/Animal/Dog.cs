namespace TMPS_Lab1
{
    public class Dog : Animal
    {
        public override string ToString()
        {
            return "Dog" + ": " + 
                   "Name = " + name + ", " + 
                   "Age type = " + ageType + ", " + 
                   "Price = " + price;
        }
    }
}