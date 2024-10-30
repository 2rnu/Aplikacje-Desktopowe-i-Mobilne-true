using System;

namespace GrawKosci
{
    class Program
    {
        static int rollScore = 0;
        static int totalScore = 0;
        static Random random = new Random();

        static void Main(string[] args)
        {
            while (true)
            {
                int diceAmmount;
                while (true)
                {
                    Console.Write("Podaj liczbę kostek do rzucenia (od 3 do 10): ");
                    if (int.TryParse(Console.ReadLine(), out diceAmmount) && diceAmmount >= 3 && diceAmmount <= 10)
                    {
                        break;
                    }
                    Console.WriteLine("Liczba musi być w przedziale 3-10. Spróbuj ponownie.");
                }

                RollDice(diceAmmount);
                Console.WriteLine($"Suma punktów: {rollScore}");
                Console.WriteLine($"Łączny wynik gry: {totalScore}");

                Console.Write("Czy chcesz powtórzyć grę? (t/n): ");
                string odpowiedz = Console.ReadLine();

                if (odpowiedz.ToLower() != "t")
                {
                    Console.WriteLine("Dziękujemy za grę!");
                    break;
                }

                Console.WriteLine();
            }
        }

        static void RollDice(int diceAmmount)
        {
            rollScore = 0;
            int[] diceResults = new int[diceAmmount];
            int[] counts = new int[7]; 

            for (int i = 0; i < diceAmmount; i++)
            {
                diceResults[i] = random.Next(1, 7);
                Console.WriteLine($"Kostka {i + 1}: {diceResults[i]}");
                counts[diceResults[i]]++; 
            }

            for (int i = 1; i <= 6; i++)
            {
                if (counts[i] > 1)
                {
                    rollScore += i * counts[i];
                }
            }

            totalScore += rollScore;
        }

        static void ResetScore()
        {
            rollScore = 0;
            totalScore = 0;
        }
    }
}