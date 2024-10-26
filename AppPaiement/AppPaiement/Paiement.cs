using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiement
{


    public abstract class Paiement
    {

        public  string Description { get; set; }
        public  double Montant { get; set; }

        public Paiement(string description, double montant)
        {
            Description = description;
            Montant = montant;
        }
        public virtual void AfficherDetails()
        {
            Console.WriteLine($"Description: {Description}, Montant: {Montant}");
        }
        
        
        
  

      
    }    
}
    

