using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_31_24
{
    internal interface IAMonterFactory
    {
        FlyMonster CreateFlyMonster();
        RideMonster CreateRideMonster();
        WaldMonster CreateWaldMonster();
    }
}
