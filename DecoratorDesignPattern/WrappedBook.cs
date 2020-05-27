using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern
{
    //class WrappedBook: IBook
    //{

    //    private IBook Target { get; }
    //    public string Title => this.Target.Title;
    //    public WrappedBook(IBook other)
    //    {
    //        this.Target = other;
    //    }
    //    public Size GetDimensions(Size propaganda)
    //    {
    //        return this.Target.GetDimensions(propaganda)
    //        .Add(new Size(7 * Length.Millimeter, 7 * Length.Millimeter, 7 * Length.Millimeter));
    //    }
    //}
    public class WrappedBook : BookDecorator
    {
        public WrappedBook(IBook other): base(other) { }

        public override Size GetDimensions(Size propaganda)
        {
            return base.GetDimensions(propaganda)
            .Add(new Size(7 * Length.Millimeter, 7 * Length.Millimeter, 7 * Length.Millimeter));
        }
    }
}
