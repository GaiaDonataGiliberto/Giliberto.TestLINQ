using System;
using System.Collections.Generic;
using System.Text;

namespace Giliberto.TestLINQ
{
    static class PersonaExtension
    {
        /* Scrivere un extension method della classe Persona(VeicoloPosseduti(List<Veicolo> elencoVeicoli) ) 
                 * che restituisca l’elenco dei veicoli posseduti(campi: ID, Targa, Prezzo)
                 */

        public static string VeicoliPosseduti(this Persona prop, List<Veicolo> elencoVeicoli)
        {
            var lista = new List<Veicolo>();

            string ris = "";

            foreach (Veicolo v in elencoVeicoli)
            {
                if (v.IDProprietario == prop.ID)
                {
                    lista.Add(v);
                    ris += $"ID Macchina: {v.ID} - Targa: {v.Targa} - Prezzo: {v.Prezzo} euro\r\n";
                }
            }

            if (lista == null)
            {
                ris = "Questa persona non possiede veicoli";
            }


            return ris;
        }

        
    } 
}

