using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolekcjeObiektowCyber
{
    internal class Osoba
    {
        public string imie;
        
        public string nazwisko;

        public string pesel;

        public List<Zwierze> zwierzeta;

        public Osoba(string pesel = "", string imie = "", string nazwisko = "")
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.pesel = pesel;

            zwierzeta = new();
        }

        public void WyswietlDane()
        {
            Console.WriteLine("Pesel: " + pesel);
            Console.WriteLine($"Imię i nazwisko: {imie} {nazwisko}");

            Console.WriteLine("Zwierzęta: ");
            foreach (var zwierze in zwierzeta)
            {
                Console.WriteLine("Imię zwierzęcia: " + zwierze.imie);
                Console.WriteLine("Waga zwierzęcia: " + zwierze.waga);
                Console.WriteLine("Wiek zwierzęcia: " + zwierze.wiek);
                Console.WriteLine();
            }
        }
    }
}
