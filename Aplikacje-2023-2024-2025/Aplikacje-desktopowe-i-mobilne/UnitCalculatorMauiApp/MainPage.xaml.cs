using System.Collections.ObjectModel;

namespace UnitCalculatorMauiApp
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<string> UnitCollection { get; set; }
        public string SelectedUnit { get; set; }

        public MainPage()
        {
            UnitCollection = new ObservableCollection<string>();
            UnitCollection.Add("KM");
            UnitCollection.Add("M");
            UnitCollection.Add("CM");
            UnitCollection.Add("DM");

            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}

