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
        private readonly string? CONFIG_PATH;

        public ConfigModel? Config { get; set; }

        public ConfigManager() 
        { 
            string? directoryName = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
            if(!string.IsNullOrEmpty(directoryName))
                CONFIG_PATH = Path.Combine(directoryName, "Config.json");
        }

        public void Load()
        {
            if(string.IsNullOrEmpty(CONFIG_PATH))
                throw new Exception("Config could not be found in output directory");
            
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
