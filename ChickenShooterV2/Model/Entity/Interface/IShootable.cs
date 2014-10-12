using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickenShooterV2
{
    public interface IShootable
    {
        Boolean IsAlive { get; set; }
        Boolean isHit(double x, double y);
    }
}
