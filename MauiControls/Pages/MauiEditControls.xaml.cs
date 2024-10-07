
namespace MauiControls.Pages;

public partial class MauiEditControls : ContentPage
{
	public MauiEditControls()
	{
		InitializeComponent();

        //Defining the BindingContext
        this.BindingContext = this;
        this.IsBusy = false;
        BtnLogin.Clicked += BtnLogin_Clicked;
    }

    private async void BtnLogin_Clicked(object sender, EventArgs e)
    {
        //Activation of the IsBusy property
        this.IsBusy = true;

        //Login logic
        await Task.Delay(2000);
        Application.Current.MainPage = new NavigationPage(new MainPage());
    }

    //private async void entry1_TextChanged(object sender, TextChangedEventArgs e)
    //{
    //    string textoAntigo = e.OldTextValue;
    //    string textoNovo = e.NewTextValue;
    //    string textoMeu = entry1.Text;

    //    await DisplayAlert("Entry1- textChanged", $"Texto antigo: {textoAntigo}\nTexto novo: {textoNovo}\nTexto meu: {textoMeu}", "OK");
    //}

    //private async void entry1_Completed(object sender, EventArgs e)
    //{
    //    string texto = ((Entry)sender).Text;
    //    await DisplayAlert("Entry1- Completed", $"Texto: {texto}", "OK");
    //}

    //private async void Button_Clicked(object sender, EventArgs e)
    //{
    //    await progressBar.ProgressTo(0.90, 2000, Easing.Linear);
    //}
}