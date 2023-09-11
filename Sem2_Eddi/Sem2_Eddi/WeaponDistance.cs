using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2_Eddi
{
    public class WeaponDistance : Weapon
    {
        public IProjectile Projectile { get; set; }

        public WeaponDistance(string name, int damage, double Vatack, double price, IProjectile projectile)
            : base(name, damage, Vatack, price)
        {
            Projectile = projectile;
        }

        public override double CalculateDPS()
        {
            return (Damage + Projectile.getDamageProjectile()) * VAtack;
        }
    }
}
