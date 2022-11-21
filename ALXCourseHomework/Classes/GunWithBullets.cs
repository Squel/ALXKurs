using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCourseHomework
{
    internal class GunWithBullets
    {
        public Guns Gun { get; private set; }
        public int NoOfBullets { get; private set; }
        public GunWithBullets(Guns gun, int bullets) {
        Gun= gun;
            NoOfBullets= bullets;
        }

        public decimal GetPrice()
        {
            return Gun.BulletPrice * NoOfBullets;
        }
    }
}
