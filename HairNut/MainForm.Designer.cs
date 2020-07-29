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
            this.imageBefore = new System.Windows.Forms.PictureBox();
            this.imageAfter = new System.Windows.Forms.PictureBox();
            this.btnBang = new System.Windows.Forms.Button();
            this.btnWavy = new System.Windows.Forms.Button();
            this.btnStraight = new System.Windows.Forms.Button();
            this.btnBald = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.scrollBarAdjust = new System.Windows.Forms.VScrollBar();
            this.btnRandomDemo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBefore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageAfter)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadPortrait
            // 
            this.btnLoadPortrait.Location = new System.Drawing.Point(32, 305);
            this.btnLoadPortrait.Name = "btnLoadPortrait";
            this.btnLoadPortrait.Size = new System.Drawing.Size(163, 44);
            this.btnLoadPortrait.TabIndex = 0;
            this.btnLoadPortrait.Text = "Load Your Own Portrait";
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
            this.btnSavePortrait.Click += new System.EventHandler(this.btnSavePortrait_Click);
            // 
            // imageBefore
            // 
            this.imageBefore.BackColor = System.Drawing.Color.Transparent;
            this.imageBefore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBefore.Location = new System.Drawing.Point(32, 26);
            this.imageBefore.Name = "imageBefore";
            this.imageBefore.Size = new System.Drawing.Size(256, 256);
            this.imageBefore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBefore.TabIndex = 2;
            this.imageBefore.TabStop = false;
            // 
            // imageAfter
            // 
            this.imageAfter.BackColor = System.Drawing.Color.Transparent;
            this.imageAfter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageAfter.Location = new System.Drawing.Point(403, 26);
            this.imageAfter.Name = "imageAfter";
            this.imageAfter.Size = new System.Drawing.Size(256, 256);
            this.imageAfter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageAfter.TabIndex = 3;
            this.imageAfter.TabStop = false;
            // 
            // btnBang
            // 
            this.btnBang.Location = new System.Drawing.Point(308, 26);
            this.btnBang.Name = "btnBang";
            this.btnBang.Size = new System.Drawing.Size(75, 45);
            this.btnBang.TabIndex = 4;
            this.btnBang.Text = "bangs";
            this.btnBang.UseVisualStyleBackColor = true;
            this.btnBang.Click += new System.EventHandler(this.btnBang_Click);
            // 
            // btnWavy
            // 
            this.btnWavy.Location = new System.Drawing.Point(308, 95);
            this.btnWavy.Name = "btnWavy";
            this.btnWavy.Size = new System.Drawing.Size(75, 45);
            this.btnWavy.TabIndex = 5;
            this.btnWavy.Text = "wavy";
            this.btnWavy.UseVisualStyleBackColor = true;
            this.btnWavy.Click += new System.EventHandler(this.btnWavy_Click);
            // 
            // btnStraight
            // 
            this.btnStraight.Location = new System.Drawing.Point(308, 164);
            this.btnStraight.Name = "btnStraight";
            this.btnStraight.Size = new System.Drawing.Size(75, 45);
            this.btnStraight.TabIndex = 6;
            this.btnStraight.Text = "straight";
            this.btnStraight.UseVisualStyleBackColor = true;
            this.btnStraight.Click += new System.EventHandler(this.btnStraight_Click);
            // 
            // btnBald
            // 
            this.btnBald.Location = new System.Drawing.Point(308, 237);
            this.btnBald.Name = "btnBald";
            this.btnBald.Size = new System.Drawing.Size(75, 45);
            this.btnBald.TabIndex = 7;
            this.btnBald.Text = "bald";
            this.btnBald.UseVisualStyleBackColor = true;
            this.btnBald.Click += new System.EventHandler(this.btnBald_Click);
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
            // scrollBarAdjust
            // 
            this.scrollBarAdjust.Location = new System.Drawing.Point(675, 26);
            this.scrollBarAdjust.Name = "scrollBarAdjust";
            this.scrollBarAdjust.Size = new System.Drawing.Size(20, 256);
            this.scrollBarAdjust.TabIndex = 10;
            this.scrollBarAdjust.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollBarAdjust_Scroll);
            // 
            // btnRandomDemo
            // 
            this.btnRandomDemo.Location = new System.Drawing.Point(201, 305);
            this.btnRandomDemo.Name = "btnRandomDemo";
            this.btnRandomDemo.Size = new System.Drawing.Size(87, 44);
            this.btnRandomDemo.TabIndex = 11;
            this.btnRandomDemo.Text = "Random Demo";
            this.btnRandomDemo.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 379);
            this.Controls.Add(this.btnRandomDemo);
            this.Controls.Add(this.scrollBarAdjust);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBald);
            this.Controls.Add(this.btnStraight);
            this.Controls.Add(this.btnWavy);
            this.Controls.Add(this.btnBang);
            this.Controls.Add(this.imageAfter);
            this.Controls.Add(this.imageBefore);
            this.Controls.Add(this.btnSavePortrait);
            this.Controls.Add(this.btnLoadPortrait);
            this.Name = "MainForm";
            this.Text = "Hair Nut Client";
            ((System.ComponentModel.ISupportInitialize)(this.imageBefore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageAfter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadPortrait;
        private System.Windows.Forms.Button btnSavePortrait;
        private System.Windows.Forms.PictureBox imageBefore;
        private System.Windows.Forms.PictureBox imageAfter;
        private System.Windows.Forms.Button btnBang;
        private System.Windows.Forms.Button btnWavy;
        private System.Windows.Forms.Button btnStraight;
        private System.Windows.Forms.Button btnBald;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.VScrollBar scrollBarAdjust;
        private System.Windows.Forms.Button btnRandomDemo;
    }
}

