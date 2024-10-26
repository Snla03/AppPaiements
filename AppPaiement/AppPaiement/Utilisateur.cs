using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiement
{
    internal class Utilisateur
    {
        public string Nom { get; set; }
        public List<Paiement> Paiements { get; set; }
        public Utilisateur(string nom)
        {
            Nom = nom;
            Paiements = new List<Paiement>();
        }

        public void AfficherInfos()
        {
            Console.WriteLine($"Utilisateur : {Nom}");
            Console.WriteLine("Liste des paiements :");
            foreach (var paiement in Paiements)
            {
                paiement.AfficherDetails();
         
            }
            void AjouterPaiement(Paiement paiement)
            {
                Paiements.Add(paiement);
            }
           
              
            
        }

    }
}
