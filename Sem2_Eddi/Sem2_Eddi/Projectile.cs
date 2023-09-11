using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2_Eddi
{
    public class Projectile : IProjectile
    {
        public int DamageProjectile { get; set; }

        public Projectile(int DmgProjectile)
        {
            DamageProjectile = DmgProjectile;
        }

        public int getDamageProjectile()
        {
            return DamageProjectile;
        }
    }
}
