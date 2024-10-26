using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiement
{
    internal class CarteCredit : Paiement
    {
        public int NumeroCarte { get; set; }
        public CarteCredit(  string description, double montant, int numerocarte) : base ( description , montant)
        {
            NumeroCarte = numerocarte;
        }
        public override void AfficherDetails()
        {
            Console.WriteLine($"Description: {Description}, Montant: {Montant}, NumeroCarte : {NumeroCarte}");
        }

    }


}
