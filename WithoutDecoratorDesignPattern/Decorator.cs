using System;

namespace DecoratorDesignPattern
{
    class Decorator : DesignPattern
    {
        private readonly Length mm = Length.Millimeter;
        protected override void Implementation()
        {
            Console.WriteLine("Decorator");
            Book book = new Book("Software Engineering", new Size(188 * mm, 239 * mm, 28 * mm));
            Buyer customer = new Buyer();
            customer.Handle(book);

            Dispatcher employee = new Dispatcher();
            employee.Handle(book);
            Console.ReadLine();
        }
    }
}
