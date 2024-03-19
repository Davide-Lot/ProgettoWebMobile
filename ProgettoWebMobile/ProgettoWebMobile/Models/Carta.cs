
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;

namespace ProgettoWebMobile.Modelli
{
    public class Carta
    {
        public int IDCarta { get; set; }
        [MaxLength(16)]
        public int NumeroCarta { get; set; }
        public DateTime DataScadenza { get; set; }
        [MaxLength (3)]
        public int Cvv {  get; set; }
        public string NomeProprietario { get; set; }

        public Carta() { }

        public Carta(int idCarta, int numeroCarta, DateTime dataScadenza, int cvv, string nomeProprietario)
        {
            IDCarta = idCarta;
            NumeroCarta = numeroCarta;
            DataScadenza = dataScadenza;
            Cvv = cvv;
            NomeProprietario = nomeProprietario;
        }
    }
}