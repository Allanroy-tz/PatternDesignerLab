using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_3
{
    public abstract  class Tz0718State
    {
        protected Tz0718Player player;
        public abstract void Pause();
        public abstract void Hurt();
        public abstract void Attack();
        public abstract void Move();
        public abstract void Start();

    }
}
