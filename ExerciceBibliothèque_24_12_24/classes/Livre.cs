using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ajout du dossier contenant les classes:
using ExerciceBibliothèque_24_12_24.classes;

namespace ExerciceBibliothèque_24_12_24.classes
{
    internal class Livre
    {
        //ATTRIBUTS
        private String _titre;
        private String _auteur;
        private int _anneeDePublication;
        private bool _estEmprunte;

        //PROPRIÉTÉS
        public String Titre { get { return _titre; } set { _titre = value; } }
        public String Auteur { get { return _auteur; } set { _auteur = value; } }
        public int AnneeDePublication { get { return _anneeDePublication; } set { _anneeDePublication = value; } }
        public bool EstEmprunte { get { return _estEmprunte; } set { _estEmprunte = value; } }

        //CONSTRUCTEUR
        public Livre (string titre, string auteur, int anneeDePublication, bool estEmrunte)
        {
            Titre = titre;
            Auteur = auteur;
            AnneeDePublication = anneeDePublication;
            EstEmprunte = estEmrunte;
        }

        //CONSTRUCTEUR AUTEUR INCONNUE
        public Livre (string titre, int anneeDePublication, bool estEmrunte)
        {
            Titre = titre;
            Auteur = "Auteur Inconnu";
            AnneeDePublication = anneeDePublication;
            EstEmprunte = estEmrunte;
        }


        //MÉTHODE EMPRUNTER
        public void Emprunter()
        {
            if (EstEmprunte == true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\t---Impossible d'emprunter. Le livre \"{Titre}\" est déjà en cours d'emprunt.---");
                Console.ResetColor();
            } else
            {
                EstEmprunte = true;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Le livre \"{Titre}\" a bien été emprunté.");
                Console.ResetColor();
            }
        }

        //MÉTHODE RENDRE
        public void Rendre()
        {
            if (EstEmprunte == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\t---Impossible de rendre. Le livre \"{Titre}\" n'est pas en cours d'emprunt.---");
                Console.ResetColor();
            }
            else
            {
                EstEmprunte = false;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Le livre \"{Titre}\" a bien été rendu.");
                Console.ResetColor();
            }
        }

        //MÉTHODE AFFICHER DÉTAILS:
        public void AfficherDetails()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"Titre : {Titre}, Auteur : {Auteur}, Année de publication : {AnneeDePublication}, Statut : ");
            if (EstEmprunte == true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Emprunté");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Disponible");
            };
        }
    }
}
