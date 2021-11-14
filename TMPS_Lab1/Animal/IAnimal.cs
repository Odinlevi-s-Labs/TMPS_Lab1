using System.Runtime.InteropServices;

namespace TMPS_Lab1
{
    public interface IAnimal
    {
        string Name { get; set; }

        int Price { get; set; }

        AgeType AgeType { get; set; }
        
    }
}