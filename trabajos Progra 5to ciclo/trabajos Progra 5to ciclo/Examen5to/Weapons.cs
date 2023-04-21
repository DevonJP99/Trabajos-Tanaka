using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProgra
{
    class Weapon : Items, IshowData
    {
        int damage;

        public Weapon(int damage, string name, string itemtype, int price) : base(name, itemtype, price)
        {
            this.damage = damage;
        }

        public string ShowData()
        {
            return "Damage: " + damage;
        }
    }

}
