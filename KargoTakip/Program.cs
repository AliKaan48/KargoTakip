using KargoTakip;
using System;
using System.Windows.Forms;

namespace Sistemi
{
    static class Program
    {
        /// Uygulamanın ana giriş noktası.
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //  Hangi formun önce açılacağını burası belirler.
            Application.Run(new Giris());
        }
    }
}
