﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickenShooterV2
{
    public class EntityInfoAttribute : Attribute
    {
        private Type type;

        public EntityInfoAttribute(Type type)
        {
            this.type = type;
        }

        public Type Type { get { return this.type; } }
    }
}
