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

            // Display properties and behaviors of all objects. Categorize them in two main loops. Concrete animals inheriting from the Cat class, Turtle class, and Rodent Class.
            var cats = new List<Cat> { waffles, cleo, simba };

            Console.WriteLine("********************************** WELCOME TO MY CAT$$$$$$$$$$ *************************************");
            foreach (var cat in cats)
            {
                Console.WriteLine($"Hello, my name is {cat.Name}. I'm a {cat.GetType().Name}.");
                Console.WriteLine($"Endoskeleton: {cat.Endoskeleton}");
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

            var rodents = new List<Rodent> { minnie, rat };

            Console.WriteLine("**************************************** Rodents *************************************************");
            foreach (var rodent in rodents)
            {
                Console.WriteLine($"I'm a {rodent.GetType().Name}.");
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
                // Is there any way I can get the property from this turtle object's derived type SeaTurtle or SoftShellTurtle?
                // Is there any way I can force it to be a derived type at runtime? {turtle.Name} gives me red squigglies because I never gave implemented a name property in the abstract Turtle class. I only did that in derived classes.
                // I know there's a way to extract derived types from a collection with LINQ, but that means generating an entirely new collection of the subtype and iterating over that subtype collection. I'm wondering if there's a type casting we can do to extract a derived type from a base type.
                Console.WriteLine($"I'm a {turtle.GetType().Name}.");
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
        }
    }
}
