using MauiControls.Models;

namespace MauiControls.Pages;

public partial class MauiCollectionsControls : ContentPage
{
	public MauiCollectionsControls()
	{
		InitializeComponent();
		BindingContext = new FotoViewModel();
	}

    private void AlertaCinto_OnChanged(object sender, ToggledEventArgs e)
    {
        DisplayAlert("Alerta", $"Você selecionou/deselecionou", "OK");
    }

    //private async void CarouselView_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
    //{
    //	if (e.CurrentItem != null && e.PreviousItem != null)
    //	{
    //		Foto anterior = e.PreviousItem as Foto;
    //		Foto proximo = e.CurrentItem as Foto;
    //		await DisplayAlert("CarouselView", $"Você estava vendo a foto {anterior.Name}\ne agora está vendo a foto {proximo.Name}", "OK");
    //	}
    //}
}