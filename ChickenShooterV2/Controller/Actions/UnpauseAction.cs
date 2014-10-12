﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickenShooterV2
{
    public class UnpauseAction : ControllerAction
    {
        public UnpauseAction(GameState gameState)
        {
            this.GameState = gameState;
        }

        public override void execute()
        {
            this.GameState.GSM.popGameState();
        }

    }
}
