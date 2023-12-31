﻿using ScreenMelder.Lib.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System.IO;

namespace ScreenMelder.Lib.Core.Services
{
    public class JsonConfigurationService : IConfigurationService
    {
        private readonly ILogger<JsonConfigurationService> _logger;

        public JsonConfigurationService(ILogger<JsonConfigurationService> logger)
        {
            _logger = logger;
        }

        public string ReadConfigToString(string path)
        {
            return File.ReadAllText(path);
        }

        public void SaveConfigFromString(string jsonString, string path)
        {
            var result = JsonStringToConfig(jsonString);
            if (result != null)
            {
                File.WriteAllText(path, jsonString);
            }
        }

        private Config? JsonStringToConfig(string jsonString)
        {
            Config? result = null;
            try
            {

                result = JsonSerializer.Deserialize<Config>(jsonString, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to parse json string to config", ex);
            }

            return result;
        }

        public Config? ReadConfig(string path)
        {
            _logger.LogInformation($"Reading configuration {path}");
            
            
            var jsonString = ReadConfigToString(path);
            Config? result = JsonStringToConfig(jsonString);
            if (result == null)
            {
                _logger.LogWarning($"Config is empty ({path})");
            }

            return result;


        }

        public void SaveConfig(Config config, string path)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,  // This makes the JSON output formatted nicely
            };

            try
            {
                string jsonString = JsonSerializer.Serialize(config, options);
                File.WriteAllText(path, jsonString);
                _logger.LogInformation($"Configuration saved ({path})");
            }
            catch (Exception ex)
            {
                _logger.LogError("Configuration saved failed", ex);
            }
            
        }

        
    }
}
