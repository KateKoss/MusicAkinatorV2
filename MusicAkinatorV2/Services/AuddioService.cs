using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using MusicAkinatorV2.Interfaces;
using MusicAkinatorV2.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MusicAkinatorV2.Services
{
    public class AuddioService : BaseRequestingService, IAuddioService
    {
        private readonly HttpClient _client = new HttpClient();
        public AuddioService (IConfiguration config) : base(config)
        {
            ConfigName = "AuddioUrl";
            RequestUrlFormat = "{0}/findLyrics/?q={1}";
        }

        public async Task<AuddioResponseResult> GetSongInfoByLirycs(string lirycs)
        {
            var requestUri = GetRequestUri(lirycs);
            var responce = await _client.GetStringAsync(requestUri);
            var responceJObj = JObject.Parse(responce);
            var t = responceJObj["result"].ToList().First();
            return t.ToObject<AuddioResponseResult>();
        }
    }
}
