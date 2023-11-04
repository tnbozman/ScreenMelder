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

        public static object Validate(string input, DataType dataType)
        {
            if(dataType == DataType.BOOLEAN) {
                bool result;
                if (Boolean.TryParse(Regex.Replace(input, @"^(? !true$| false$).*", ""), out result))
                {
                    
                    return result;
                }
            }else if(dataType == DataType.STRING)
            {
                return input;
            }else if(dataType == DataType.FLOAT)
            {
  
                float result;
                if(float.TryParse(Regex.Replace(input, @"[^\d.-]+", ""), out result))
                {

                    return (input.ToLower().Contains("l") ? result * -1 : result);
                }
            }else if(dataType == DataType.INTEGER)
            {
                int result;
                if (int.TryParse(Regex.Replace(input, @"[^\d.-]+", ""), out result))
                {
                    return (input.ToLower().Contains("l") ? result * -1 : result);
                }
            }

            return null;
        }


    }
}
