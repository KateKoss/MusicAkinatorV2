﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using MusicAkinatorV2.Interfaces;

namespace MusicAkinatorV2.Services
{
    public class FindSongService : IFindSongService
    {
        private readonly IConfiguration _config;

        private readonly HttpClient _client = new HttpClient();
        public FindSongService(IConfiguration config)
        {
            _config = config;
        }

        public async Task<string> GetSongByLirycsAsync(string lirycs)
        {
            var auddioUrl = _config.GetValue<string>("AuddioUrl");
            return await _client.GetStringAsync(auddioUrl + "findLyrics/?q=" + lirycs);
            var responceMessage2 = await _client.GetAsync(auddioUrl + "findLyrics/?q=" + lirycs);
        }
        public string GetSongByAudio(byte[] audio)
        {
            throw new NotImplementedException();
        }
    }
}
