using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicAkinatorV2.Interfaces
{
    public interface IFindSongService
    {
        Task<string> GetSongByLirycsAsync(string lirycs);
        string GetSongByAudio(byte[] audio);
    }
}
