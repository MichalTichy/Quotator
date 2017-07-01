using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using Quotator.QuoteProvider;

namespace Quotator
{
    public static class AppSettings
    {

        /// <summary>
        /// Delay before quote is shown in MS.
        /// </summary>
        public static int QuoteShowDelay
        {
            get
            {
#if DEBUG
                return 10000;
#endif
                // 1 hour
                return 60 * 60 * 1000; ;
                
            }
        }

        public static IQuoteProvider GetQuoteProvider()
        {
            IQuoteProvider fileQuoteProvider;

#if !DEBUG
            var path = $"{Path.GetDirectoryName(Application.ExecutablePath)}/quotes.txt";
            fileQuoteProvider = new FileQuoteProvider(path);            
#endif

#if DEBUG
            fileQuoteProvider=new FakeQuoteProvider();
#endif


            return fileQuoteProvider;
        }

        public static void StartAtStartup(bool startAtStartup)
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey
                ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (startAtStartup)
                registryKey.SetValue("Quotator", Application.ExecutablePath);
            else
                registryKey.DeleteValue("Quotator", false);
        }

    }
}
