namespace TMPS_Lab1.Factory
{
    public interface IFactory
    {
        IAnimal Choose(string type);
    }
}