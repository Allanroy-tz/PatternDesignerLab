using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Iterator_Factory_Pattern
{
    public interface ICommand
    {
        void Set(Object ob);
        void Execute();
    }
}