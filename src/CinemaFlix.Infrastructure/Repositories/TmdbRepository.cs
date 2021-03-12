using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace CinemaFlix.Infrastructure.Repositories
{
    public class TmdbRepository
    {
        private readonly HttpClient _httpClientFactory;

        public TmdbRepository()
        {
            _httpClientFactory = new HttpClient();
        }

        public async Task GetMovies()
        {

            var request = new HttpRequestMessage
            {
                RequestUri = new Uri("https://api.themoviedb.org/3/movie/14?api_key=69e6d6b556de36796cf916ccd4de6cd0"),
                Method = HttpMethod.Get
            };

            using var response = await _httpClientFactory.SendAsync(request);

            var stream = await response.Content.ReadAsStreamAsync();
            
            //TODO: concluir implementação da requisição quando as entidades estiverem criadas.
            //if (response.IsSuccessStatusCode)
                //return await JsonSerializer.DeserializeAsync<Movie>(stream);

        }
    }
}
