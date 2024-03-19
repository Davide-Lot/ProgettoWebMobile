
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;

namespace ProgettoWebMobile.Modelli
{
    public class Transazione
    {
        public int IDTransazione { get; set; }
        public DateTime DataTransazione { get; set; }
        public Enum MetodoPagamento { get; set; }
        public Enum StatoTransazione { get; set; }
        public decimal Importo { get; set; }
        public string CodiceTracciamento { get; set; }

        public Transazione() { }
        public Transazione(int idTransazione, DateTime dataTransazione, Enum metodoPagamento, Enum statoTransazione, decimal importo, string codiceTracciamento)
        {
            IDTransazione = idTransazione;
            DataTransazione = dataTransazione;
            MetodoPagamento = metodoPagamento;
            StatoTransazione = statoTransazione;
            Importo = importo;
            CodiceTracciamento = codiceTracciamento;
        }
    }
}