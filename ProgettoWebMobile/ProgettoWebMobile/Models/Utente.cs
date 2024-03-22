
using ProgettoWebMobile.Modelli;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ProgettoWebMobile.Models
{
    public class Utente
    {
        public int IDUtente { get; set; }
        public string Username { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public DateTime DataNascita { get; set; }
        public string Indirizzo { get; set; }
        public List<Carta> CarteUtente { get; set; }
        public Carrello CarrelloUtente { get; set; }

        public Utente() { }
        public Utente(string username, string nome, string cognome, string email, string password, string telefono, 
            DateTime dataNascita, string indirizzo, Carrello carrelloUtente)
        {
            Username = username;
            Nome = nome;
            Cognome = cognome;
            Email = email;
            Password = password;
            Telefono = telefono;
            DataNascita = dataNascita;
            Indirizzo = indirizzo;
            CarteUtente = new List<Carta>();
            CarrelloUtente = carrelloUtente;
        }

        // Metodo per aggiornare i dettagli dell'utente
        public void AggiornaUtente(string nome, string cognome, string email, string telefono, DateTime dataNascita, string indirizzo)
        {
            Nome = nome;
            Cognome = cognome;
            Email = email;
            Telefono = telefono;
            DataNascita = dataNascita;
            Indirizzo = indirizzo;
        }

        // Metodo per cambiare la password dell'utente
        public void CambiaPassword(string nuovaPassword)
        {
            Password = nuovaPassword;
        }
        public bool EffettuaPagamentoConCarta(decimal importo, Carta cartaUtilizzata)
        {
            // Verifica delle condizioni necessarie per effettuare il pagamento
            if (importo < 0 || CarteUtente.Count == 0 || !CarteUtente.Contains(cartaUtilizzata) || cartaUtilizzata.Saldo < importo)
            {
                return false;
            }

            // Effettua il pagamento sottraendo l'importo dal saldo sulla carta
            cartaUtilizzata.Saldo -= importo;

            // Aggiungi qui la logica per completare l'operazione di pagamento

            return true; // Pagamento effettuato con successo
        }
        

    }
}