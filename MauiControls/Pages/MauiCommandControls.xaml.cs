namespace MauiControls;

public partial class MauiCommandControls : ContentPage
{
	public MauiCommandControls()
	{
		InitializeComponent();
	}

    private async void btnDemo_Clicked(object sender, EventArgs e)
    {
		//Rotates the text 360 degrees
		await lblDemo.RelRotateTo(360, 2000);
		await DisplayAlert("Button","Tarefa concluida", "OK");
    }

    private async void btnImgDemo_Clicked(object sender, EventArgs e)
    {
        await lblDemo.RelRotateTo(360, 5000);
    }

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        // Get the selected RadioButton value and writes it to the label
        RadioButton selectedRaioButton = ((RadioButton)sender);
        if (lblPets2 != null)
        {
            lblPets2.Text = $"Selecionou: {selectedRaioButton.Value}";
            lblPets2.FontSize = 20;
        }
    }

    private async void SearchBar_SearchButtonPressed(object sender, EventArgs e)
    {
        SearchBar searchBar = (SearchBar)sender;
        await DisplayAlert("Pesquisa", $"Você pesquisou por: {searchBar.Text}", "OK");
    }

    private void SwipeItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("SwipeView", $"Elemento tocado", "OK");
    }
}