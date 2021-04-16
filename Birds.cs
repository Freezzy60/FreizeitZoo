using System;
using System.Collections.Generic;
using System.Text;

namespace FreizeitZoo
{
    class Birds
    {
        string AName;
        string Family;
        int BreedingSeason;
        int Lifespan;
        

        public Birds(string aName, string family, int breedingSeason,int lifespan)
        {
            this.AName = aName;
            this.Family = family;
            this.BreedingSeason = breedingSeason;
            this.Lifespan = lifespan;
            
        }

        public string BirdsData()
        {
            return $"Animal Name:{AName}\nFamily:{Family}\nBreeding Season:{BreedingSeason}days\nLifespan:{Lifespan}Years";
        }
    }
}
