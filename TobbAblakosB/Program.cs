using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TobbAblakosB
{
static class Program
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>

    public static MainForm mainForm;
    public static Laptop laptop;
    public static Asztali asztali;
        
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        mainForm = new MainForm();
        laptop = new Laptop();
        asztali = new Asztali();
        Application.Run(mainForm);
    }
}
}
