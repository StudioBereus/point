using System;
using System.Collections.Generic;
using System.Text;

namespace point
{
    class Point
    {
        public double axeX;
        public double axeY;

        //Constucteurs 
        public Point(double _axeX, double _axeY)
        {
            axeX = _axeX;
            axeY = _axeY;
        }
        public Point()
        {
            axeX = 0;
            axeY = 0;
        }
        //Méthode 
        public override string ToString()
        {
            return "Le point se situe sur l'absice : " + axeX + " et sur l'ordonnée : " + axeY + ".";
        }
        public void deplacerAbsice(double _nAxeX)
        {
            axeX = _nAxeX;
        }
        public void deplacerOrdonnee(double _nAxeY)
        {
            axeY = _nAxeY;
        }
        public void deplacerTout(double _newAxeX, double _newAxeY)
        {
            axeX = _newAxeX;
            axeY = _newAxeY;
        }
        public Point symetrieAxeX()
        {
            Point opposeX = new Point(axeX * (-1), axeY);
            return opposeX;
        }
        public Point symetrieAxeY()
        {
            Point opposeY = new Point(axeX, axeY * (-1));
            return opposeY;
        }
        public Point symetrieOrigine()
        {
            Point symOrigine = new Point(axeX*-1, axeY*(-1));
            return symOrigine;
        }

    }
}
