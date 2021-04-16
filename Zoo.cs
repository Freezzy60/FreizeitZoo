using System;
using System.Collections.Generic;
using System.Text;

namespace FreizeitZoo
{
   class Zoo
    {
        public List<Mammals> generateMammels()
        {
            List<Mammals> mammalsList = new List<Mammals>();

            Mammals AfricanElephant = new Mammals("African Elephant", "Elephant", 22, 6000, 50, "CenterSouth Africa");
            mammalsList.Add(AfricanElephant);

            Mammals Bison = new Mammals("Bison", "Horned", 9, 800, 25, "North America");
            mammalsList.Add(Bison);

            Mammals Hippopotamus = new Mammals("Hippopotamus", "Hippo", 240, 3000, 55, "Center Africa");
            mammalsList.Add(Hippopotamus);

            Mammals Cheetah = new Mammals("Cheeatah", "Cats", 3, 65, 15, "Center Africa");
            mammalsList.Add(Cheetah);

            Mammals Giraffe = new Mammals("Giraffe", "Giraffe", 15, 800, 35, "Ost-South Africa");
            mammalsList.Add(Giraffe);

            Mammals Buffalo = new Mammals("Buffalo", "Horned", 11, 1000, 20, "South-Ost Asia");
            mammalsList.Add(Buffalo);

            Mammals Lion = new Mammals("Lion", "Cats", 4, 250, 25, "Center-South Africa");
            mammalsList.Add(Lion);

            return mammalsList;
        }

        public List<Reptiles> generateReptiles()
        {
            List<Reptiles> reptilesList = new List<Reptiles>();

            Reptiles BumpyCrocodile = new Reptiles("Bumby Crocodile", "Crocodile", 95, 60, 50, "Central America");
            reptilesList.Add(BumpyCrocodile);

            Reptiles BatagurRiverTurtle = new Reptiles("BAtagur river Turtle", "Pond Turtels", 100, 80, 80, "South-East Asia");
            reptilesList.Add(BatagurRiverTurtle);

            Reptiles Baratgame = new Reptiles("Baratgame", "Agamen", 65, 0.500, 20, "Australia");
            reptilesList.Add(Baratgame);

            Reptiles EuropeanPondTurtle = new Reptiles("European Pond Turtle", "Pond Turtels", 100, 1, 60, "South-East Europe");
            reptilesList.Add(EuropeanPondTurtle);

            return reptilesList;
        }

         public List<Birds> generateBirds()
        {
            List<Birds> birdsList = new List<Birds>();

            Birds BeardedVulture = new Birds("Bearded Vulture", "Habichtartige", 60, 44);
            birdsList.Add(BeardedVulture);

            Birds UralOwl = new Birds("Ural Owl", "Ear Owls", 29, 25);
            birdsList.Add(UralOwl);

            Birds AfricanGrayParrot = new Birds("Gray Parrot", "Parrot", 30, 60);
            birdsList.Add(AfricanGrayParrot);

            Birds HumboldtPenguin = new Birds("Humboldt Penguin", "Penguin", 39, 18);
            birdsList.Add(HumboldtPenguin);

            Birds KingPenguin = new Birds("King Penguin", "Penguin", 56, 12);
            birdsList.Add(KingPenguin);

            return birdsList;
        }

        public List<Fish> generateFish()
        {
            List<Fish> fishList = new List<Fish>();

            Fish Brachse = new Fish("Brachse", "Karpfen", 82, 8, 20);
            fishList.Add(Brachse);

            Fish Hecht = new Fish("Hecht", "Hechte", 125, 15, 8);
            fishList.Add(Hecht);

            Fish Huchen = new Fish("Huchen", "Salmon fish", 1500, 30, 25);
            fishList.Add(Huchen);

            Fish Roach = new Fish("Roach", "Karpfen", 50, 1, 15);
            fishList.Add(Roach);

            return fishList;
        }
       
    }
}
