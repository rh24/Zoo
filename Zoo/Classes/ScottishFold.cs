using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public class ScottishFold : Cat, IApproachable
    {
        public override string Cuteness { get; set; } = "Overload";
        public override bool Limber { get => false; }
        public override string Name { get; set; }
        public override string Ears { get => "Folded ears"; }
        public override bool MarvelousHearing { get; set; } = false;

        public ScottishFold(string name) : base(name)
        {
            Name = name;
        }

        public override string Sleeps()
        {
            return "But this cat sleeps at night with its hooman.";
        }

        public override string Moves()
        {
            return $"{base.Moves()} However, this cat has a hereditary cartilage disease that makes moving painful.";
        }

        // test to prove inheritance => "Lazy, affectionate, and, sometimes, playful."
        public override string GetDemeanor()
        {
            return $"Lazy, affectionate, and, sometimes, {base.GetDemeanor().ToLower()}.";
        }
    }
}
