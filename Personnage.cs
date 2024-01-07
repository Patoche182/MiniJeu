using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniJeu
{
    internal class Personnage
    {
        // Attributs
        private int vie;
        private int xp;
        private string nom;

        // Getters / Setters
        public int Vie { get => vie; set => vie = value; }
        public int Xp { get => xp; set => xp = value; }
        public string Nom { get => nom; set => nom = value; }



        // Constructeur
        public Personnage()
        {
            vie = 10;
            xp = 0;
            nom = "Perso";
        }

        public Personnage(int v, int x, string n)
        {
            Vie = v;
            Xp = x;
            Nom = n;
        }

        // Methodes
        public void sePresenter()
        {
            Console.WriteLine("Bonjour, je suis " + nom);
        }

        // Autres Methodes
        public int retournerVie()
        {
            return vie;
        }
    }
}
