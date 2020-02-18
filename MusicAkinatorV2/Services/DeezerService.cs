using MusicAkinatorV2.Interfaces;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace MusicAkinatorV2.Services
{
    public class DeezerService : BaseRequestingService, IDeezerService
    {
        private readonly HttpClient _client = new HttpClient();
        public DeezerService(IConfiguration config) : base(config)
        {
            ConfigName = "DeezerUrl";
            RequestUrlFormat = "{0}/search?q=artist:\"{1}\" track:\"{2}\"";
        }

        public async Task<string> GetSongUrl(string artist, string songName)
        {
            var requestUri = GetRequestUri(artist, songName);
            var response = await _client.GetAsync(requestUri);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            return string.Empty;
        }
    }
}
