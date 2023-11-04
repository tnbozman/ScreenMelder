using ScreenMelder.Lib.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json;
using System.Threading.Tasks;
using System.Drawing;
using ScreenMelder.Lib.Core.Util;
using System.Text.Encodings.Web;
using Microsoft.Extensions.Logging;
using System.Runtime.CompilerServices;

namespace ScreenMelder.Lib.Core.Services
{
    public class PayloadService: IPayloadService
    {
        private readonly ILogger _logger;
        private JsonNode jsonTemplate { get; set; }

        public PayloadService(ILogger<PayloadService> logger) {
            jsonTemplate = null;
            _logger = logger;
        } 

        public string Load(string templatePath)
        {
            if(jsonTemplate == null)
            {
                _logger.LogInformation($"Loading payload template ({templatePath})");
                jsonTemplate = LoadTemplate(templatePath);
                _logger.LogInformation($"Loaded payload template");
            }
            return TemplateToString(jsonTemplate);


        }

        public bool Save(string templatePath, string jsonString) {
            try
            {
                jsonTemplate = StringToJson(jsonString);
                SaveTemplate(TemplateToString(jsonTemplate), templatePath);
                return true;
            }catch (Exception ex)
            {
                _logger.LogError("Failed to save", ex);
                return false;
            }
            
        }

        public void Save(string templatePath)
        {
            if(jsonTemplate != null)
            {
                _logger.LogInformation($"Saving payload template ({templatePath})");
                SaveTemplate(TemplateToString(jsonTemplate), templatePath);
                _logger.LogInformation($"Saved payload template");
            }
        }

        public string AddCounterToTemplate(string captureCountLabel, int count)
        {
            SubstituteValueInTemplate(jsonTemplate, captureCountLabel, count);
            return TemplateToString(jsonTemplate);
        }

        public string PopulateTemplateWithRegions(string templatePath, List<RoiConfig> regions, Dictionary<string, object> ocrValues)
        {
            Load(templatePath);

            foreach (var region in regions)
            {
                if (ocrValues.ContainsKey(region.Label))
                {
                    // Assuming each RegionConfig has a property 'Value' you want to substitute into the template
                    // Replace this with whatever value or property you want from RegionConfig
                    SubstituteValueInTemplate(jsonTemplate, region.Label, ocrValues[region.Label]);
                }
            }

            return TemplateToString(jsonTemplate);
        }
        private JsonNode LoadTemplate(string templatePath)
        {
            var jsonString = File.ReadAllText(templatePath);
            return StringToJson(jsonString);
        }

        private JsonNode StringToJson(string jsonString)
        {

            return JsonNode.Parse(jsonString);
        }

        private string TemplateToString(JsonNode template)
        {
            return template.ToJsonString(new JsonSerializerOptions { WriteIndented = true, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping });
        }

        private string SaveTemplate(string template, string outputPath)
        {
            // https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/character-encoding
            File.WriteAllText(outputPath, template);
            return template;
        }

        private void SubstituteValueInTemplate(JsonNode template, string keyPath, object value)
        {
            var keys = keyPath.Split('.');
            JsonNode currentNode = template;

            for (int i = 0; i < keys.Length - 1; i++)
            {
                if (currentNode is JsonObject currentObj && currentObj.ContainsKey(keys[i]))
                {
                    currentNode = currentObj[keys[i]];
                }
                else
                {
                    throw new ArgumentException($"Key path {keyPath} does not exist in the template.");
                }
            }

            if (currentNode is JsonObject finalObject)
            {
                finalObject[keys[^1]] = JsonValue.Create(value);
            }
            else
            {
                throw new ArgumentException($"Key path {keyPath} does not lead to a valid substitution point in the template.");
            }
        }
    }
}
