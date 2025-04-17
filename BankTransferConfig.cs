using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul8_103022300143
{
    internal class BankTransferConfig
    {
        public class Config
        {
            public string lang { get; set; }
            public class transfer
            {
                public int threshold { get; set; }
                public int low_fee { get; set; }
                public int high_fee { get; set; }
            }

            public List<string> methods { get; set; }

            public class confirmation
            {
                public string en { get; set; }
                public string id { get; set; }
            }
        }

        public Config config;

        public BankTransferConfig ReadConfigFile()
        {
            String configJsonData = File.ReadAllText("D:\\modul8_103022300143\\bank_transfer_config.json");
            return JsonSerializer.Deserialize<BankTransferConfig>(configJsonData);
        }
        public void setdefault()
        {
            config = new Config();
            config.lang = "en";
        }

        public void WriteNewConfigFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            String jsonString = JsonSerializer.Serialize(config, options);
            File.WriteAllText("D:\\modul8_103022300143\\bank_transfer_config.json", jsonString);
        }

        public BankTransferConfig()
        {
            try
            {
                ReadConfigFile();
            }
            catch (Exception)
            {
                setdefault();
                WriteNewConfigFile();
            }
        }

    }
}
