using System;

namespace DecoratorDesignPattern
{
    class Decorator : DesignPattern
    {
        private readonly Length mm = Length.Millimeter;
        protected override void Implementation()
        {
            Console.WriteLine("Decorator");
            IBook book = new PrintedBook("Software Engineering", new Size(188 * mm, 239 * mm, 28 * mm));
            IBook product = new TwoPack(book);


            BookHandler buyer = new BookHandler();
            buyer.Handle(book);

            IBook wrappedBook = new WrappedBook(product);
            BookHandler employee = new BookHandler();
            employee.Handle(wrappedBook);
            Console.ReadLine();
        }
    }
}
