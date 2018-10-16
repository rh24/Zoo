using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class ScottishFold : Cat
    {
        public override string Cuteness { get; } = "Overload";
        public override bool Limber { get => false; }
        public string Name { get; set; }
        public override string Energy { get; set; } = "Lazy";
        public override string Ears { get => "Folded ears"; }

        public ScottishFold()
        {
        }

        public override string Sleeps()
        {
            return "But this cat sleeps at night with its hooman.";
        }

        public override string Moves()
        {
            return $"{base.Moves()} However, this cat has a hereditary cartilage disease that makes moving painful.";
        }
    }
}
