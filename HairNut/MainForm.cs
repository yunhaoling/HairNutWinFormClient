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

namespace HairNut
{
    public partial class MainForm : Form
    {
        private OpenFileDialog openFileDialog;

        public MainForm()
        {
            InitializeComponent();
            openFileDialog = new OpenFileDialog();
        }

        private void BtnLoadPortrait_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sr = new StreamReader(openFileDialog.FileName);
                }
                catch (SecurityException ex)
                {
                }
            }
        }
    }
}
