using EcoConnectFrontend.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace EcoConnectFrontend.Services
{
    public class InstitutionService
    {
        private readonly HttpClient _httpClient;

        public InstitutionService()
        {
            _httpClient = new HttpClient { BaseAddress = new Uri("http://localhost:3000/") };
        }

        public async Task<List<Institution>> GetInstitutionsAsync()
        {
            var response = await _httpClient.GetStringAsync("institutions");
            return JsonSerializer.Deserialize<List<Institution>>(response);
        }

        // Métodos para agregar, editar y eliminar instituciones
    }
}
