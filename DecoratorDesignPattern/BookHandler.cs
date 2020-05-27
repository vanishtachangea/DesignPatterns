using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern
{
    class BookHandler
    {
        /// <summary>
        /// Before Adding Decorator as SubClass
        /// </summary>
        /// <param name="book"></param>
        //public void Handle(Book book)
        //{
        //    Size originalSize = book.Dimensions;
        //    Size packagedSize = originalSize.Add(new Size(7 * Length.Millimeter, 7 * Length.Millimeter, 7 * Length.Millimeter));
        //    Console.WriteLine($"Dealing with book \"{book.Title}\" of size {packagedSize}");
        //}

        
        ////Adding SubClass decorator
/*        public void Handle(Book book)
        {
            Size size = book.Dimensions;
            Console.WriteLine($"Dealing with book \"{book.Title}\" of size {size}");
        }*/

        public void Handle(IBook book)
        {
            Size slimCdCase = new Size(142 * Length.Millimeter, 125 * Length.Millimeter, 5 * Length.Millimeter);
            Size size = book.GetDimensions(slimCdCase);
            Console.WriteLine($"Dealing with book \"{book.Title}\" of size {size}");
        }
    }
}
