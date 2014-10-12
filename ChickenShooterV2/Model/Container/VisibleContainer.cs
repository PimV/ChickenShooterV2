using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickenShooterV2
{
    public class VisibleContainer : EntityContainer
    {
        public override void update(double dt)
        {
            foreach (Entity e in this)
            {
                e.update(dt);
            }
        }
    }
}
