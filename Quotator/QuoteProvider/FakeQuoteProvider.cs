namespace Quotator.QuoteProvider
{
    public class FakeQuoteProvider : IQuoteProvider
    {
        public string GetRandomQuote()
        {
            return "This is fake quote";
        }
    }
}