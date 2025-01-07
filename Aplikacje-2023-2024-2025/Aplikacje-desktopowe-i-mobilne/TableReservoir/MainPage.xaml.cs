using System;
using Microsoft.Maui.Controls;

namespace TableReservoir
{
    public partial class MainPage : ContentPage
    {
        private Button? _selectedTableButton;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnTableButtonClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button == null) return;

            _selectedTableButton = button;
            DisplayAlert("Wybrano stolik", $"Wybrano: {button.Text.Split(' ')[0]}", "OK");
        }

        private void OnReserveClicked(object sender, EventArgs e)
        {
            if (_selectedTableButton == null)
            {
                DisplayAlert("Błąd", "Wybierz stolik do rezerwacji!", "OK");
                return;
            }

            var name = NameEntry.Text;
            if (string.IsNullOrWhiteSpace(name))
            {
                DisplayAlert("Błąd", "Podaj swoje imię!", "OK");
                return;
            }

            var date = DatePicker.Date;
            var time = TimePicker.Time;
            var startDateTime = date + time; 
            var endDateTime = startDateTime.AddHours(24); 

            _selectedTableButton.Text = $"{_selectedTableButton.Text.Split(' ')[0]} ({name} od {startDateTime:dd/MM/yyyy HH:mm} do {endDateTime:dd/MM/yyyy HH:mm})";

            _selectedTableButton = null;
            NameEntry.Text = string.Empty;
        }
    }
}
