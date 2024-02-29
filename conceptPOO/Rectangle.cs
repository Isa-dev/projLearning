using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;


namespace conceptPOO 
{

    public class Rectangle : Forme
    {
        public double Longueur { get; set; }
        public double Largeur { get; set; }

        public Rectangle(double longueur, double largeur)
        {
            Longueur = longueur;
            Largeur = largeur;
        }

        public override double CalculerAire()
        {
            return Largeur * Longueur;
        }


    }
}