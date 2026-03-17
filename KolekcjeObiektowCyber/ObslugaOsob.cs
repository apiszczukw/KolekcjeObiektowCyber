using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolekcjeObiektowCyber
{
    internal class ObslugaOsob
    {
        List<Osoba> listaOsob;

        public ObslugaOsob()
        {
            listaOsob = new();
        }

        public void DodajOsobe()
        {

            Osoba osoba = new();
            
            Console.WriteLine("Podaj imię: ");
            osoba.imie = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko: ");
            osoba.nazwisko = Console.ReadLine();
            Console.WriteLine("Podaj pesel: ");
            osoba.pesel = Console.ReadLine();

            Console.WriteLine("Podaj ile masz zwierząt: ");
            int ileZwierzat = int.Parse(Console.ReadLine());

            for (int i = 0; i < ileZwierzat; i++)
            {
                string imie;
                int wiek;
                double waga;

                Console.WriteLine("Podaj imie: ");
                imie = Console.ReadLine();
                Console.WriteLine("Podaj imie: ");
                wiek = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj imie: ");
                waga = double.Parse(Console.ReadLine());

                Zwierze zwierze = new() { imie = imie, waga = waga, wiek = wiek };

                osoba.zwierzeta.Add(zwierze);
            }


            listaOsob.Add(osoba);
        }

        public void WyswietlOsoby()
        {
            if (listaOsob.Count == 0)
            {
                Console.WriteLine("Lista osób jest pusta");
                return;
            }

            Console.WriteLine("Wyświetlanie osób...");

            foreach (var osoba in listaOsob)
            {
                osoba.WyswietlDane();
                Console.WriteLine();
            }
        }

        public int WyswietlMenu()
        {
            int wybor;
            Console.WriteLine("\n1. Dodaj osobę");
            Console.WriteLine("2. Przeglądaj osoby");
            Console.WriteLine("Wybierz numer...");

            try
            {
                wybor = int.Parse(Console.ReadLine());

                return wybor;
            }
            catch
            {
                Console.WriteLine("Wprowadziłeś nieprawidłową wartość");

                return -1;
            }
        }
    }
}
