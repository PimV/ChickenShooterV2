using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickenShooterV2
{
    public class MovableContainer : EntityContainer
    {
        public override void update(double dt)
        {
            foreach (Entity e in this)
            {
                //moveRandomly(e);
            }
            //throw new System.NotImplementedException();
        }
    }
}
