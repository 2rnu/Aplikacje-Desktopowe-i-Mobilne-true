using System.Collections.ObjectModel;

namespace UnitCalculatorMauiApp
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<string> UnitCollection { get; set; }
        public ObservableCollection<string> SizeFrom { get; set; }
        public ObservableCollection<string> SizeInto { get; set; }

        private string selectedUnitOne;

        public string SelectedUnitOne
        {
            get { return selectedUnitOne; }
            set { selectedUnitOne = value; }
        }

        private string selectedUnitSecond;

        public string SelectedUnitSecond
        {
            get { return selectedUnitSecond; }
            set { selectedUnitSecond = value; }
        }

        private int sizeToConvert;

        public int SizeToConvert
        {
            get { return sizeToConvert; }
            set { sizeToConvert = value; }
        }



        public MainPage()
        {
            SizeFrom = ["KM", "M", "CM", "DM"];
            SizeInto = ["KM", "M", "CM", "DM"];

            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            

        }
    }
}

