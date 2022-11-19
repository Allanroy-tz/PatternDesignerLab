﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Iterator_Factory_Pattern
{
    public abstract class TVController
    {
        public abstract void NextChannel();

        public abstract void PreviousChannel();

        public abstract void OpenTV();

        public abstract void CloseTV();
        public abstract void SetTV(ITelevision tv);
    }
}