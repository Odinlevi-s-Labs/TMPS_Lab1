using System.Runtime.InteropServices;

namespace TMPS_Lab1
{
    public interface IAnimal
    {
        string Name { set; }

        int Price { set; }

        AgeType AgeType { set; }
        
    }
}