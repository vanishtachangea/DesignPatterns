using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GangOfFour
{
    public class Country
    {
        public string Name { get; set; }
    }
    public class Report
    {
        //private List<Country> Countries {get;set;}
        private Dictionary<Country,Country> Countries { get; set; }
        public IEnumerable<Country> GetCountries()
        {
            Console.WriteLine("Read from a List");
            if (Countries != null)
                return Countries.Select(x => x.Value);
            else return null;
        }
    }
    class Iterator
    {
    }
}
