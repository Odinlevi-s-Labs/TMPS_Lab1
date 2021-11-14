namespace TMPS_Lab1
{
    public class Cat : Animal
    {
        public override string ToString()
        {
            return "Cat" + ": " + 
                   "Name = " + name + ", " + 
                   "Age type = " + ageType + ", " + 
                   "Price = " + price;
        }

    }
}