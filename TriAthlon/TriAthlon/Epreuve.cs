using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriAthlon
{
    class Epreuve
    {
        int tempsEliminatoire;
        private string nom;
        private int distance;

        public Epreuve(int tempsEliminatoire, string nom, int distance)
        {
            this.tempsEliminatoire = tempsEliminatoire;
            this.nom = nom;
            this.distance = distance;
        }

        public string GetNom()
        {
            return this.nom;
        }

        public int GetDistance()
        {
            return this.distance;
        }

        public int GetTempsEliminatoire()
        {
            this.tempsEliminatoire;
        }

        public void SetTempsEliminatoire(int tempsEliminatoire)
        {
            this.tempsEliminatoire = tempsEliminatoire;
        }
    }
}
