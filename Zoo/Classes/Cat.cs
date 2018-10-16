using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Cat : Mammal
    {
        public virtual bool Limber { get; } = true;
        public virtual bool MarvelousHearing { get; set; } = true;
        public virtual string Ears { get; set; } = "Straight";
        public abstract string Energy { get; set; }

        public virtual string Sleeps()
        {
            return "Cats usually sleep during the day. They are nocturnal.";
        }

        public virtual string Plays()
        {
            return "Likes to play in boxes.";
        }

        public virtual string Moves()
        {
            return "Normally, cats are graceful animals. They move like ballerinas.";
        }

        public Cat()
        {
        }
    }
}
