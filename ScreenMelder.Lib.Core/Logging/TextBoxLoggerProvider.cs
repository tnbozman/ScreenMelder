using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenMelder.Lib.Core.Logging
{
    public class TextBoxLoggerProvider : ILoggerProvider
    {
        private readonly TextBox textBox;

        public TextBoxLoggerProvider(TextBox textBox)
        {
            this.textBox = textBox;
        }

        public ILogger CreateLogger(string categoryName)
        {
            return new TextBoxLogger(textBox);
        }

        public void Dispose()
        {
            // Clean up resources if needed
        }
    }
}
