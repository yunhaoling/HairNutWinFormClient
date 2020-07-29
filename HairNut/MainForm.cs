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
using System.Drawing.Imaging;

namespace HairNut
{
    public partial class MainForm : Form
    {
        private OpenFileDialog openFileDialog;
        private string imageFilePath;
        private string pythonExecPath;
        private List<Image> generatedImages;
        private ScriptRunner scriptRunner;
        private int generatedImagesCount;
        private int selectedImageIdx;
        
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
            this.scrollBarAdjust.Enabled = false;
        }

        private void BtnLoadPortrait_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imageFilePath = openFileDialog.FileName;
                imageBefore.Image = Image.FromFile(imageFilePath);
            }
        }

        private void loadGeneratedImages()
        {
            this.generatedImages = new List<Image>();
            var files = Directory.GetFiles(ConfigurationManager.AppSettings["GeneratedImagesDir"]);
            foreach (var file in files)
            {
                this.generatedImages.Add(Image.FromFile(file));
            }
            this.generatedImagesCount = this.generatedImages.Count;
            this.scrollBarAdjust.Maximum = this.generatedImages.Count + scrollBarAdjust.LargeChange - 2;
            this.scrollBarAdjust.Value = this.generatedImagesCount / 2 - 1;
            this.scrollBarAdjust.Enabled = true;
            this.imageAfter.Image = this.generatedImages[this.scrollBarAdjust.Value];
        }

        private void executePythonScript(HairStyle style)
        {
            Form f = new WaitForm();
            f.Show(this);
            f.Refresh();

            this.Enabled = false;
            string args = "";
            args += "--input " + this.imageFilePath;
            args += " ";
            args += "--style " + ((int)style).ToString();
            Console.WriteLine("Start exectuing scripts with args: {0}", args);
            this.scriptRunner.runPythonScript(pythonExecPath, ConfigurationManager.AppSettings["ScriptPath"], args);
            Console.WriteLine("End exectuing scripts with args: {0}", args);
            this.Enabled = true;

            this.loadGeneratedImages();

            f.Close();
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            this.executePythonScript(HairStyle.Bang);
        }

        private void btnWavy_Click(object sender, EventArgs e)
        {
            this.executePythonScript(HairStyle.Wavy);
        }

        private void btnStraight_Click(object sender, EventArgs e)
        {
            this.executePythonScript(HairStyle.Straight);
        }

        private void btnBald_Click(object sender, EventArgs e)
        {
            this.executePythonScript(HairStyle.Bald);
        }

        private void btnSavePortrait_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images|*.jpg";
            ImageFormat format = ImageFormat.Jpeg;
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(sfd.FileName);
                this.generatedImages[this.selectedImageIdx].Save(sfd.FileName, format);
                MessageBox.Show("Images saved successfully!");
            }
        }

        private void scrollBarAdjust_Scroll(object sender, ScrollEventArgs e)
        {
            this.imageAfter.Image = this.generatedImages[this.scrollBarAdjust.Value];
            this.selectedImageIdx = this.scrollBarAdjust.Value;
        }
    }
}
