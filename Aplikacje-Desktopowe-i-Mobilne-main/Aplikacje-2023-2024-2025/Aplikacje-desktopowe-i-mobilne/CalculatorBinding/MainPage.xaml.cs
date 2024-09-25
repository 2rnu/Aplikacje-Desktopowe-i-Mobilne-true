namespace CalculatorBinding
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!int.TryParse(firstEntryNumber.Text, out int firstReadedNumber))
            {
                //komunikat o istnieniu błędu
                resaultLabel.Text = "Pierwsza liczba ma niedopuszczalny format! Sprzwdż, czy podana liczba nie ma żadnych znaków, ani liter.";
                resaultLabel.TextColor = new Color(255, 0, 0);
                return;
            }

            if (!int.TryParse(secondEntryNumber.Text, out int secondReadedNumber))
            {
                //komunikat o istnieniu błedu
                resaultLabel.Text = "Druga liczba ma niedopuszczalny format! Sprzwdż, czy podana liczba nie ma żadnych znaków, ani liter.";
                resaultLabel.TextColor = new Color(255, 0, 0);
                return;
            }

            int resault = 0;

            if (operationAddRadioButton.IsChecked)
            {
                resault = firstReadedNumber + secondReadedNumber;
            }

            if (operationSubstrationRadioButton.IsChecked)
            {
                resault = firstReadedNumber - secondReadedNumber;
            }

            if (operationMultiplicationRadioButton.IsChecked)
            {
                resault = firstReadedNumber * secondReadedNumber;
            }

            if (operationDivisionRadioButton.IsChecked)
            {
                resault = firstReadedNumber / secondReadedNumber;
            }

            resaultLabel.Text = $"Wynik operacji {resault}";
            resaultLabel.TextColor = Colors.Green;

        }
    }

}
