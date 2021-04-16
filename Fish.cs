using System;
using System.Collections.Generic;
using System.Text;

namespace FreizeitZoo
{
    class Fish
    {
        string FName;
        string Family;
        int Size;
        int Weight;
        int Lifespan;

        public Fish(string fName, string family, int size, int weight, int lifespan)
        {
            this.FName = fName;
            this.Family = family;
            this.Size = size;
            this.Weight = weight;
            this.Lifespan = lifespan;
        }

        public string FishData()
        {
            return $"Fish Name:{FName}\nFamily:{Family}\nSize:{Size}cm\nWeight:{Weight}kg\nLifespan:{Lifespan}years";
        }
    }
}
