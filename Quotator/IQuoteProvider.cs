using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quotator
{
    public interface IQuoteProvider
    {
        string GetRandomQuote();
    }
}
