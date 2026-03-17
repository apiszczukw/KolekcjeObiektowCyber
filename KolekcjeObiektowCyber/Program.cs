


//string[] imiona = { "Igor", "Marysia", "Janek" };

//string[] nazwiska = new string[3];

//nazwiska[0] = "Kowalski";
//nazwiska[1] = "Sędzierska";
//nazwiska[2] = "Haszczyk";

//for (int i = 0; i < 3; i++)
//{
//    Console.WriteLine($"{i + 1}. {imiona[i]} {nazwiska[i]}");
//}


//List<int> liczby = new();
//liczby.Add(30);
//liczby.Add(3);
//liczby.Add(7);
//liczby.Add(91);

//for (int i = 0; i < liczby.Count; i++)
//{
//    Console.WriteLine(liczby[i]);
//}

//List<int> lata = new() { 2006, 1997, 2020, 2025 };

//Console.WriteLine("Rozmiar listy: " + lata.Count);

//foreach (var rok in lata)
//{
//    Console.WriteLine(rok);
//}

//lata.RemoveAt(lata.Count-1);

//foreach (var rok in lata)
//{
//    Console.WriteLine(rok);
//}

//if (liczby.Contains(7))
//{
//    liczby.Remove(7);
//}

//for (int i = 0; i < liczby.Count; i++)
//{
//    Console.WriteLine(liczby[i]);
//}


using KolekcjeObiektowCyber;
using System.ComponentModel.Design;

ObslugaOsob obsluga = new();

menu:
int wybor = obsluga.WyswietlMenu();

switch(wybor)
{
    case 1:
        obsluga.DodajOsobe();
        goto menu;
    case 2:
        obsluga.WyswietlOsoby();
        goto menu;
    default:
        Console.WriteLine("Podano zły numer...");
        goto menu;
}
