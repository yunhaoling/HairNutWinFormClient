namespace HairNut
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoadPortrait = new System.Windows.Forms.Button();
            this.btnSavePortrait = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnBang = new System.Windows.Forms.Button();
            this.btnWavy = new System.Windows.Forms.Button();
            this.btnStraight = new System.Windows.Forms.Button();
            this.btnBald = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadPortrait
            // 
            this.btnLoadPortrait.Location = new System.Drawing.Point(32, 305);
            this.btnLoadPortrait.Name = "btnLoadPortrait";
            this.btnLoadPortrait.Size = new System.Drawing.Size(256, 44);
            this.btnLoadPortrait.TabIndex = 0;
            this.btnLoadPortrait.Text = "Load Portrait";
            this.btnLoadPortrait.UseVisualStyleBackColor = true;
            this.btnLoadPortrait.Click += new System.EventHandler(this.BtnLoadPortrait_Click);
            // 
            // btnSavePortrait
            // 
            this.btnSavePortrait.Location = new System.Drawing.Point(403, 305);
            this.btnSavePortrait.Name = "btnSavePortrait";
            this.btnSavePortrait.Size = new System.Drawing.Size(256, 44);
            this.btnSavePortrait.TabIndex = 1;
            this.btnSavePortrait.Text = "Save Portrait";
            this.btnSavePortrait.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(32, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(403, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(256, 256);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btnBang
            // 
            this.btnBang.Location = new System.Drawing.Point(308, 26);
            this.btnBang.Name = "btnBang";
            this.btnBang.Size = new System.Drawing.Size(75, 45);
            this.btnBang.TabIndex = 4;
            this.btnBang.Text = "bangs";
            this.btnBang.UseVisualStyleBackColor = true;
            // 
            // btnWavy
            // 
            this.btnWavy.Location = new System.Drawing.Point(308, 98);
            this.btnWavy.Name = "btnWavy";
            this.btnWavy.Size = new System.Drawing.Size(75, 45);
            this.btnWavy.TabIndex = 5;
            this.btnWavy.Text = "wavy";
            this.btnWavy.UseVisualStyleBackColor = true;
            // 
            // btnStraight
            // 
            this.btnStraight.Location = new System.Drawing.Point(308, 164);
            this.btnStraight.Name = "btnStraight";
            this.btnStraight.Size = new System.Drawing.Size(75, 45);
            this.btnStraight.TabIndex = 6;
            this.btnStraight.Text = "straight";
            this.btnStraight.UseVisualStyleBackColor = true;
            // 
            // btnBald
            // 
            this.btnBald.Location = new System.Drawing.Point(308, 237);
            this.btnBald.Name = "btnBald";
            this.btnBald.Size = new System.Drawing.Size(75, 45);
            this.btnBald.TabIndex = 7;
            this.btnBald.Text = "bald";
            this.btnBald.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(665, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Adjust";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(675, 26);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(20, 242);
            this.vScrollBar1.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 379);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBald);
            this.Controls.Add(this.btnStraight);
            this.Controls.Add(this.btnWavy);
            this.Controls.Add(this.btnBang);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSavePortrait);
            this.Controls.Add(this.btnLoadPortrait);
            this.Name = "MainForm";
            this.Text = "Hair Nut Client";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadPortrait;
        private System.Windows.Forms.Button btnSavePortrait;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnBang;
        private System.Windows.Forms.Button btnWavy;
        private System.Windows.Forms.Button btnStraight;
        private System.Windows.Forms.Button btnBald;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}

