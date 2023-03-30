using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guns
{
    class Glock : Guns
    {
        public Glock(string name, int base_ammo, int ammount_mag, string img ) : base(name, base_ammo, ammount_mag,img)
        { }
    }
}
