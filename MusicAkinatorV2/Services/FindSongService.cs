using System;
using System.Threading.Tasks;
using MusicAkinatorV2.Interfaces;

namespace MusicAkinatorV2.Services
{
    public class FindSongService : IFindSongService
    {
        private IAuddioService _auddioService;
        private IDeezerService _deezerService;

        public FindSongService(IAuddioService auddioService, IDeezerService deezerService)
        {
            _auddioService = auddioService;
            _deezerService = deezerService;
        }

        public async Task<string> GetSongByLirycsAsync(string lirycs)
        {
            var auddioResponse = await _auddioService.GetSongInfoByLirycs(lirycs);
            var songUrl = await _deezerService.GetSongUrl(auddioResponse.Artist, auddioResponse.Title);
            return songUrl;
        }

        public string GetSongByAudio(byte[] audio)
        {
            throw new NotImplementedException();
        }
    }
}
