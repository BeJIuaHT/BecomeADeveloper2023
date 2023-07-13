using System;
using System.Windows.Forms;

namespace BecomeADeveloper2023
{
    internal static class Program
    {
        /// <summary>
        /// Тестеве завдання для BecomeADeveloper2023
        /// Алгоритм дивитіся у классі FirstUniqChar
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MyApp());
        }
    }
}
