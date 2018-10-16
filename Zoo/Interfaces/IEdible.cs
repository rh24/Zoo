using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Interfaces
{
    public interface IEdible
    {
        bool Diseased { get; set; }
        int DeliciousRating { get; set; }
        bool FattyMeat { get; set; }

        string ShouldWeEatThis();
    }
}
