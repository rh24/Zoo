using System;
using Zoo.Classes;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate objects from concrete classes
            ScottishFold waffles = new ScottishFold("Waffles");
            SoftShellTurtle softie = new SoftShellTurtle("Softie");
            Mouse minnie = new Mouse("Minnie");
            Sphynx cleo = new Sphynx("Cleopatra");
            Rat rat = new Rat("PizzaRat");
            MaineCoon simba = new MaineCoon("Simba");
            SeaTurtle wen = new SeaTurtle("Wen");

            // Display properties and behaviors

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