using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ScreenMelder.Lib.CommunicationsProxy.Utils
{
    public class PayloadUtils
    {
        public static bool IsValidJson(string jsonString, out string unprettyJsonString, string regex)
        {
            try
            {
                // Attempt to parse the JSON string into a JsonDocument
                using (JsonDocument document = JsonDocument.Parse(jsonString))
                {
                    // Convert it back to a JSON string without formatting
                    unprettyJsonString = document.RootElement.ToString();
                    // Remove all pretty formatting special characters (whitespace, tabs, newlines)
                    //unprettyJsonString = Regex.Replace(unprettyJsonString, @"[\t\n\r]", "");
                    if (regex != null)
                    {
                        unprettyJsonString = Regex.Replace(unprettyJsonString, regex, "");
                    }
                    
                    return true;
                }
            }
            catch (JsonException)
            {
                // Parsing failed, so it's not valid JSON
                unprettyJsonString = null;
                return false;
            }
        }
    }
}
