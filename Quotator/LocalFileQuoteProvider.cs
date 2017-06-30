using System;
using System.IO;
using System.Windows.Forms;

namespace Quotator
{
    /// <summary>
    /// Provides quotes from quote.txt file stored in the same folder as application.
    /// </summary>
    public class LocalFileQuoteProvider : IQuoteProvider
    {
        protected static Random random=new Random(DateTime.Now.Millisecond);
        
        protected virtual string GetFilePath()
        {
            return $"{Path.GetDirectoryName(Application.ExecutablePath)}/quotes.txt";
        }
        
        /// <inheritdoc />
        public string GetRandomQuote()
        {
            var quotes = File.ReadAllLines(GetFilePath());
            return quotes[random.Next(0, quotes.Length - 1)];
        }
    }
}