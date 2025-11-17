
using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
		public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto { Descricao = "Suíte Super Luxo", ValorDiariaAdulto = 110.00, ValorDiariaCrianca = 55.00 },
            new Quarto { Descricao = "Suíte Luxo", ValorDiariaAdulto = 80.00, ValorDiariaCrianca = 40.00 },
            new Quarto { Descricao = "Suíte Single", ValorDiariaAdulto = 50.00, ValorDiariaCrianca = 30.00 }
        };
        		

		public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratatacaoHospedagem());
        }

		
    }
}
