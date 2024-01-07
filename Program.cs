namespace MiniJeu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mon First game of the Hello World");

            Personnage p1 = new Personnage();
            Personnage p2 = new Personnage(100, 0, "Player");

            p1.sePresenter();
            p2.sePresenter();

            Console.WriteLine("Vie p1  = " + p1.Vie);
            Console.WriteLine("Vie p2  = " + p2.Vie);

            Console.WriteLine("P1 frappe P2");
            p2.Vie = p2.Vie - 5;

            Console.WriteLine("Vie p1  = " + p1.Vie);
            Console.WriteLine("Vie p2  = " + p2.Vie);

            Console.WriteLine("P2 se soigne");
            p2.seSoigner();

            Console.WriteLine("Vie p1  = " + p1.Vie);
            Console.WriteLine("Vie p2  = " + p2.Vie);

            Arme arme1 = new Arme();
            arme1.afficherCaract();

            Console.ReadLine();
        }
    }
}
