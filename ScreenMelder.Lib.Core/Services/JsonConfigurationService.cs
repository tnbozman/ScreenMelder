﻿using ScreenMelder.Lib.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json;
using System.Threading.Tasks;

namespace ScreenMelder.Lib.Core.Services
{
    public class JsonConfigurationService : IConfigurationService
    {
             
        public Config ReadConfig(string path)
        {
            var jsonString = File.ReadAllText(path);
            return JsonSerializer.Deserialize<Config>(jsonString, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }

        public void SaveConfig(Config config, string path)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,  // This makes the JSON output formatted nicely
            };

            string jsonString = JsonSerializer.Serialize(config, options);
            File.WriteAllText(path, jsonString);
        }
    }
}