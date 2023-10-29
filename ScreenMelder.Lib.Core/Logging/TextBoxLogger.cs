using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenMelder.Lib.Core.Logging
{
    public class TextBoxLogger : ILogger
    {
        private readonly TextBox textBox;

        public TextBoxLogger(TextBox textBox)
        {
            this.textBox = textBox;
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            // You can adjust the log level as needed
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            if (!IsEnabled(logLevel))
            {
                return;
            }

            var message = formatter(state, exception);

            LogToTextBox(message + Environment.NewLine);

        }

        public void LogToTextBox(string message)
        {
            if (textBox.InvokeRequired)
            {
                // We're not on the UI thread, so we need to invoke the update
                textBox.Invoke((Action)(() =>
                {
                    textBox.AppendText(message);
                }));
            }
            else
            {
                // We're on the UI thread, so we can directly update the TextBox
                textBox.AppendText(message);
            }
        }


    }
}
