using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairNut
{
    public partial class WaitForm : Form
    {
        public WaitForm()
        {
            InitializeComponent();
            label2.Text = "Hold on. We're processing your image, it would take several minutes.";
        }
    }
}
