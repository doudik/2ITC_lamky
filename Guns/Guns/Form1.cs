using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guns
{
    public partial class Form1 : Form
    {
        int index;
        string img;
        Ak47 ak47 = new Ak47("AK47", 30, 5, "ak47.JFIF");
        Mp5 mp5 = new Mp5("MP5", 35, 2, "MP5.JFIF");
        Glock glock = new Glock("Glock", 10, 3, "Glock.JFIF");
        List<Guns> gunlist = new List<Guns>();
        
       
        public Form1()
        {
            InitializeComponent();
            gunlist.Add(ak47);
            gunlist.Add(mp5);
            gunlist.Add(glock);
            
        }

        private void firebtn_Click(object sender, EventArgs e)
        {
            gunlist[index].shoot();
            
            ammoText.Text = "Ammo left: " + gunlist[index].ammo_left;
            
        }

        private void gunBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gunBox.SelectedIndex == gunBox.FindStringExact("AK47"))
            {
                index = 0;
            }
            else if(gunBox.SelectedIndex == gunBox.FindStringExact("MP5"))
            {
                index = 1;
            }
            else if (gunBox.SelectedIndex == gunBox.FindStringExact("Glock"))
            {
                index = 2;
            }
            ammoText.Text = "Ammo left: " + gunlist[index].ammo_left;
            magText.Text = "Mags left: " + gunlist[index].ammount_mag;
            gunImg.Load(gunlist[index].img);

        }



        private void reloadbtn_Click(object sender, EventArgs e)
        {
            gunlist[index].reload();
            magText.Text = "Mags left: " + gunlist[index].ammount_mag;
            ammoText.Text = "Ammo left: " + gunlist[index].ammo_left;


        }
    }
}
