using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class MaineCoon : Cat
    {
        public override string Name { get; set; }
        public override int AvgLifeSpanInYears { get; set; } = 12;
        public override string Cuteness { get; set; } = "Pretty Cute";

        // Why would I ever want to require things in base class constructors insetad of just requiring them in my derived class if my base class is abstract anyway? i.e. If I can't instatiate an object from the Cat class, is it silly to even have a constructor there?
        public MaineCoon(string name) : base(name)
        {
            Name = name;
        }
    }
}
