using Microsoft.UI.Xaml;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace ShowCollectionMauiApp
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<string> FruitsCollection { get; set; }
        public string SelectedFruit { get; set; }

        private string selectedFruitMessage;

        public string SelectedFruitMessage
        {
            get { return selectedFruitMessage; }
            set { selectedFruitMessage = value; OnPropertyChanged(); }
        }

        public string NewFruitName { get; set; }

        public  ObservableCollection<Car> CarsCollection { get; set; }

        public MainPage()
        {
            FruitsCollection = new ObservableCollection<string>();
            FruitsCollection.Add("Banan");
            FruitsCollection.Add("Jabłko");
            FruitsCollection.Add("Tuskawka");
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            SelectedFruitMessage = "Wybrano owoc: " + SelectedFruit;
        }

        private void Button_Clicked_New_Fruit(object sender, EventArgs e)
        {
            FruitsCollection.Add(NewFruitName);
        }
    }

}
