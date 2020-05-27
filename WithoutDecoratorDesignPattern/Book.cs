using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern
{
    class Book
    {
        public string Title { get; }
        public Size Dimensions { get; }
        public Book(string title, Size dimensions)
        {
            this.Title = title;
            this.Dimensions = dimensions;
        }
        public override string ToString() => $"{this.Title} - {this.Dimensions}";

    }
}
