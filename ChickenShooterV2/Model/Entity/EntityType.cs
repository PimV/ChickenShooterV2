using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickenShooterV2
{
    public enum EntityType
    {
        [EntityInfoAttribute(typeof(Chicken))]
        Chicken,
        [EntityInfoAttribute(typeof(Balloon))]
        Balloon,
        [EntityInfoAttribute(typeof(Bullet))]
        Bullet,
    }
}
