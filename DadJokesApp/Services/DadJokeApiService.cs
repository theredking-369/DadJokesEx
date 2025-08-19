using DadJokesApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DadJokesApp.Services
{
    public class DadJokeApiService
    {
        private HttpClient _httpClient;

        public DadJokeApiService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<Joke> GetDadJoke()
        {
            string url = "https://icanhazdadjoke.com/";
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            string response = await _httpClient.GetStringAsync(url);

            Joke joke = JsonConvert.DeserializeObject<Joke>(response);

            return joke;
        }
    }
}
