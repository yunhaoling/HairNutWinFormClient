using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace HairNut
{
    public partial class MainForm : Form
    {
        private OpenFileDialog openFileDialog;
        private string imageFilePath;
        private string pythonExecPath;
        private ScriptRunner scriptRunner;
        
        enum HairStyle
        {
            Bang = 0,
            Wavy,
            Straight,
            Bald
        }

        public MainForm()
        {
            InitializeComponent();
            openFileDialog = new OpenFileDialog();
            pythonExecPath = ConfigurationManager.AppSettings["PythonEnvPath"];
            scriptRunner = new ScriptRunner();
        }

        private void BtnLoadPortrait_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imageFilePath = openFileDialog.FileName;
                imageBefore.Image = Image.FromFile(imageFilePath);
            }
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            string args = "";
            args += "--input " + this.imageFilePath;
            args += " ";
            args += "--style " + ((int)HairStyle.Bang).ToString();
            scriptRunner.runPythonScript(pythonExecPath, ConfigurationManager.AppSettings["ScriptPath"], args);
        }

        private void btnWavy_Click(object sender, EventArgs e)
        {

        }

        private void btnStraight_Click(object sender, EventArgs e)
        {

        }

        private void btnBald_Click(object sender, EventArgs e)
        {

        }

        private void btnSavePortrait_Click(object sender, EventArgs e)
        {

        }

        private void scrollBarAdjust_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
