using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2_Eddi
{
    public abstract class Weapon : IWeapon
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public double VAtack { get; set; }
        public double Price { get; set; }

        public Weapon(string name, int damage, double Vatack, double price)
        {
            Name = name;
            Damage = damage;
            VAtack = Vatack;
            Price = price;
        }

        public abstract double CalculateDPS();
    }

}
