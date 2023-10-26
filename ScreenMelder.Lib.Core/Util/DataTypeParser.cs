using ScreenMelder.Lib.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ScreenMelder.Lib.Core.Util
{
    public class DataTypeParser
    {

        public static string Validate(string input, DataType dataType)
        {
            if(dataType == DataType.BOOLEAN) {
                bool result;
                input = Regex.Replace(input, @"^(? !true$| false$).*", "");
                if (Boolean.TryParse(input, out result))
                {
                    
                    return result.ToString();
                }
            }else if(dataType == DataType.STRING)
            {
                return input;
            }else if(dataType == DataType.FLOAT)
            {
                input = Regex.Replace(input, @"[^\d.-]+", "");
                float result;
                if(float.TryParse(input, out result))
                {
                    return result.ToString();
                }
            }else if(dataType == DataType.INTEGER)
            {
                int result;
                input = Regex.Replace(input, @"[^\d.-]+", "");
                if (int.TryParse(input, out result))
                {
                    return result.ToString();
                }
            }

            return null;
        }


    }
}
