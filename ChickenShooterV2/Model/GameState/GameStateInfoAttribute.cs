﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickenShooterV2
{
    public class GameStateInfoAttribute : Attribute
    {
        private Type type;

        public GameStateInfoAttribute(Type type)
        {
            this.type = type;
        }

        public Type Type { get { return this.type; } }
    }
}
