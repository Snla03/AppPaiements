internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    public abstract class paiement
    {

        public abstract string Description { get; set; }
        public abstract int Montant { get; set; }

        public paiement(string description, int montant)
        {
            Description = description;
            Montant = montant;
        }
        public void AfficherDetails()
        {
            Console.WriteLine($"Description: {Description}, Montant: {Montant}");
        }
     }
}
