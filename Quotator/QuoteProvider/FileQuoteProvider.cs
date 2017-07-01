using System;
using System.IO;
using System.Windows.Forms;

namespace Quotator.QuoteProvider
{
    /// <summary>
    /// Provides quotes from quote.txt file stored in the same folder as application.
    /// </summary>
    public class FileQuoteProvider : IQuoteProvider
    {
        private readonly string filePath;

        protected static Random random=new Random(DateTime.Now.Millisecond);

        public FileQuoteProvider(string filePath)
        {
            this.filePath = filePath;
        }
        
        /// <inheritdoc />
        public string GetRandomQuote()
        {
            var quotes = File.ReadAllLines(filePath);
            return quotes[random.Next(0, quotes.Length - 1)];
        }
    }
}