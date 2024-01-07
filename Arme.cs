using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniJeu
{
    class Arme
    {
        private string nom;
        private int degats;
        private int durabilite;

        public string Nom { get => nom; set => nom = value; }
        public int Degats { get => degats; set => degats = value; }
        public int Durabilite { get => durabilite; set => durabilite = value; }

        public Arme()
        {
            nom = "arme";
            degats = 1;
            durabilite = 1;
        }

        public Arme(string n, int d, int d2)
        {
            nom = n;
            degats = d;
            durabilite = d2;
        }

        public void afficherCaract()
        {
            Console.WriteLine("Nom : " + nom);
            Console.WriteLine("Dégats : " + degats);
            Console.WriteLine("Durabilité : " + durabilite);
        }
    }
}
