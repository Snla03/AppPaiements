using AppPaiement;

internal class Program
{
    private static void Main(string[] args)
    {

        List<CarteCredit> ListCartes = new List<CarteCredit>();
        CarteCredit carte1 = new CarteCredit( "payement de scolariter",1000, 123456789);
        CarteCredit carte2 = new CarteCredit( "shelby shawarma",2000,  987654321);
        CarteCredit carte3 = new CarteCredit("Café",30,  112233445);

        carte1.AfficherDetails();
        carte2.AfficherDetails();
        carte3.AfficherDetails();


        Paypal pay1 = new Paypal("travail boreal", 1000, "achillenogue@gmail");
        Paypal pay2 = new Paypal("acteur ", 5000, "achillenogue@icloud.com");

        pay1.AfficherDetails();
        pay2.AfficherDetails();
    }
}