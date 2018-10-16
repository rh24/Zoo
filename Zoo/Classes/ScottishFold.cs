using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public class ScottishFold : Cat, IApproachable
    {
        // Propeties from pt.1 of OOP Zoo lab
        public override string Cuteness { get; set; } = "Overload";
        public override bool Limber { get => false; }
        public override string Name { get; set; }
        public override string Ears { get => "Folded ears"; }
        public override bool MarvelousHearing { get; set; } = false;

        // Methods from pt.1
        public ScottishFold(string name) : base(name)
        {
            Name = name;
        }
        public override string Sleeps() => "But this cat sleeps at night with its hooman.";

        public override string Moves() => $"{base.Moves()} However, this cat has a hereditary cartilage disease that makes moving painful.";

        public override string GetDemeanor() => $"Lazy, affectionate, and, sometimes, {base.GetDemeanor().ToLower()}.";
    }
}
