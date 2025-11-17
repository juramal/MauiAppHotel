using Microsoft.Maui.Controls;
using MauiAppHotel.Views;

namespace MauiAppHotel.Views;

public partial class HeaderView : ContentView
{
	public HeaderView()
	{
		InitializeComponent();
	}

	private async void OnContratarClicked(object sender, EventArgs e)
	{
		// Navegar para a página de contratação usando NavigationPage
		if (Application.Current?.MainPage?.Navigation != null)
		{
			await Application.Current.MainPage.Navigation.PushAsync(new ContratatacaoHospedagem());
		}
	}

	private async void OnHospedagensClicked(object sender, EventArgs e)
	{
		// Navegar para a página de hospedagens usando NavigationPage
		if (Application.Current?.MainPage?.Navigation != null)
		{
			await Application.Current.MainPage.Navigation.PushAsync(new HospedagemContratada());
		}
	}

	private async void OnSobreClicked(object sender, EventArgs e)
	{
		// Navegar para a página sobre usando NavigationPage
		if (Application.Current?.MainPage?.Navigation != null)
		{
			await Application.Current.MainPage.Navigation.PushAsync(new Sobre());
		}
	}
}