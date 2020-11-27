using System;
using System.Collections.Generic;
using System.Text;

namespace Giliberto.TestLINQ
{

    /*
     * 
     * 8.	Realizzare una classe Person ha le proprietà firstName e LastName. 
     * Scrivere una query in query syntax E in method syntax, in cui si recupera da una lista (IEnumerable<Person>) 
     * le persone il cui firstName è “Anna” o “Fabrizio”.
     * 
     */
    public class Person
    {
        public string firstName { get; set; }

        public string lastName { get; set; }

    }
}
