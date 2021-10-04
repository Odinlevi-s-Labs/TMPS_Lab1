namespace TMPS_Lab1.Builder
{
    public interface IAnimalBuilder
    {
        string Name { set; }
        AgeType AgeType { set; }
        int Price { set; }

        void Reset();
    }
}