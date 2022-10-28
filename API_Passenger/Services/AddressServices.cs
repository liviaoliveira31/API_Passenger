using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace API_Passenger.Services
{
    public class AddressServices
    {

        public AddressServices() { }

        public async Task<String> GetAdress (string cep)
        {
            using (HttpClient _adressClient = new HttpClient())
            {
                HttpResponseMessage response = await _adressClient.GetAsync("https://viacep.com.br/ws/" + cep + "/json/");
                var adress = await response.Content.ReadAsStringAsync();
                return adress;
            }
        }
    }
    
}
