using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern
{
    public class TwoPackOld : IBook
    {
        private IBook Target { get; }
        public string Title => this.Target.Title;

        public TwoPackOld(IBook other)
        {
            this.Target = other;
        }
        public Size GetDimensions(Size propaganda) =>
            this.Target.GetDimensions(Size.Zero).ScaleHeight(2).AddToTop(propaganda);
    }
}
