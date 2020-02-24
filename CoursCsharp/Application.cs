using System;

public class tp1
{
    public void fonctionPrincipale()
    {
        exotp1 exo = new exotp1();

        System.Console.WriteLine("Quel Exo voulez vous lancer ?");
        int choix = Utilisateur.saisirEntier();
        switch (choix)
        {
            case 1:
                exo.exo1();
                break;

            case 2:
                exo.exo2();
                break;

            case 3:
                exo.exo3();
                break;

            case 4:
                exo.exo4();
                break;

            case 5:
                exo.exo5();
                break;

            case 6:
                exo.exo6();
                break;

            case 61:
                exo.exo61();
                break;

            case 7:
                exo.exo7();
                break;

            case 8:
                exo.exo8();
                break;

            case 9:
                exo.exo9();
                break;

        }
    }
}

public class tp2
{
    public void fonctionPrincipale()
    {
        exotp2 exo = new exotp2();
        System.Console.WriteLine("Quel Exo voulez vous lancer ?");
        int choix = Utilisateur.saisirEntier();
        switch (choix)
        {
            case 1:
                exo.exo1();
                break;
            case 2:
                exo.exo2();
                break;
            case 3:
                exo.exo3();
                break;
            case 4:
                exo.exo4();
                break;

        }
    }
}