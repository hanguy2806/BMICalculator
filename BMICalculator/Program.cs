using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    static class Program
    {
        public static BMI_Form bmiForm;
        public static SplashScreen splashScreen;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bmiForm = new BMI_Form();
            splashScreen = new SplashScreen();
            Application.Run(splashScreen);
        }
    }
}
