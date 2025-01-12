using System.Text.Json;
using app.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex093
    {
        public void TestaAPi()
        {
            RequestParaApi();
        }


        static async Task RequestParaApi()
        {

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("https://dog.ceo/api/breeds/image/random");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                // Deserializa o JSON para um objeto dinâmico
                var jsonDocument = JsonDocument.Parse(responseBody);

                // Formata e exibe o JSON de forma legível
                string formattedJson = JsonSerializer.Serialize(jsonDocument.RootElement, new JsonSerializerOptions { WriteIndented = true });
                Console.WriteLine(formattedJson);

            }

        }
    }
}