namespace TabPageMauiApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            TabbedPage tabbedPage = new TabbedPage();
            tabbedPage.Children.Add(new MainPage() {Title = "Główna" });
            tabbedPage.Children.Add(new AnotherPage());
            tabbedPage.Children.Add(new AboutPage() { IconImageSource = "pc_ver_1.png" });



            return new Window(tabbedPage);
        }
    }
}