using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickenShooterV2
{
    public abstract class EntityContainer : List<Entity>
    {

        public abstract void update(double dt);

    }
}
