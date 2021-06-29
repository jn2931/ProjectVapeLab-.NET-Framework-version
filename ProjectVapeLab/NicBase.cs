using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectVapeLab
{
    class NicBase
    {
        public float volume;
        public int power;
        public void calcVolume(int finalStrength,int finalVolume)
        {
            this.volume = (finalVolume * finalStrength) / this.power;
        }
    }
}
