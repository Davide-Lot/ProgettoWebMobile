
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ProgettoWebMobile.Modelli
{
    public class Carrello
    {
        public int IDCarrello { get; set; }
        public List<Prodotto> ListaProdotti { get; set; }
        public int QuantitaProdotti { get; set; }
        public decimal PrezzoTotale { get; set; }
        public DateTime DataCreazione { get; set; }
        public DateTime DataUltimaModifica { get; set; }
        public string StatoCarrello { get; set; }

        public Carrello()
        {
            // Inizializzazione delle proprietà
            ListaProdotti = new List<Prodotto>();
            QuantitaProdotti = 0;
            PrezzoTotale = 0;
        }

        // Metodo per calcolare il prezzo totale dei prodotti nel carrello
        // Se la lista dei prodotti è nulla, restituisce 0
        public Decimal CalcoloPrezzoTotale()
        {
            PrezzoTotale = 0; // Azzera il prezzo totale prima di calcolare
            if (ListaProdotti != null)
            {
                foreach (var prodotto in ListaProdotti)
                {
                    PrezzoTotale += prodotto.Prezzo;
                }
            }
            return PrezzoTotale;
        }

        // Metodo per ottenere la quantità totale dei prodotti nel carrello
        // Se la lista dei prodotti è nulla, restituisce 0
        public int QuantitaProdottiTotale()
        {
            if (ListaProdotti != null)
                QuantitaProdotti = ListaProdotti.Count;
            return QuantitaProdotti;
        }

        // Metodo per svuotare il carrello
        public void SvuotaCarrello()
        {
            {
                ListaProdotti.Clear(); 
            }
        }
        public void AggiungiProdotto(Prodotto prodotto)
        {
            // Aggiunge il prodotto al carrello dell'utente
            ListaProdotti.Add(prodotto);
        }

        public void RimuoviProdotto(Prodotto prodotto)
        {
            // Aggiunge il prodotto al carrello dell'utente
            ListaProdotti.Remove(prodotto);
        }
    }
}
