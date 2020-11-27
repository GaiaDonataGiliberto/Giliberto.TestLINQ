using System;
using System.Collections.Generic;
using System.Text;

namespace Giliberto.TestLINQ
{
    /* Creare una Classe “Veicolo” che abbia come proprietà:
    ID
    Targa
    Peso
    Colore
    Prezzo
    ID Proprietario(ID di una istanza della classe “Persona”)
    */

    public class Veicolo
    {
        public int ID { get; set; }
        public string Targa { get; set; }
        public double Peso { get; set; }
        public string Colore { get; set; }
        public double Prezzo { get; set; }
        public int IDProprietario { get; set; }

    }
}
