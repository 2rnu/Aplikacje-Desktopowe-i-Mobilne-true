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

            DiceImage1.Source = $"dice_{diceResults[0]}.png";
            DiceImage2.Source = $"dice_{diceResults[1]}.png";
            DiceImage3.Source = $"dice_{diceResults[2]}.png";
            DiceImage4.Source = $"dice_{diceResults[3]}.png";
            DiceImage5.Source = $"dice_{diceResults[4]}.png";

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
