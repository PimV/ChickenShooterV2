﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ChickenShooterV2
{
    public class GameController : BaseController
    {
        public GameController(GameWindow gameWindow, GameState gameState)
            : base(gameWindow, gameState)
        {
        }

        public override void addListeners()
        {
            this.GameWindow.GameCanvas.MouseDown += new MouseButtonEventHandler(MouseDownEvent);
            this.GameWindow.KeyDown += new KeyEventHandler(KeyDownEvent);
        }

        public override void clearListeners()
        {
            this.GameWindow.GameCanvas.MouseDown -= MouseDownEvent;
            this.GameWindow.KeyDown -= KeyDownEvent;
        }

        public void MouseDownEvent(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                Point p = Mouse.GetPosition(this.GameWindow.GameCanvas);
                this.GameState.ActionContainer.Enqueue(new ShootAction(this.GameState, p.X, p.Y));
            }

            if (e.ChangedButton == MouseButton.Right)
            {
            }

        }

        public void KeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.P)
            {
                Console.WriteLine(" PRESSING P ");
                this.GameState.ActionContainer.Enqueue(new PauseAction(this.GameState));
            }
        }
    }
}
