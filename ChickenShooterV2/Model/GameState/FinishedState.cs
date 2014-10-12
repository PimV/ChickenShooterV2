using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickenShooterV2
{
    public class FinishedState : GameState
    {
        public GameStateManager GSM { get; set; }
        public MainContainer MainContainer { get; set; }
        public ActionContainer ActionContainer { get; set; }
        public GameOverController GameOverController { get; set; }

        public void init(GameStateManager gsm)
        {
            this.GSM = gsm;

            this.ActionContainer = new ActionContainer();

            this.MainContainer = new MainContainer();

            this.GameOverController = new GameOverController(this.GSM.GameWindow, this);
            this.GameOverController.addListeners();
        }

        public void cleanup()
        {
            this.GameOverController.clearListeners();
        }

        public void handleInput()
        {
            ControllerAction action;
            lock (this.ActionContainer)
            {
                while (this.ActionContainer.Count > 0)
                {
                    this.ActionContainer.TryDequeue(out action);
                    if (action == null)
                    {
                        continue;
                    }
                    action.execute();
                }
            }
        }

        public void update(double dt)
        {
            //throw new NotImplementedException();
        }

        public void draw()
        {
            this.GSM.GameCanvas.drawStatusLabel("Game Finished! Press P to start over!");
        }


        public void pause()
        {
            this.GameOverController.clearListeners();
        }

        public void resume()
        {
            this.GameOverController.addListeners();
        }
    }
}
