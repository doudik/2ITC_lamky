using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guns
{
    class Mp5 : Guns
    {
        public Mp5 (string name, int base_ammo, int ammount_mag, string img) : base(name, base_ammo, ammount_mag,img)
        {
        }
    }
}
