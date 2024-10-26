using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiement
{
    internal class Paypal : Paiement
    {


        public string Courriel { get; set; }
        public Paypal(string description, double montant, string email) : base(description, montant)
        {
            Courriel = email;
        }
        public override void AfficherDetails()
        {
            Console.WriteLine($"Description: {Description}, Montant: {Montant}, email : {Courriel}");
        }



    }  

}
