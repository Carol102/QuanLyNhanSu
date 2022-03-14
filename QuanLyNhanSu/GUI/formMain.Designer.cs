namespace QuanLyNhanSu.GUI
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.buttonNV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NVlabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PBlabel = new System.Windows.Forms.Label();
            this.buttonPB = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNV
            // 
            this.buttonNV.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonNV.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNV.ForeColor = System.Drawing.Color.White;
            this.buttonNV.Location = new System.Drawing.Point(0, 146);
            this.buttonNV.Name = "buttonNV";
            this.buttonNV.Size = new System.Drawing.Size(281, 72);
            this.buttonNV.TabIndex = 0;
            this.buttonNV.Text = "Nhân Viên";
            this.buttonNV.UseVisualStyleBackColor = false;
            this.buttonNV.Click += new System.EventHandler(this.buttonNV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(242, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 62);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÝ NHÂN SỰ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.NVlabel);
            this.panel1.Controls.Add(this.buttonNV);
            this.panel1.Location = new System.Drawing.Point(129, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 218);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(147, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // NVlabel
            // 
            this.NVlabel.AutoSize = true;
            this.NVlabel.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NVlabel.ForeColor = System.Drawing.Color.Black;
            this.NVlabel.Location = new System.Drawing.Point(25, 20);
            this.NVlabel.Name = "NVlabel";
            this.NVlabel.Size = new System.Drawing.Size(88, 106);
            this.NVlabel.TabIndex = 1;
            this.NVlabel.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.PBlabel);
            this.panel2.Controls.Add(this.buttonPB);
            this.panel2.Location = new System.Drawing.Point(504, 161);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 218);
            this.panel2.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(147, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 106);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // PBlabel
            // 
            this.PBlabel.AutoSize = true;
            this.PBlabel.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PBlabel.ForeColor = System.Drawing.Color.Black;
            this.PBlabel.Location = new System.Drawing.Point(25, 20);
            this.PBlabel.Name = "PBlabel";
            this.PBlabel.Size = new System.Drawing.Size(88, 106);
            this.PBlabel.TabIndex = 1;
            this.PBlabel.Text = "0";
            // 
            // buttonPB
            // 
            this.buttonPB.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonPB.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPB.ForeColor = System.Drawing.Color.White;
            this.buttonPB.Location = new System.Drawing.Point(0, 146);
            this.buttonPB.Name = "buttonPB";
            this.buttonPB.Size = new System.Drawing.Size(281, 72);
            this.buttonPB.TabIndex = 0;
            this.buttonPB.Text = "Phòng Ban";
            this.buttonPB.UseVisualStyleBackColor = false;
            this.buttonPB.Click += new System.EventHandler(this.buttonPB_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(254)))));
            this.button3.Location = new System.Drawing.Point(842, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Help";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 474);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhân Sự";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formMain_FormClosed);
            this.Load += new System.EventHandler(this.formMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label NVlabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label PBlabel;
        private System.Windows.Forms.Button buttonPB;
        private System.Windows.Forms.Button button3;
    }
}