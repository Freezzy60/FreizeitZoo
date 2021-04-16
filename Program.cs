using System;
using System.Collections.Generic;

namespace FreizeitZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome at the Zoo");
            Zoo zoo = new Zoo();

            List<Mammals> mammalsList = zoo.generateMammels();
            List<Reptiles> reptilesList = zoo.generateReptiles();
            List<Birds> birdsList = zoo.generateBirds();
            List<Fish> fishList = zoo.generateFish();

            Console.WriteLine("Number of total animal species:");
            Console.WriteLine(mammalsList.Count + reptilesList.Count + birdsList.Count + fishList.Count);
            while (true)
            {

                Console.WriteLine("Press (m) to get to the Mammals Area");
                Console.WriteLine("Press (r) to get to the Reptiles Area");
                Console.WriteLine("Press (b) to get to the Birds Area");
                Console.WriteLine("Press (f) to get to the Fish Aquarium");

                string comand = Console.ReadLine();


                if (comand == "m")
                {

                    Console.WriteLine("Mammals Area");
                    Console.WriteLine("Number of Mammal Species:");
                    Console.WriteLine(mammalsList.Count);
                    Console.WriteLine();
                    foreach (Mammals x in mammalsList)
                    {
                        Console.WriteLine(x.MammalsDaten());
                        Console.WriteLine();
                    }
                }



                if (comand == "r")
                {
                    Console.WriteLine("Reptiles Area");
                    Console.WriteLine("Number of Reptiles species:");
                    Console.WriteLine(reptilesList.Count);
                    Console.WriteLine();
                    foreach (Reptiles x in reptilesList)
                    {
                        Console.WriteLine(x.ReptilesDaten());
                        Console.WriteLine();
                    }
                }



                if (comand == "b")
                {
                    Console.WriteLine("Birds Area");
                    Console.WriteLine("Numbers of Birds species:");
                    Console.WriteLine(birdsList.Count);
                    Console.WriteLine();
                    foreach (Birds b in birdsList)
                    {
                        Console.WriteLine(b.BirdsData());
                        Console.WriteLine();
                    }
                }



                if (comand == "f")
                {
                    Console.WriteLine("Fish Aquarium");
                    Console.WriteLine("Numbers of Fish species:");
                    Console.WriteLine(fishList.Count);
                    Console.WriteLine();
                    foreach (Fish f in fishList)
                    {
                        Console.WriteLine(f.FishData());
                        Console.WriteLine();
                    }
                }
 
            }
            
        }

    }
}
