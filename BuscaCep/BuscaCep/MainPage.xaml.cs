using BuscaCep.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BuscaCep
{
	public partial class Page : ContentPage
	{
		public Page()
		{
			InitializeComponent();
		}

        private async void BtnBuscarCep_Clicked(object sender, EventArgs e)
        {
            try
            {
                var result = await ViaCepHttpClient.Current.BuscarCep(txtCep.Text);

                if (!string.IsNullOrWhiteSpace(result))
                    await DisplayAlert("CEP Consultado:", result, "Ok");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro!", ex.Message, "Ok");
            }
        }
	}
}
