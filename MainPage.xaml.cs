namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnPageOneClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StackLayout());
        }      
        private void OnPageTwoClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FlexLayout());
        }
    }
}
