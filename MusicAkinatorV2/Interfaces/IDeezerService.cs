using System.Threading.Tasks;

namespace MusicAkinatorV2.Interfaces
{
    public interface IDeezerService
    {
        Task<string> GetSongUrl(string artist, string songName);
    }
}
