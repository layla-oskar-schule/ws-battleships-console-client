using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClient.Configuration
{
    public class ConfigModel
    {
        public string ApiUrl { get; set; }

        public string Type { get; set; }

        public ConfigModel(string apiUrl, string type)
        {
            ApiUrl = apiUrl;
            Type = type;
        }
    }
}
