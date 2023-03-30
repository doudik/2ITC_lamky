using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guns
{
    class Guns
    {
        public string name;
        public int base_ammo;
        public int ammo_left;
        public int ammount_mag;
        public string img;


        public Guns(string name, int base_ammo, int ammount_mag, string img)
        {
            this.name = name;
            this.base_ammo = base_ammo;
            this.ammount_mag = ammount_mag;
            this.img = img;
            this.ammo_left = base_ammo;
        }
        public void shoot()
        {
            if (this.ammo_left > 0)
            {
                this.ammo_left--;
            }

        }
        public void reload()
        {
            if (this.ammount_mag > 0)
            {
                this.ammount_mag--;
                this.ammo_left = base_ammo;
            }

        }
    }
}
