using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progetto_Battaglia_Navale
{
    class Utente
    {
        private string nome;
        private string nomeUtente;
        private string cognome;
        private string email;
        private string password;

        public Utente()
        {
            this.Nome = "";
            this.NomeUtente = "";
            this.Cognome = "";
            this.Email = "";
            this.Password = "";
        }

        public string Nome { get => nome; set => nome = value; }
        public string Cognome { get => cognome; set => cognome = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string NomeUtente { get => nomeUtente; set => nomeUtente = value; }

        public Utente(string _nome,string _nomeUtente, string _cognome, string _email, string _password)
        {
            nome = _nome;
            nomeUtente = _nomeUtente;
            cognome = _cognome;
            email = _email;
            password = _email;
        }

        public override string ToString()
        {
            string frase = " ";
            frase = nomeUtente + " " + nome + " " + cognome + " " + Email + " " + Password;
            return frase;
        }
        public string ToCSV()
        {
            string frase = " ";
            frase = nomeUtente + ";" + nome + ";" + cognome + ";" + email + ";" + password + ";";
            return frase;
        }

        public bool controlloDuplicati(string _email,string _nomeUtente)
        {
            string nU;
            string n;
            string cn;
            string e;
            string p;
            bool controllo = false;
            foreach(string line in System.IO.File.ReadLines(@"utenti.txt"))
            {
                if (line != "")
                {
                    string[] str = line.Split(';');
                    nU = str[0];
                    n = str[1];
                    cn = str[2];
                    e = str[3];
                    p = str[4];

                    if (e == _email || nU == _nomeUtente)
                        controllo = true;
                }
            }
            return controllo;
        }

        public void FromCSV(string frase)
        {
            string[] str = frase.Split(';');
            nomeUtente = str[0];
            nome= str[1];
            cognome = str[2];
            email = str[3];
            password = str[4];
        }
        public static Utente fromCSV(string text)
        {
            string[] vs = text.Split(';');
            return new Utente(vs[0], vs[1], vs[2], vs[3], vs[4]);
        }
        public string ReadUtenti(string fileName)
        {
            string str = System.IO.File.ReadAllText(fileName);
            return str;
        }
    }
}
