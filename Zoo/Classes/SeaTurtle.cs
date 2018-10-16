using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class SeaTurtle : Turtle
    {
        public string Name { get; set; }

        // test for inheritance of the Slow property from Turtle
        public string Moves()
        {
            return $"Turtles are known to be {base.MovingSpeed}, but sea turtles swim fast.";
        }

        public override string LikesCats()
        {
            return "Loves cats!!";
        }

        public SeaTurtle(string name)
        {
            Name = name;
        }
    }
}
