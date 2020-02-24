using System;

public class exotp1
{

    public void exo1()
    {
        Console.WriteLine("Rentrez votre nom");
        String nom = Utilisateur.saisirTexte();
        Console.WriteLine("Bonjour " + nom);
    }

    public void exo2()
    {
        Console.WriteLine("Rentrez la première note ");
        double note1 = Utilisateur.saisirReel();
        Console.WriteLine("Rentrez la deuxieme note ");
        double note2 = Utilisateur.saisirReel();
        Console.WriteLine("Rentrez la troisieme note ");
        double note3 = Utilisateur.saisirReel();
        double moyenne = (note1 + note2 + note3) / 3;
        System.Console.WriteLine("La moyenne est : " + moyenne);
    }

    public void exo3()
    {
        System.Console.WriteLine("Rentrez la hauteur du triangle ");
        double hauteur = Utilisateur.saisirReel();
        System.Console.WriteLine("Rentrez la base du triangle ");
        double Base = Utilisateur.saisirReel();
        double aire = (Base * hauteur) / 2;
        System.Console.WriteLine("L'aire du triangle est : " + aire);
    }

    public void exo4()
    {
        System.Console.WriteLine("Rentrez le rayon du Cercle ");
        double rayon = Utilisateur.saisirReel();
        double aire = Math.PI * Math.Sqrt(rayon);
        System.Console.WriteLine("L'aire du cercle est : " + aire);
    }

    public void exo5()
    {
        System.Console.WriteLine("Choississez la taille du carré");
        int taille = Utilisateur.saisirEntier();
        for (int numligne = 0; numligne != taille - 1; numligne++)
        {
            if (numligne == 0 || numligne == taille - 2)
            {
                for (int pdLignes = 0; pdLignes <= taille - 2; pdLignes++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("*");
            }
            // if (numligne>0 || numligne<taille)
            // {
            Console.Write("*");
            for (int inteLignes = 0; inteLignes <= taille - 3; inteLignes++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("*");
            // }	
        }
    }

    public void exo6()
    {
        double note = 0, entreenote, compteur = 0, moyenne = 0;
        System.Console.WriteLine("Pour Sortir, entrez 100");
        do
        {
            System.Console.WriteLine("Rentrez la note à ajouter.");
            entreenote = Utilisateur.saisirEntier();
            if (entreenote >= 0 && entreenote <= 20)
            {
                compteur += 1;
                note += entreenote;
                moyenne = note / compteur;
            }
            else if (entreenote != 100)
            {
                System.Console.WriteLine("Entrez une note entre 0 et 20");
            }


        } while (entreenote != 100);

        System.Console.WriteLine($"La moyenne est de : {moyenne} ");
    }

    public void exo61()
    {
        int nbNotes = 0;
        System.Console.WriteLine("Combien de notes voulez vous rentrer ?");
        nbNotes = Utilisateur.saisirEntier();
        double entreenote, moyenne = 0;
        for (int i = 1; i <= nbNotes; i++)
        {
            System.Console.WriteLine("Entrez une note");
            entreenote = Utilisateur.saisirEntier();
            if (entreenote >= 0 && entreenote <= 20)
            {
                moyenne += entreenote;
            }
            else
            {
                System.Console.WriteLine("Entrez une note entre 0 et 20");
            }
        }
        moyenne = moyenne / nbNotes;
        System.Console.WriteLine($"La Moyenne est de {moyenne}");
    }

    public void exo7()
    {
        int compteur = 1;
        double facto = 1;
        System.Console.WriteLine("Saisir un entier");
        int N = Utilisateur.saisirEntier();
        while (compteur <= N)
        {
            facto = facto * compteur;
            compteur += 1;
        }
        System.Console.WriteLine($"La factorielle de {N} est {facto}");
    }

    public void exo8()
    {
        var generateur = new Random();
        int nombreAleatoire = 0;
        nombreAleatoire = generateur.Next(1, 100);
        int nbsaisi;
        System.Console.WriteLine("Saisir un entier");
        do
        {
            nbsaisi = Utilisateur.saisirEntier();
            if (nbsaisi < nombreAleatoire)
            {
                System.Console.WriteLine("C'est Plus !");
            }
            else if (nbsaisi > nombreAleatoire)
            {
                System.Console.WriteLine("C'est Moins !");
            }
            else if (nbsaisi == nombreAleatoire)
            {
                System.Console.WriteLine("Ha Oui ! Oui ! Oui !");
            }
        }
        while (nombreAleatoire != nbsaisi);
    }
    public void exo9()
    {
        int nbAllumette = 20;
        int choix, Joueur = 1, saisieMax = 3;
        do //Tour de jeu
        {
            System.Console.WriteLine($"Il reste {nbAllumette} allumette{(nbAllumette > 1 ? "s" : "")}");
            if (saisieMax > nbAllumette)
            {
                saisieMax = nbAllumette;
            }
            do //saisie par l'utilisateur
            {
                if (saisieMax == 1)
                {
                    Console.WriteLine($"{Joueur}, Assumez votre défaite et prenez la dernière allumette");
                }
                else
                {
                    System.Console.WriteLine($"Joueur {Joueur}, retirez entre 1 et {saisieMax} allumettes.");
                }
                choix = Utilisateur.saisirEntier();
            } while (choix < 1 || choix > saisieMax);

            nbAllumette -= choix;
            switch (Joueur)
            {
                default:
                case 1:
                    Joueur = 2;
                    break;
                case 2:
                    Joueur = 1;
                    break;
            }
        } while (nbAllumette > 0);
        System.Console.WriteLine($"Joueur {Joueur} tu as gagné ! GG");
    }
}

public class exotp2
{
    //Exo 1
    public void exo1()
    {
        float a, b;
        Console.WriteLine($"Entrez la valeur de a puis de b");
        a = float.Parse(Console.ReadLine());
        b = float.Parse(Console.ReadLine());
        pythagore(a, b);
    }
    void pythagore(float a, float b)
    {
        float c = MathF.Sqrt(a * a + b * b);
        Console.WriteLine($"L'hypothésune de ce triangle est {c}");
    }

    //Exo 2
    public void exo2()
    {
        DemandeValeur();
    }

    void DemandeValeur()
    {
        int saisieUtilisateur, compteurNormal = 0, compteurParSept = 0;

        do
        {
            Console.WriteLine("Entrez une valeur");
            saisieUtilisateur = Utilisateur.saisirEntier();
            if (saisieUtilisateur != 0)
            {
                compteurNormal += 1;
                if (saisieUtilisateur % 7 == 0)
                {
                    compteurParSept += 1;
                }
            }
        } while (saisieUtilisateur != 0);
        Console.WriteLine($"Vous avez rentré {compteurNormal} valeurs mais seulement {compteurParSept} sont divisibles par 7");
    }
    //Exo 3
    public void exo3()
    {
        int saisieUtilisateur;
        Console.WriteLine("Entrez un entier");
        saisieUtilisateur = Utilisateur.saisirEntier();
        multiplication(saisieUtilisateur);
    }

    public void multiplication(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                Console.Write(i * j + " ");
            }
            Console.WriteLine("");
        }
    }

    //Exo4

    public void exo4()
    {
        sommeProche(10);
        Console.WriteLine("Ca devrait être 10");
        Console.WriteLine("");

        sommeProche(11);
        Console.WriteLine("Ca devrait être 10");
        Console.WriteLine("");

        sommeProche(14);
        Console.WriteLine("Ca devrait être 15");
        Console.WriteLine("");

        sommeProche(18);
        Console.WriteLine("Ca devrait être 15");
    }

    private void sommeProche(int nbATrouver)
    {


        Console.WriteLine($"Le nombre à trouver est {nbATrouver}");
        Console.WriteLine($"Le compteur est {null}");
    }


}