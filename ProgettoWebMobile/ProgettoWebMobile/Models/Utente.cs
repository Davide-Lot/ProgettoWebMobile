
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

        public Utente() { }
        public Utente(string username,string nome,string cognome,string email, string password, string telefono, DateTime dataNascita, string indirizzo)
        {
            Username = username;
            Nome = nome;
            Cognome = cognome;
            Email = email;
            Password = password;
            Telefono = telefono;
            DataNascita = dataNascita;
            Indirizzo = indirizzo;
        }


    }
}