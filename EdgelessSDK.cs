using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdgelessSDK
{
    public partial class EdgelessSDK : Form
    {
        public EdgelessSDK()
        {
            InitializeComponent();
        }
    }

    internal static class Program
    {
        
        static void Main(string[] args)
        {
            new Launcher().LaunchGUI();
        }
    }
   
    internal class Launcher
    {
        [STAThread]
        public void LaunchGUI()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EdgelessSDK());
        }
    }
}
