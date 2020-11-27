using System;
using System.Linq;
//using System.Collections;

namespace Giliberto.TestLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Esercizio.PersonByName();

            //Esercizio.VeicoliPerColore();

            //Esercizio.PesoPrezzoMedioPerProp();

            Persona p = new Persona { ID = 3, Nome = "Marco", Cognome = "Aurelio", Nazione = "Svizzera" };



            Console.WriteLine(p.VeicoliPosseduti(Esercizio.veicoloList.ToList())); 

            Console.ReadLine();


        }
    }
}
