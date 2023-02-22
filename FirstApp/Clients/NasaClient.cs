using System.Net.Http.Json;
using FirstApp.Models;

namespace FirstApp.Clients;
    public class NasaClient{

        private readonly HttpClient _client;

        public NasaClient(HttpClient client){
            _client = client;
        } 
        public async Task<NasaResponse> GetNasa(){
            return await _client.GetFromJsonAsync<NasaResponse>("https://api.nasa.gov/planetary/apod?api_key=IZ2T38wTGwOcpdfVyVOwu5allViUb5bvQ5DZEhOb");
        }
        public async Task<NasaResponse> GetDate(DateTime newDate ){
            return await _client.GetFromJsonAsync<NasaResponse>("https://api.nasa.gov/planetary/apod?date=newDate");
        }
    }
