using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class Mouse : Rodent
    {
        public string Name { get; set; }
        // Why do I get a property must override all accessors if I don't use an expression bodied member to define the property?
        // { get; } = 2; results in error
        // { get => base.AvgLifeSpanInYear - 3; } does not
        public override int AvgLifeSpanInYears { get => base.AvgLifeSpanInYears - 3; }

        public string Eats()
        {
            return "Mice like cheese";
        }

        public Mouse(string name)
        {
            Name = name;
        }
    }
}
