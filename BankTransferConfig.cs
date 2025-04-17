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

        public BankTransferConfig ReadConfigFile()
        {
            String configJsonData = File.ReadAllText("D:\\modul8_103022300143\\bank_transfer_config.json");
            config = JsonSerializer.Deserialize<BankTransferConfig>(configJsonData);
            return config;
        }
    }
}
