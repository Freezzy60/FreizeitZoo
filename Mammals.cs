using System;
using System.Collections.Generic;
using System.Text;

namespace FreizeitZoo
{

    class Mammals
    {
        string AName;
        string Family;
        int Pregnancy;
        int Weight;
        int Lifespan;
        string Habitat;

        public Mammals(string aName, string family, int pregnancy, int weight, int lifespan, string habitat)
        {
            this.AName = aName;
            this.Family = family;
            this.Pregnancy = pregnancy;
            this.Weight = weight;
            this.Lifespan = lifespan;
            this.Habitat = habitat;
        }

        public string MammalsDaten()
        {
            return $"Animal Name:{AName}\nFamily:{Family}\nPregnancy Length:{Pregnancy}months\nWeight:{Weight}Kg\nLifespan:{Lifespan}years\nHabitat:{Habitat}";
        }




    }
}
