﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickenShooterV2
{
    public class Chicken : Entity, IShootable
    {
        private Boolean isAlive = true;
        public Boolean IsAlive { get { return isAlive; } set { isAlive = value; } }
        public int Health { get; set; }

        #region Constructors
        public Chicken()
            : base()
        {
            this.BehaviourList.Add(Behaviour.Movable);
            this.BehaviourList.Add(Behaviour.Shootable);
            this.BehaviourList.Add(Behaviour.Visible);
            this.Height = 50;
            this.Width = 50;
            this.moveSpeed = 5;
            this.dx = this.moveSpeed;
            this.dy = this.moveSpeed;
            this.stdMoveSpeed = moveSpeed;
            this.slowDownActive = false;
            this.determineDirection();
            this.Health = 2;
        }

        public Chicken(double x, double y)
            : base(x, y)
        {
            this.BehaviourList.Add(Behaviour.Movable);
            this.BehaviourList.Add(Behaviour.Shootable);
            this.BehaviourList.Add(Behaviour.Visible);
            this.Height = 50;
            this.Width = 50;
            this.moveSpeed = 5;
            this.dx = this.moveSpeed;
            this.dy = this.moveSpeed;
            this.stdMoveSpeed = moveSpeed;
            this.slowDownActive = false;
            this.determineDirection();
            this.Health = 2;
        }

        public Chicken(double x, double y, double dx, double dy)
            : base(x, y)
        {
            this.BehaviourList.Add(Behaviour.Movable);
            this.BehaviourList.Add(Behaviour.Shootable);
            this.BehaviourList.Add(Behaviour.Visible);
            this.Height = 50;
            this.Width = 50;
            this.dx = dx;
            this.dy = dy;
            this.moveSpeed = 5;
            this.stdMoveSpeed = moveSpeed;
            this.slowDownActive = false;
            this.determineDirection();
            this.IsMovable = true;
            this.IsShootable = true;
            this.IsVisible = true;
            this.Health = 2;
        }
        #endregion

        public override void update(double dt)
        {
            if (isAlive)
            {
                this.deltaTime = dt;
                getNextPosition();
                if (slowDownActive)
                {
                    activateSlowDown();
                }
                if (speedUpActive)
                {
                    activateSpeedUp();
                }
                moveRandomlyDynamic();
            }
        }

        #region Movement


        public void getNextPosition()
        {

            if (movingLeft)
            {
                dx -= moveSpeed * deltaTime;

                if (dx < -moveSpeed)
                {
                    dx = -moveSpeed;
                }
            }
            else if (movingRight)
            {
                dx += moveSpeed * deltaTime;

                if (dx > moveSpeed)
                {
                    dx = moveSpeed;
                }
            }

            if (movingUp)
            {

                dy -= moveSpeed * deltaTime;

                if (dy < -moveSpeed)
                {
                    dy = -moveSpeed;
                }
            }
            else if (movingDown)
            {

                dy += moveSpeed * deltaTime;

                if (dy > moveSpeed)
                {
                    dy = moveSpeed;
                }
            }
        }

        public void moveRandomlyDynamic()
        {
            if (dx > 0)
            {
                if (x + (dx * deltaTime) + width > screen_width)
                {
                    dx = 0;
                    movingLeft = true;
                    movingRight = false;
                }
                else
                {
                    x += dx * deltaTime;
                }
            }
            if (dx < 0)
            {
                if (x + (dx * deltaTime) < 0)
                {
                    dx = 0;
                    movingLeft = false;
                    movingRight = true;
                }
                else
                {
                    x += dx * deltaTime;
                }
            }

            if (dy > 0)
            {
                if (y + (dy * deltaTime) + height > screen_height)
                {
                    dy = 0;
                    movingUp = true;
                    movingDown = false;
                }
                else
                {
                    y += dy * deltaTime;
                }
            }

            if (dy < 0)
            {
                if (y + (dy * deltaTime) < 0)
                {
                    dy = 0;
                    movingUp = false;
                    movingDown = true;
                }
                else
                {
                    y += dy * deltaTime;
                }
            }
        }
        #endregion



        #region Hit Check
        public Boolean isHit(double x, double y)
        {
            if ((x >= X && x < (Width + X)) && (y > Y && y < (Height + Y)))
            {
                Health--;
                if (Health == 0)
                {
                    isAlive = false;
                    return true;
                }
            }
            return false;
        }
        #endregion
    }
}
