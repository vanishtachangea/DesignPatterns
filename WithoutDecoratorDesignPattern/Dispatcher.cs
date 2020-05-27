using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern
{
    class Dispatcher
    {
        public void Handle(Book book)
        {
            Size originalSize = book.Dimensions;
            Size packagedSize = originalSize.Add(new Size(7 * Length.Millimeter, 7 * Length.Millimeter, 7 * Length.Millimeter));
            Console.WriteLine($"Dispatching book \"{book.Title}\" of size {packagedSize}");
        }
    }
}
