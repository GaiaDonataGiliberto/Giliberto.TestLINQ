using System;
using System.Collections.Generic;
using System.Text;

namespace Giliberto.TestLINQ
{
    /*
    Creare una Classe “Persona” che abbia come proprietà:
    ID
    Nome
    Cognome
    Nazione
    */
    public  class Persona
    {
        public int ID { get; set; }

        public string Nome { get; set; }

        public string Cognome { get; set; }

        public string Nazione { get; set; }

        /* Scrivere un extension method della classe Persona(VeicoliPosseduti(List<Veicoli> elencoVeicoli) ) 
         * che restituisca l’elenco dei veicoli posseduti(campi: ID, Targa, Prezzo)
         */

        //public static String VeicoliPosseduti(this Persona value, List<Veicolo> elencoVeicoli)
        //{
        //    var lista = new List<Veicolo>();

        //    string ris = "";

        //    foreach (Veicolo v in elencoVeicoli)
        //    {
        //        if (v.IDProprietario == value.ID)
        //        {
        //            lista.Add(v);
        //        }
        //    }


        //    if (lista == null)
        //    {
        //        ris = "Questa persona non possiede veicoli.";
        //    }
        //    else
        //    {
        //        ris = lista.ToString();
        //    }


        //    return ris;
        //}

    }
}
