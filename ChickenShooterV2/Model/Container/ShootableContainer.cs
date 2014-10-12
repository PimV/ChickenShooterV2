using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickenShooterV2
{
    public class ShootableContainer : EntityContainer
    {
        public override void update(double dt)
        {
            foreach (Entity e in this)
            {
                //e.update(dt);
            }
            //throw new System.NotImplementedException();
        }
    }
}
