using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;


namespace conceptPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Random nombreAleatoire = new Random(); 
            double largeur = nombreAleatoire.Next();
            double longueur = nombreAleatoire.Next();
            double rayon = nombreAleatoire.Next();

            Forme formeOne = new Rectangle(largeur, longueur); 
            Forme formeTwo = new Cercle(rayon); 

            List<Forme> formes = [formeOne, formeTwo]; 

            foreach (Forme forme in formes)
            {
                System.Console.WriteLine($"Aire = {forme.CalculerAire()}");
            } */

            Animal animalOne = new Dog(); 
            Animal animalTwo = new Cat(); 
            Animal animalThree = new Oiseau();

            List<Animal> animaux = [animalOne, animalTwo, animalThree];
            foreach (Animal animal in animaux)
            {
                animal.MakeSound();
            }

        }
    }
}

