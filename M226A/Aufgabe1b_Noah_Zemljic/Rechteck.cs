using System;
using System.Collections.Generic;
using System.Text;

namespace Block_1
{
    class Rechteck
    {
        private double seiteA, seiteB, flaeche;
        public static double seiteAStatic, seiteBStatic, flaecheStatic;
        public void setSeiten(double a, double b) {
            seiteA = a;
            seiteB = b;
        }

        public static void calcFlaeche() {
            flaecheStatic = seiteAStatic * seiteBStatic;
        }

        public double getFlaeche() {
            flaeche = seiteA * seiteB;
            return flaeche;
        }
        

    }
}
