using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MusicAkinatorV2.Models;

namespace MusicAkinatorV2.Interfaces
{
    public interface IAuddioService
    {
        Task<AuddioResponseResult> GetSongInfoByLirycs(string lirycs);
    }
}
