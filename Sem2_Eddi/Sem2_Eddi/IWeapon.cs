using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2_Eddi
{
    interface IWeapon
    {
        string Name { get; set; }
        int Damage { get; set; }
        double VAtack { get; set; }
        double Price { get; set; }

        double CalculateDPS();
    }
}
