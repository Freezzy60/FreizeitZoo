using System;
using System.Collections.Generic;
using System.Text;

namespace FreizeitZoo
{
    class Reptiles
    {
        string AName;
        string Family;
        int IncubationOfEggs;
        double Weight;
        int Lifespan;
        string Habitat;

        public Reptiles(string aName, string family, int incubatinOfEggs, double weight, int lifespan, string habitat)
        {
            this.AName = aName;
            this.Family = family;
            this.IncubationOfEggs = incubatinOfEggs;
            this.Weight = weight;
            this.Lifespan = lifespan;
            this.Habitat = habitat;
        }

        public string ReptilesDaten()
        {
            return $"Animal Name:{AName}\nFamily:{Family}\nIncubation of Eggs:{IncubationOfEggs} days\nWeight:{Weight}Kg\nLifespan:{Lifespan}years\nHabitat:{Habitat}";
        }

    }
}
