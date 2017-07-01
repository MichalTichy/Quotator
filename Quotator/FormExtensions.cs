using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quotator
{
    public static class FormExtensions
    {

        public static async void FadeIn(this Form form, int interval = 80)
        {
            if (interval == 0)
            {
                form.Opacity = 1;
                return;
            }
            //Object is not fully invisible. Fade it in
            while (form.Opacity < 1.0)
            {
                await Task.Delay(interval);
                form.Opacity += 0.05;
            }
            form.Opacity = 1; //make fully visible       
        }

        public static async void FadeOut(this Form form, int interval = 80)
        {
            if (interval == 0)
            {
                form.Opacity = 0;
                return;
            }

            //Object is fully visible. Fade it out
            while (form.Opacity > 0.0)
            {
                await Task.Delay(interval);
                form.Opacity -= 0.05;
            }
            form.Opacity = 0; //make fully invisible       
        }
    }
}