using System;
using Zoo.Classes;
using System.Collections.Generic;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate objects from concrete classes
            ScottishFold waffles = new ScottishFold("Waffles");
            Sphynx cleo = new Sphynx("Cleopatra");
            MaineCoon simba = new MaineCoon("Simba");
            Mouse minnie = new Mouse("Minnie");
            Rat rat = new Rat("PizzaRat");
            SoftShellTurtle softie = new SoftShellTurtle("Softie");
            SeaTurtle wen = new SeaTurtle("Wen");

            // Display properties and behaviors. Categorize them in two main loops. Concrete animals inheriting from the Cat class, Turtle class, and Rodent Class.
            var cats = new List<Cat> { waffles, cleo, simba };

            Console.WriteLine("********************************** WELCOME TO MY CAT$$$$$$$$$$ *************************************");
            foreach (var cat in cats)
            {
                Console.WriteLine($"Hello, my name is {cat.Name}.");
                Console.WriteLine($"Endoskelenton: {cat.Endoskeleton}");
                Console.WriteLine($"Brain: {cat.Brain}");
                Console.WriteLine($"Avg. Life Span in Years: {cat.AvgLifeSpanInYears}");
                Console.WriteLine($"Ear type: {cat.Ears}");
                Console.WriteLine($"Cuteness: {cat.Cuteness}");
                Console.WriteLine($"Sleeping Pattern: {cat.Sleeps()}");
                Console.WriteLine($"Activity: {cat.Plays()}");
                Console.WriteLine($"Demeanor: {cat.GetDemeanor()}");
                Console.WriteLine($"Has Hair: {cat.HairOnSkin}");
                Console.WriteLine($"NOTE TO TOURISTS: {cat.ShouldTouristApproach()}");
                Console.WriteLine($"ARE WE EDIBLE: {cat.ShouldWeEatThis()}");
                Console.WriteLine("------------------------------------------------------------------------------------------------------");
            }

            // Question:
            // I can't call mammal.Name because I haven't set a Name property on my mammal class. Is there a way I can change the type of my mammal to be Cat? For example, waffles is technically a ScottishFold : Cat object. Is there a way I can write this:
            // if (mammal is Cat) Console.WriteLine((Cat)mammal.Name);

            var rodents = new List<Rodent> { minnie, rat };

            Console.WriteLine("**************************************** Rodents *************************************************");
            foreach (var rodent in rodents)
            {
                Console.WriteLine($"Endoskelenton: {rodent.Endoskeleton}");
                Console.WriteLine($"Brain: {rodent.Brain}");
                Console.WriteLine($"Avg. Life Span in Years: {rodent.AvgLifeSpanInYears}.");
                Console.WriteLine($"Diseased: {rodent.Diseased}");
                Console.WriteLine($"Sound: {rodent.MakeSound()}");
                Console.WriteLine($"Has Hair: {rodent.HairOnSkin}");
                Console.WriteLine($"Blood Temperature: {rodent.BloodTemperature()}");
                Console.WriteLine($"ARE WE EDIBLE: {rodent.ShouldWeEatThis()}");
                Console.WriteLine($"GROWS UNTIL: {rodent.GrowsUntil()}");
                Console.WriteLine("------------------------------------------------------------------------------------------------------");
            }

            var turtles = new List<Turtle> { softie, wen };

            Console.WriteLine("**************************************** TURTLE$ *************************************************");
            foreach (var turtle in turtles)
            {
                Console.WriteLine($"Endoskelenton: {turtle.VertebrateGretting()}");
                Console.WriteLine($"Brain: {turtle.Brain}");
                Console.WriteLine($"Moving Speed: {turtle.MovingSpeed}.");
                Console.WriteLine($"Skin Type: {turtle.GetSkinType()}");
                Console.WriteLine($"Blood Temperature: {turtle.BloodTemperature()}");
                Console.WriteLine($"NOTE TO TOURISTS: {turtle.ShouldTouristApproach()}");
                Console.WriteLine($"ARE WE EDIBLE: {turtle.ShouldWeEatThis()}");
                Console.WriteLine($"Fatty Meat: {turtle.FattyMeat}");
                Console.WriteLine("------------------------------------------------------------------------------------------------------");
            }


            //Console.WriteLine($"Traits of this {waffles.GetType()}:" + Environment.NewLine + $"{waffles.Cuteness}");
            //Console.WriteLine(waffles.Moves());
            Console.WriteLine(waffles.ShouldTouristApproach());
            Console.WriteLine(waffles.ShouldWeEatThis());

            //Console.WriteLine(softie.MovingSpeed);
            //Console.WriteLine(softie.Endoskeleton);
            //Console.WriteLine(softie.Brain);
            // hopefully, this has been overriden
            // Turtle.MovingSpeed == "slow"
            // softie.MovingSpeed == "Faster than other land turtles"
        }
    }
}