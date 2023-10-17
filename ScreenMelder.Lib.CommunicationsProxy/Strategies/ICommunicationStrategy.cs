using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenMelder.Lib.CommunicationsProxy.Strategies
{
    public interface ICommunicationStrategy
    {
        Task SendJsonAsync(string json);
    }
}
