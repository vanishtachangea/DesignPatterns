using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern
{
    public interface IBook
    {
        public string Title { get; }
        public Size GetDimensions(Size propaganda);
    }
    public class PrintedBook : IBook
    {
        public string Title { get; }
        private  Size Dimensions { get; }
       
        public PrintedBook(string title, Size dimensions)
        {
            this.Title = title;
            this.Dimensions = dimensions;
        }

        public  Size GetDimensions(Size propaganda) =>
            this.Dimensions.AddToTop(propaganda);
        public override string ToString() => $"{this.Title} - {this.Dimensions}";
    }
}
