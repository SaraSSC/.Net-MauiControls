using System.Globalization;

namespace MauiControls.Pages;

public partial class MauiSetValueControls : ContentPage
{
	public MauiSetValueControls()
	{
        InitializeComponent();
	}

    private async void Checkbox1_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (e.Value)
        {
            await DisplayAlert("Checkbox", "Checked", "OK");
        }
        else
        {
            await DisplayAlert("Checkbox", "Unchecked", "OK");
        }

    }

    private async void Checkbox2_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (e.Value)
        {
            await DisplayAlert("Checkbox", "Checked", "OK");
        }
        else
        {
            await DisplayAlert("Checkbox", "Unchecked", "OK");
        }
    }

    private async void Checkbox3_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (e.Value)
        {
            await DisplayAlert("Checkbox", "Checked", "OK");
        }
        else
        {
            await DisplayAlert("Checkbox", "Unchecked", "OK");
        }
    }

    private void slider1_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        double valor = Math.Round(slider1.Value, 2);
        lblSlider.Text = valor.ToString();
    }

    private void stepper1_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        double value = e.NewValue;
        lblStepper.Text = string.Format($"Valor do Stepper {value}");
    }

    private async void switch1_Toggled(object sender, ToggledEventArgs e)
    {
        if (e.Value)
        {
            await DisplayAlert("Switch", "On", "OK");
        }
        else
        {
            await DisplayAlert("Switch", "Off", "OK");
        }
    }

    private async void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {
        CultureInfo culture = new CultureInfo("pt-BR");
        var data = ((DatePicker)sender).Date;
        var dataSelecionada = data.ToString("d", culture);
        await DisplayAlert("Data Selecionada", dataSelecionada, "OK");
    }

    private async void timer1_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (timer1 != null)
        {
            var horaSelecionada = timer1.Time.ToString(@"hh\:mm");
            await DisplayAlert("Hora Selecionada", horaSelecionada, "OK");
        }
    }
}