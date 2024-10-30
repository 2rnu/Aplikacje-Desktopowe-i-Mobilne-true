using System;
using Microsoft.Maui.Controls;

namespace Kosci
{
    public partial class MainPage : ContentPage
    {
        int rollScore = 0;
        int totalScore = 0;
        private readonly Random random;

        public MainPage()
        {
            InitializeComponent();
            random = new Random();
        }

        private void OnRollDiceClicked(object sender, EventArgs e)
        {
            int sum = 0;
            int[] diceResults = new int[5];

            for (int i = 0; i < 5; i++)
            {
                diceResults[i] = random.Next(1, 7);
                sum += diceResults[i];
            }

            DiceImage1.Source = $"k{diceResults[0]}.jpg";
            DiceImage2.Source = $"k{diceResults[1]}.jpg";
            DiceImage3.Source = $"k{diceResults[2]}.jpg";
            DiceImage4.Source = $"k{diceResults[3]}.jpg";
            DiceImage5.Source = $"k{diceResults[4]}.jpg";

            rollScore = sum;
            totalScore += sum;
            RollScoreLabel.Text = rollScore.ToString();
            TotalScoreLabel.Text = totalScore.ToString();
        }

        private void OnResetScoreClicked(object sender, EventArgs e)
        {
            rollScore = 0;
            totalScore = 0;

            DiceImage1.Source = "question.jpg";
            DiceImage2.Source = "question.jpg";
            DiceImage3.Source = "question.jpg";
            DiceImage4.Source = "question.jpg";
            DiceImage5.Source = "question.jpg";

            RollScoreLabel.Text = "0";
            TotalScoreLabel.Text = "0";
        }
    }
}
