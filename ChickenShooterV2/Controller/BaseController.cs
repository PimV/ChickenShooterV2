﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

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

        public void cleanup()
        {
            this.clearListeners();
            this.GameWindow.KeyDown -= cheats;
        }

        public void init()
        {
            this.addListeners();
            this.GameWindow.KeyDown += new KeyEventHandler(cheats);
        }

        public abstract void clearListeners();
        public abstract void addListeners();

        public void cheats(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.D1:
                    this.GameState.GSM.changeGameState(GameStateFactory.createGameState(GameStateType.level1));
                    break;
                case Key.D2:
                    this.GameState.GSM.changeGameState(GameStateFactory.createGameState(GameStateType.level2));
                    break;
                case Key.D3:
                    this.GameState.GSM.changeGameState(GameStateFactory.createGameState(GameStateType.finished));
                    break;
            }
        }

    }
}
