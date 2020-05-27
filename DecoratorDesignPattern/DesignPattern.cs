using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern
{
    abstract class DesignPattern
    {
        protected abstract void Implementation();
        public void Run()
        {
            this.Implementation();
        }
    }
}
