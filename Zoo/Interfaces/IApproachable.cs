using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Interfaces
{
    interface IApproachable
    {
        bool ReceivedShots { get; set; }
        bool WillBite { get; set; }
        bool MightCharge { get; set; }
        bool LikesAttention { get; set; }

        string Approach();
    }
}
