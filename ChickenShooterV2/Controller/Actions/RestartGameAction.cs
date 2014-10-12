using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickenShooterV2
{
    public class RestartGameAction : ControllerAction
    {
        public RestartGameAction(GameState gameState)
        {
            this.GameState = gameState;
        }

        public override void execute()
        {
            this.GameState.GSM.changeGameState(GameStateFactory.createGameState(GameStateType.level1));
        }
    }
}
