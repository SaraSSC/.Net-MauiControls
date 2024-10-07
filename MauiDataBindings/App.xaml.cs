using MauiDataBindings.Pages;

namespace MauiDataBindings
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new NotifyBinding());
        }
    }
}
