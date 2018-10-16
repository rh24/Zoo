using System;
using Zoo.Classes;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            ScottishFold waffles = new ScottishFold("Waffles");
            Console.WriteLine($"Traits of this {waffles.GetType()}:" + Environment.NewLine + $"{waffles.Cuteness}");
            Console.WriteLine(waffles.Moves());

            SoftShellTurtle softie = new SoftShellTurtle("Softie");
            Console.WriteLine(softie.MovingSpeed);
            // hopefully, this has been overriden
            // Turtle.MovingSpeed == "slow"
            // softie.MovingSpeed == "Faster than other land turtles"
        }
    }
}