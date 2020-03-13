using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriAthlon
{
    class Participant
    {
        int id;
        string nom;
        DateTime dateInscription;
        List<Resultat> lesResultats;

        Participant(string nom, DateTime dateInscription)
        {

        }

        public int GetId()
        {
            return this.id;
        }

        public string GetNom()
        {
            return this.nom; 
        }

        public bool resultatPresent(Epreuve uneEpreuve)
        {
            foreach(Resultat result in lesResultats)
            {
                if(result.GetEpreuve().GetNom() == uneEpreuve.GetNom())
                {
                    return true;
                }
            }
            return false;
        }

        public void Add(Epreuve uneEpreuve, int tempsRealise)
        {
            Resultat result = new Resultat(unParticipant, uneEpreuve, tempsRealise);
            {
                if (resultatPresent(uneEpreuve.GetNom()))
                {
                    this.lesResultats.Add(result);
                }

            
            }
        }

        public int GetTempsTotal()
        {

        }

        public bool HorsDelai()
        {
            return false;
        }
    }
}
