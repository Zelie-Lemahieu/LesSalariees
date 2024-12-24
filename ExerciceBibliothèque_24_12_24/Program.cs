using System;
using System.Runtime.ExceptionServices;
using ExerciceBibliothèque_24_12_24.classes;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initialisation variables
            int entreeUtilisateur = 0;
            List<Livre> livres = new List<Livre>();
            Livre nouveauLivre = new Livre("", "", 0, false);
            //INSTANCIATION PAR LA CONSOLE D'OBJET:
            do
            {
                Console.WriteLine("Voulez-vous entrer un nouveau livre ?\n1---oui\t\t0---non");
                entreeUtilisateur = int.Parse(Console.ReadLine());
                if (entreeUtilisateur == 1)
                {
                    Console.WriteLine("Entrer un titre, puis un auteur, puis une année de publiaction");
                    nouveauLivre = new Livre(Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()), false);
                }
            } while (entreeUtilisateur != 0);

            //INSTANCIATION DES OBJETS "LIVRE":
            Livre ZibiBooboop = new Livre("Zibi Booboop : Bogos Binted", "Glorp", -156241, false);
            Livre lAgendaDuGeek = new Livre("L'Agenda Du Geek 2016-2017", "Squeezie", 2016, false);
            Livre frigielEtFluffy = new Livre("Frigiel et Fluffy - Tome 1 - Le retour de l'Ender dragon", "Frigiel", 2016, false);

            //Ajout des livres à la liste
            livres.Add(ZibiBooboop);
            livres.Add(lAgendaDuGeek);
            livres.Add(frigielEtFluffy);
            livres.Add(nouveauLivre);

            //AFFICHAGE DÉTAILS DES LIVRES:
            foreach(Livre livre in livres)
            {
                livre.AfficherDetails();
            };
            Console.WriteLine("\n\n");

            //Simulation de gestion des livres:
            ZibiBooboop.Rendre();
            lAgendaDuGeek.Emprunter();
            lAgendaDuGeek.Emprunter();
            frigielEtFluffy.Rendre();
            lAgendaDuGeek.Rendre();
            ZibiBooboop.Emprunter();
            frigielEtFluffy.Emprunter();


        }
    }
}