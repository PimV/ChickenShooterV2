using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickenShooterV2
{
    public abstract class BaseController
    {
        public GameWindow GameWindow { get; set; }
        public GameState GameState { get; set; }

        public BaseController(GameWindow gameWindow, GameState gameState)
        {
            this.GameWindow = gameWindow;
            this.GameState = gameState;
        }

        public abstract void clearListeners();
        public abstract void addListeners();

    }
}
