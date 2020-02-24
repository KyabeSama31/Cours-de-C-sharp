using System;

namespace CoursCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            tp1 app1 = new tp1();
            tp2 app2 = new tp2();
            int choix;
            Console.WriteLine("Quel tp voulez vous lancer ? ");
            choix = Utilisateur.saisirEntier();
            switch (choix)
            {
                default:
                case 1:
                    app1.fonctionPrincipale();
                    break;
                case 2:
                    app2.fonctionPrincipale();
                    break;
            }
        }
    }
}
