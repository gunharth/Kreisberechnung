using System;

namespace Kreisberechnung
{
    class Program
    {
        static void Main(string[] args)
        {
            Kreis kreis1 = new Kreis(10);
            Console.WriteLine("Durchmesser: " + kreis1.Durchmesser());
            Console.WriteLine("Umfang: " + kreis1.Umfang());
            Console.WriteLine("Fläche: " + kreis1.Flaeche());
        }
    }

    class Kreis
    {
        public double Radius; // Eigenschaft

        public Kreis(double radius) // Konstruktor
        {
            Radius = radius;
        }

        // Methoden
        public double Durchmesser()
        {
            return Radius * 2;
        }

        public double Umfang()
        {
            return 2 * Radius * Math.PI;
        }

        public double Flaeche()
        {
            return this.Radius * this.Radius * Math.PI; // this ist nicht verpflichtend - schützt aber vor Verwechslung - this referenziert immer das Object selbst
        }
    }
}
