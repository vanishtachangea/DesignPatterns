using System;
using System.Collections.Generic;
using System.Text;

namespace GangOfFour
{
    public interface ITax 
    {
        void Calculate();
    }
    public class Tax1 : ITax
    {
        public void Calculate()
        {
            Console.WriteLine("Tax 1");
        }
    }
    public class NewTax: ITax
    {
        public void Calculate()
        {
            Console.WriteLine("Tax 2 - New Tax");
        }
    }
    public class SimpleFactory
    {
        public static ITax Create(int typeTax)
        {
            //use collection
            switch  (typeTax)
            {
                case 1:
                    return new Tax1();
                
                default:
                    return new NewTax();

            }
        }
    }
}
