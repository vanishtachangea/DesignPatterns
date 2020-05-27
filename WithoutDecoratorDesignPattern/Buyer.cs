using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern
{
    class Buyer
    {
        public void Handle(Book product)
        {
            Size bookSize = product.Dimensions;
            Console.WriteLine($"Buying book \"{product.Title}\" of size {bookSize}");
        }
    }
}
