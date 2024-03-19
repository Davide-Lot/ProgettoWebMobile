using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ProgettoWebMobile.Modelli
{
    public class Prodotto
    {
        public int IDProdotto { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public decimal Prezzo { get; set; }
        public string Categoria { get; set; }
        public string Marchio { get; set; }
        public double Peso { get; set; }
        public double Lunghezza { get; set; }
        public double Larghezza { get; set; }
        public double Altezza { get; set; }
        public DateTime DataCreazione { get; set; }
        public DateTime DataUltimaModifica { get; set; }
        public string Taglia { get; set; }
        public string Colore { get; set; }
        public string Materiale { get; set; }

        public Prodotto(int idProdotto, string nome, string descrizione, decimal prezzo, string categoria, string marchio,
                        double peso, double lunghezza, double larghezza, double altezza, DateTime dataCreazione, 
                        DateTime dataUltimaModifica, string taglia, string colore, string materiale)
        {
            IDProdotto = idProdotto;
            Nome = nome;
            Descrizione = descrizione;
            Prezzo = prezzo;
            Categoria = categoria;
            Marchio = marchio;
            Peso = peso;
            Lunghezza = lunghezza;
            Larghezza = larghezza;
            Altezza = altezza;
            DataCreazione = dataCreazione;
            DataUltimaModifica = dataUltimaModifica;
            Taglia = taglia;
            Colore = colore;
            Materiale = materiale;
        }

    }
}
