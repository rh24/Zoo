using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Cat : Mammal
    {
        protected abstract bool Limber { get; set; }
        protected virtual bool MarvelousHearing { get; set; }
        protected virtual string Ears { get; set; }

        protected virtual string Sleeps()
        {
            return "Cats usually sleep during the day. They are nocturnal.";
        }

        protected virtual string Plays()
        {
            return "Likes to play in boxes.";
        }

        protected virtual string Moves()
        {
            return "They are graceful animals. They move like ballerinas.";
        }

        public Cat()
        {
        }
    }
}
