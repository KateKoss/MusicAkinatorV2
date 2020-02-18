using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Extensions.Configuration;

namespace MusicAkinatorV2.Services
{
    public abstract class BaseRequestingService
    {
        private readonly IConfiguration _config;
        protected string ConfigName { get; set; } = string.Empty;
        public string RequestUrlFormat { get; set; }

        protected BaseRequestingService(IConfiguration config)
        {
            _config = config;
        }

        public virtual string GetRequestUri(params string[] reqParams)
        {
            var auddioUrl = _config.GetValue<string>(ConfigName);
            return string.Format(RequestUrlFormat, new[]{ auddioUrl }.Concat(reqParams).ToArray());
        }
    }
}
