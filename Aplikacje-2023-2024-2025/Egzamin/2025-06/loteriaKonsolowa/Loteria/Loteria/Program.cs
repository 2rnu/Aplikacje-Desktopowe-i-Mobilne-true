using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę zestawów do wylosowania: ");
        int n = int.Parse(Console.ReadLine());

        int[,] losowania = new int[n, 6];

        GenerujLosowania(losowania);

        Console.WriteLine("\nWylosowane zestawy:");
        WyswietlLosowania(losowania);

        int[] liczniki = new int[50];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                liczniki[losowania[i, j]]++;
            }
        }

        Console.WriteLine("\nLiczba wystąpień poszczególnych liczb:");
        for (int k = 1; k <= 49; k++)
        {
            Console.WriteLine($" Wystąpienia liczby {k,2}: {liczniki[k]}");
        }
    }
    static void GenerujLosowania(int[,] tab)
    {
        Random rnd = new Random();
        int wiersze = tab.GetLength(0);

        for (int i = 0; i < wiersze; i++)
        {
            HashSet<int> zestaw = new HashSet<int>(); //* kolekcja bez duplikatów, wbudowana w C#
            while (zestaw.Count < 6)
            {
                int liczba = rnd.Next(1, 50);
                zestaw.Add(liczba);
            }

            int kol = 0;
            foreach (int liczba in zestaw)
            {
                tab[i, kol++] = liczba;
            }
        }
    }
    static void WyswietlLosowania(int[,] tab)
    {
        int wiersze = tab.GetLength(0);
        int kolumny = tab.GetLength(1);

        for (int i = 0; i < wiersze; i++)
        {
            Console.Write($"Zestaw {i + 1}: ");
            for (int j = 0; j < kolumny; j++)
            {
                Console.Write($"{tab[i, j],2} ");
            }
            Console.WriteLine();
        }
    }
}
