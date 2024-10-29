using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        while (true)
        {
            // Punkt 1: Pobranie liczby kostek
            int liczbaKostek;
            while (true)
            {
                Console.Write("Podaj liczbę kostek do rzucenia (od 3 do 10): ");
                if (int.TryParse(Console.ReadLine(), out liczbaKostek) && liczbaKostek >= 3 && liczbaKostek <= 10)
                {
                    break;
                }
                Console.WriteLine("Liczba musi być w przedziale 3-10. Spróbuj ponownie.");
            }

            // Punkt 2: Losowanie kostek
            List<int> kostki = RzucKostkami(liczbaKostek, random);

            // Punkt 3: Wypisanie wyników
            for (int i = 0; i < kostki.Count; i++)
            {
                Console.WriteLine($"Kostka {i + 1}: {kostki[i]}");
            }

            // Punkt 4: Liczenie punktów
            int punkty = ObliczPunkty(kostki);
            Console.WriteLine($"Suma punktów: {punkty}");

            // Punkt 5: Zapytanie o kontynuację
            Console.Write("Czy chcesz powtórzyć grę? (t/n): ");
            char odpowiedz = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (char.ToLower(odpowiedz) != 't')
            {
                Console.WriteLine("Dziękujemy za grę!");
                break;
            }
        }
    }

    static List<int> RzucKostkami(int liczbaKostek, Random random)
    {
        List<int> wyniki = new List<int>();
        for (int i = 0; i < liczbaKostek; i++)
        {
            wyniki.Add(random.Next(1, 7)); // Losowanie z przedziału 1-6
        }
        return wyniki;
    }

    static int ObliczPunkty(List<int> kostki)
    {
        Dictionary<int, int> licznik = new Dictionary<int, int>();
        int punkty = 0;

        foreach(var kostka in kostki)
        {
            if (licznik.ContainsKey(kostka))
            {
                licznik[kostka]++;
            }
            else
            {
                licznik[kostka] = 1;
            }
        }

        foreach(var par in licznik)
        {
            if (par.Value >= 2)
            {
                punkty += par.Key * par.Value;
            }
        }

        return punkty;
    }
}
