using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MusicAkinatorV2.Interfaces;
using MusicAkinatorV2.Models;

namespace MusicAkinatorV2.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class SongController : ControllerBase
    {
        
        private readonly IFindSongService _findSongService;
        public SongController(IFindSongService findSongService)
        {
            _findSongService = findSongService;
        }

        [HttpGet("{lirycs}")]
        public async Task<ActionResult<string>> GetSong(string lirycs)
        {
            return await _findSongService.GetSongByLirycsAsync(lirycs);
        }
    }
}