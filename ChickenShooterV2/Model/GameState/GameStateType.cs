using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickenShooterV2
{
    public enum GameStateType
    {
        [GameStateInfoAttribute(typeof(Level1State))]
        level1,
        [GameStateInfoAttribute(typeof(Level2State))]
        level2,
        [GameStateInfoAttribute(typeof(FinishedState))]
        finished,
        [GameStateInfoAttribute(typeof(PausedState))]
        pause
    }
}
