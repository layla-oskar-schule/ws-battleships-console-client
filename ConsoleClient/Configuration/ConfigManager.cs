using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClient.Configuration
{
    public class ConfigManager
    {
        private readonly string CONFIG_PATH = Path.Combine(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory), "Config.json");

        public ConfigModel Config { get; set; }

        public ConfigManager() 
        { 
            Config = new ConfigModel();
        }

        public void Load()
        {
            using (StreamReader r = new StreamReader(CONFIG_PATH))
            {
                string json = r.ReadToEnd();
                ConfigModel? config = JsonConvert.DeserializeObject<ConfigModel>(json);
                if (config == null) return;
                Config = config;
            }
        }

    }
}
