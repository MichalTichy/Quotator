using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Quotator.QuoteProvider;

namespace Quotator
{
    public partial class Quotator : Form
    {
        public IQuoteProvider QuoteProvider { get; set; }
        public Quotator()
        {
            InitializeComponent();

            QuoteProvider = AppSettings.GetQuoteProvider();
            quoteTimer.Interval = AppSettings.QuoteShowDelay;
            AppSettings.StartAtStartup(true);

            quoteTimer.Start();
        }

        private void quoteTimer_Tick(object sender, EventArgs e)
        {
            ShowQuote();
        }

        private void autoHideTimer_Tick(object sender, EventArgs e)
        {
            HideQuote();
        }

        private void labQuote_Click(object sender, EventArgs e)
        {
            this.FadeOut(0);
            Pause();
        }

        private void ShowQuote()
        {
            var quote = QuoteProvider.GetRandomQuote();
            labQuote.Text = quote;

            SetupQuoteAutoHide(quote);
            quoteTimer.Start();
            
            ResizeForm();
            MoveForm();
            this.FadeIn();
        }
        private void HideQuote()
        {
            this.FadeOut();
        }

        private void SetupQuoteAutoHide(string quote)
        {
            autoHideTimer.Interval = CalculateAutoHideDelay(quote);
            autoHideTimer.Start();
        }

        /// <summary>
        /// Calculates how long should be quote shown based on average reading speed.
        /// </summary>
        /// <returns>
        /// AutoHide delay in ms
        /// </returns>
        public int CalculateAutoHideDelay(string quote)
        {
            var charCount = quote.Length;

            //average reading speed is 1000 chars/minute
            var neededTime = (int) ((double) charCount / 1000 * 60)*1000;
            return neededTime + 3000;
        }

        public void MoveForm()
        {
            var screen = Screen.PrimaryScreen;
            Left = screen.Bounds.Width - Width-50;
            Top = screen.Bounds.Bottom - Height;
        }

        public void ResizeForm()
        {
            Size = labQuote.Size;
        }

        public void Pause(int minutes = 60)
        {
            quoteTimer.Stop();
            Thread.Sleep(minutes);
            quoteTimer.Start();
        }

        //This ensures that window will be allways on top
        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        private void Quotator_Load(object sender, EventArgs e)
        {
            SetWindowPos(Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
        }
    }
}
