using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2_Eddi
{
    public class Melee : Weapon
    {
        public Melee(string name, int damage, double VAtack, double price)
            : base(name, damage, VAtack, price)
        {
        }

        public override double CalculateDPS()
        {
            return Damage * VAtack;
        }
    }
}
