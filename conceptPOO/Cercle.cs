using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;


namespace conceptPOO 
{
    public class Cercle : Forme
    {
        public double Rayon { get; set; }
        public Cercle(double rayon)
        {
            Rayon = rayon;
        }


        public override double CalculerAire()
        {
            return Rayon * Rayon * Math.PI;
        }

    }

}