﻿namespace TMPS_Lab1
{
    public class Hamster : IAnimal
    {
        private string _name;
        private AgeType _ageType;
        private int _price;

        public string Name { set => _name = value; }
        public AgeType AgeType { set => _ageType = value; }
        public int Price { set => _price = value; }
        
        public override string ToString()
        {
            return "Hamster" + ": " + 
                   "Name = " + _name + ", " + 
                   "Age type = " + _ageType + ", " + 
                   "Price = " + _price;
        }
    }
}