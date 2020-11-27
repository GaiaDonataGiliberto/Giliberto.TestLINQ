using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Giliberto.TestLINQ
{
    class Esercizio
    {
        static IEnumerable<Person> personList = new List<Person>
            {
                new Person {firstName = "Giulio", lastName = "Cesare"},
                new Person {firstName = "Anna", lastName = "Maria"},
                new Person {firstName = "Marco", lastName = "Aurelio"},
                new Person {firstName = "Fabrizio", lastName = "Gallo"},
                new Person {firstName = "Samantha", lastName = "Cristoforetti"},
                new Person {firstName = "Anna", lastName = "Bolena"}
            };

        

        static IEnumerable<Persona> personaList = new List<Persona>
        { 
            new Persona {ID = 1, Nome = "Plinio", Cognome = "il Vecchio", Nazione = "Italia"},
            new Persona {ID = 2, Nome = "Plinio", Cognome = "il Giovane", Nazione = "Italia"},
            new Persona {ID = 3, Nome = "Luigi", Cognome = "Sedicesimo", Nazione = "Francia"},
            new Persona {ID = 4, Nome = "Martin", Cognome = "Lutero", Nazione = "Germania"},
            new Persona {ID = 5, Nome = "Gregori", Cognome = "Rasputin", Nazione = "Russia"},
            new Persona {ID = 6, Nome = "Samantha", Cognome = "Cristoforetti", Nazione = "Italia"}
        };

        static IEnumerable<Veicolo> veicoloList = new List<Veicolo>
        {
            new Veicolo {ID = 1, Targa = "AA345LH", Peso = 550.67, Colore = "Nero", Prezzo = 3000, IDProprietario = 1},
            new Veicolo {ID = 2, Targa = "FG930OP", Peso = 800.34, Colore = "Blu", Prezzo = 24400, IDProprietario = 3},
            new Veicolo {ID = 3, Targa = "GR987FN", Peso = 670.00, Colore = "Bianco", Prezzo = 120000, IDProprietario = 3},
            new Veicolo {ID = 4, Targa = "CR876AS", Peso = 403, Colore = "Grigio", Prezzo = 5400, IDProprietario = 5},
            new Veicolo {ID = 5, Targa = "BR130JK", Peso = 750.80, Colore = "Grigio", Prezzo = 10300, IDProprietario = 6},
            new Veicolo {ID = 6, Targa = "DE673NM", Peso = 560, Colore = "Nero", Prezzo = 6000, IDProprietario = 4}
        };

        

        /*
        * 8. Realizzare una classe Person ha le proprietà firstName e LastName. 
        * Scrivere una query in query syntax E in method syntax, in cui si recupera da una lista (IEnumerable<Person>) 
        * le persone il cui firstName è “Anna” o “Fabrizio”.
        */
        #region Esercizio 8
        public static void PersonByName()
        {
            // query syntax

            Console.WriteLine("===query syntax===");
            var filtredList =
                 from p in personList
                 where p.firstName == "Anna" || p.firstName == "Fabrizio"
                 select p;

            foreach (var p in filtredList)
            {
                Console.WriteLine($"Nome: {p.firstName} - Cognome: {p.lastName}");
            }

            // method syntax
            Console.WriteLine("===method syntax===");

            var filtredList2 = personList
            .Where(p => p.firstName == "Anna" || p.firstName == "Fabrizio")
            .Select(p => p);

            foreach (var p in filtredList2)
            {
                Console.WriteLine($"Nome: {p.firstName} - Cognome: {p.lastName}");
            }

        }
        #endregion

        /*
        * 10.Creare una Classe “Persona” che abbia come proprietà:
        ID
        Nome
        Cognome
        Nazione

        * Creare una Classe “Veicolo” che abbia come proprietà:
        ID
        Targa
        Peso
        Colore
        Prezzo
        ID Proprietario(ID di una istanza della classe “Persona”)

        - Popolare le due liste con dati di test
        - Scrivere una query LINQ che conti il numero di macchine per colore
        - Scrivere una query LINQ che restituisca Peso complessivo e Prezzo Medio dei Veicoli posseduti da ciascuna Persona
        - Scrivere un extension method della classe Persona(VeicoliPosseduti(List<Veicoli> elencoVeicoli) ) che restituisca l’elenco dei veicoli posseduti(campi: ID, Targa, Prezzo)
        */

        #region Esercizio 10

        // === veicoli per colore === 
        public static void VeicoliPerColore()
        {

            var filtredList = veicoloList
                .GroupBy(v => v.Colore)
                .Select(v => new { Numero = v.Count(), Colore = v.Key});

            Console.WriteLine("Veicoli per colore:");

            foreach (var v in filtredList)
            {
                Console.WriteLine($"Colore: {v.Colore} - Qnt: {v.Numero}");
            }

        
        }

        // === peso e prezzo medio ===

        public static void PesoPrezzoMedioPerProp()
        {


            var filtredList =
                from v in veicoloList
                group v by v.IDProprietario
                into gr
                select new
                {
                    IDProp = gr.Key,
                    PrezzoAvg = gr.Average(v => v.Prezzo),
                    PesoTot = gr.Sum(v => v.Peso)
                }
                into gr1
                join p in personaList
                on gr1.IDProp equals p.ID
                select new
                {
                    p.Nome,
                    p.Cognome,
                    gr1.PrezzoAvg,
                    gr1.PesoTot

                };
               

            Console.WriteLine("Peso totale e prezzo medio veicoli per proprietario");

            foreach (var v in filtredList)
            {
                Console.WriteLine($"Proprietario: {v.Nome} {v.Cognome}  - Peso totale: {v.PesoTot} kg - Prezzo medio: {v.PrezzoAvg} euro");
            }

        }

        #endregion

    }
}
