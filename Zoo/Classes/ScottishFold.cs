using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class ScottishFold : Cat
    {
        public string Cuteness { get; } = "Overload";
        public override bool Limber { get => false; }
        public string Name { get; set; }
        public override string Energy { get; set; } = "Lazy";

        public ScottishFold()
        {
        }
    }
}
