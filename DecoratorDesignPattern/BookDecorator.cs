using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern
{
    public class BookDecorator : IBook
    {
        private IBook Target { get; }
        public virtual string Title => this.Target.Title; //virtual so that subclasses can implement/override it

        public BookDecorator(IBook other)
        {
            this.Target = other;
        }
        public virtual Size GetDimensions(Size propaganda) =>
            this.Target.GetDimensions(propaganda);
    }

    public class TwoPack : BookDecorator
    {
        public TwoPack(IBook other): base(other)
        {}
        public override Size GetDimensions(Size propaganda)=>
            base.GetDimensions(Size.Zero).ScaleHeight(2).AddToTop(propaganda);

    }
    
}
