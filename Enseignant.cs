using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alimentation_Eleve
{
    class Enseignant
    {
        private int id;
        private string nom;
        private string prenom;
        private string login;
        private string hashPassWord;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string HashPassWord
        {
            get { return hashPassWord; }
            set { hashPassWord = value; }
        }

        public Enseignant(int id, string nom, string prenom, string login, string hashPassWord) {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.login = login;
            this.hashPassWord = hashPassWord;
        }
    }
}
