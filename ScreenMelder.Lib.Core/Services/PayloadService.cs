using ScreenMelder.Lib.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json;
using System.Threading.Tasks;

namespace ScreenMelder.Lib.Core.Services
{
    public class PayloadService: IPayloadService
    {

        public string PopulateTemplateWithRegions(string templatePath, List<RoiConfig> regions, Dictionary<string, string> ocrValues)
        {
            var template = LoadTemplate(templatePath);

            foreach (var region in regions)
            {
                if (ocrValues.ContainsKey(region.Label))
                {
                    // Assuming each RegionConfig has a property 'Value' you want to substitute into the template
                    // Replace this with whatever value or property you want from RegionConfig
                    SubstituteValueInTemplate(template, region.Label, ocrValues[region.Label]);
                }
            }

            return SaveTemplate(template, templatePath);
        }
        private JsonNode LoadTemplate(string templatePath)
        {
            var jsonString = File.ReadAllText(templatePath);
            return JsonNode.Parse(jsonString);
        }


        private string SaveTemplate(JsonNode template, string outputPath)
        {
            string jsonString = template.ToJsonString(new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(outputPath, jsonString);
            return jsonString;
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
