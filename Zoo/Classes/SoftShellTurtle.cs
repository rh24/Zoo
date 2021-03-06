﻿using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public class SoftShellTurtle : Turtle
    {
        public string Name { get; set; }
        public override string MovingSpeed { get => "Faster than other land turtles"; }
        public int DeliciouRating { get; set; } = 5;

        public override string LikesCats()
        {
            return "Isn't fond of cats because they have dangerous nails. We're soft shelled.";
        }

        public SoftShellTurtle(string name)
        {
            Name = name;
        }
    }
}
