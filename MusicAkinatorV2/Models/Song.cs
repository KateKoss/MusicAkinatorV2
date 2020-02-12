﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicAkinatorV2.Models
{
    public class Song
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public bool Lirycs { get; set; }
    }

    public class AuddioResponse
    {
        public string Status { get; set; } 
        public AuddioResponseResult Result { get; set; }
    }

    public class AuddioResponseResult
    {
        public string Title { get; set; }
        public string Artist { get; set; }
    }
}
