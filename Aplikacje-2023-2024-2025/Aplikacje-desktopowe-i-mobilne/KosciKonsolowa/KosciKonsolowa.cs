using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        while (true)
        {
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

            int[] kostki = RzucKostkami(liczbaKostek, random);

            for (int i = 0; i < kostki.Length; i++)
            {
                Console.WriteLine($"Kostka {i + 1}: {kostki[i]}");
            }

            int punkty = ObliczPunkty(kostki);
            Console.WriteLine($"Suma punktów: {punkty}");

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

    static int[] RzucKostkami(int liczbaKostek, Random random)
    {
        int[] wyniki = new int[liczbaKostek];
        for (int i = 0; i < liczbaKostek; i++)
        {
            wyniki[i] = random.Next(1, 7);
        }
        return wyniki;
    }

    static int ObliczPunkty(int[] kostki)
    {
        int[] licznik = new int[7];
        int punkty = 0;

        foreach (var kostka in kostki)
        {
            licznik[kostka]++;
        }

        for (int i = 1; i <= 6; i++)
        {
            if (licznik[i] >= 2)
            {
                punkty += i * licznik[i];
            }
        }

        return punkty;
    }
}
