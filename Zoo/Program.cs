using System;
using Zoo.Classes;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            ScottishFold waffles = new ScottishFold();
            Console.WriteLine($"Traits of this {waffles.GetType()}:" + Environment.NewLine + $"{waffles.Cuteness}");
            Console.WriteLine(waffles.Moves());
        }
    }
}