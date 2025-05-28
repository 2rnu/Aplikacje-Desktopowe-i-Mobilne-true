namespace Inf04___2025._01
{
        public partial class MainPage : ContentPage
        {
            private bool vacuumCleanerStatus = false;

            public MainPage()
            {
                InitializeComponent();
            }

            private void OnClicked(object sender, EventArgs e)
            {
                if (int.TryParse(WashingEntry.Text, out int numer) && numer >= 1 && numer <= 12)
                {
                LaundryNumberLabel.Text = $"Numer prania: {numer}";
                }
                else
                {
                LaundryNumberLabel.Text = "Numer prania: nie podano";
                }
            }

            private void OnVacuumClicked(object sender, EventArgs e)
            {
            vacuumCleanerStatus = !vacuumCleanerStatus;

                if (vacuumCleanerStatus)
                {
                VacuumCleanerButton.Text = "Wyłącz";
                VacuumStatusLabel.Text = "Odkurzacz włączony";
                }
                else
                {
                VacuumCleanerButton.Text = "Włącz";
                VacuumStatusLabel.Text = "Odkurzacz wyłączony";
                }
            }
        }
    }

