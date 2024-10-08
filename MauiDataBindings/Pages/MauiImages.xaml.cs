
using System.Text.Json;

namespace MauiDataBindings.Pages;

public partial class MauiImages : ContentPage
{
    Pessoa pessoa;
	public MauiImages()
	{
		InitializeComponent();
	}

   protected override async void OnAppearing()
    {
        base.OnAppearing();

        await LoadMauiAsset();
    }
    public async Task LoadMauiAsset()
    {
        using var stream = await FileSystem.OpenAppPackageFileAsync("demo.json");
        using var reader = new StreamReader(stream);

        var contents = await reader.ReadToEndAsync();

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
        var pessoas = JsonSerializer.Deserialize<List<Pessoa>>(contents, options);

        if (pessoas != null && pessoas.Count > 0)
        {
            pessoa = pessoas[0];
        }

        BindingContext = pessoa;
    }


}

public class Pessoa
{
    public string Nome { get; set; }

    public int Idade { get; set; }

    public string Foto { get; set; }
}
