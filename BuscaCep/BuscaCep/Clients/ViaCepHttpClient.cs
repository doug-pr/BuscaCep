using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BuscaCep.Clients
{
    class ViaCepHttpClient
    {
        private static Lazy<ViaCepHttpClient> _Lazy = new Lazy<ViaCepHttpClient>(() => new ViaCepHttpClient());

        public static ViaCepHttpClient Current { get => _Lazy.Value; }

        private ViaCepHttpClient()
        {
            _HttpClient = new HttpClient();
        }

        private readonly HttpClient _HttpClient;

        public async Task<string> BuscarCep(string cep)
        {
            try
            {
                if(string.IsNullOrWhiteSpace(cep))
                    throw new InvalidOperationException("CEP deve ser informado!");

                using (var response = await _HttpClient.GetAsync($"http://viacep.com.br/ws/{cep}/json/"))
                {
                    if (!response.IsSuccessStatusCode)
                        throw new InvalidOperationException("Erro na consulta do CEP!");

                    return await response.Content.ReadAsStringAsync();

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
