using System;
using System.Collections;

namespace Zoo.Classes
{
    public abstract class Vertebrata : IEnumerable
    {
        public abstract string Endoskeleton { get; set; }
        public abstract string Brain { get; set; }

        public string VertebrateGretting()
        {
            return "I have a spine!";
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}