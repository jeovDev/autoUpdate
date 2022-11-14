namespace autoUpdate
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.airForm1 = new ReaLTaiizor.Forms.AirForm();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbheader = new System.Windows.Forms.Label();
            this.lbnew = new System.Windows.Forms.Label();
            this.lbcurrent = new System.Windows.Forms.Label();
            this.labelnew = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new ReaLTaiizor.Controls.AloneButton();
            this.bw_updateChecker = new System.ComponentModel.BackgroundWorker();
            this.airForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // airForm1
            // 
            this.airForm1.BackColor = System.Drawing.Color.White;
            this.airForm1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.airForm1.Controls.Add(this.pictureBox1);
            this.airForm1.Controls.Add(this.lbheader);
            this.airForm1.Controls.Add(this.lbnew);
            this.airForm1.Controls.Add(this.lbcurrent);
            this.airForm1.Controls.Add(this.labelnew);
            this.airForm1.Controls.Add(this.label1);
            this.airForm1.Controls.Add(this.btnUpdate);
            this.airForm1.Customization = "AAAA/1paWv9ycnL/";
            this.airForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.airForm1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.airForm1.Image = null;
            this.airForm1.Location = new System.Drawing.Point(0, 0);
            this.airForm1.MinimumSize = new System.Drawing.Size(112, 35);
            this.airForm1.Movable = true;
            this.airForm1.Name = "airForm1";
            this.airForm1.NoRounding = false;
            this.airForm1.Sizable = true;
            this.airForm1.Size = new System.Drawing.Size(353, 296);
            this.airForm1.SmartBounds = true;
            this.airForm1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.airForm1.TabIndex = 0;
            this.airForm1.Text = "        Coding Ideas | Auto Update";
            this.airForm1.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.airForm1.Transparent = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lbheader
            // 
            this.lbheader.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbheader.Location = new System.Drawing.Point(24, 47);
            this.lbheader.Name = "lbheader";
            this.lbheader.Size = new System.Drawing.Size(326, 63);
            this.lbheader.TabIndex = 6;
            this.lbheader.Text = "A New Version is Available.\r\nDo you want to Update ?\r\n";
            // 
            // lbnew
            // 
            this.lbnew.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnew.Location = new System.Drawing.Point(202, 176);
            this.lbnew.Name = "lbnew";
            this.lbnew.Size = new System.Drawing.Size(75, 19);
            this.lbnew.TabIndex = 5;
            this.lbnew.Text = "1.0.0.0";
            this.lbnew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbcurrent
            // 
            this.lbcurrent.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcurrent.Location = new System.Drawing.Point(202, 135);
            this.lbcurrent.Name = "lbcurrent";
            this.lbcurrent.Size = new System.Drawing.Size(75, 19);
            this.lbcurrent.TabIndex = 4;
            this.lbcurrent.Text = "1.0.0.0";
            this.lbcurrent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelnew
            // 
            this.labelnew.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnew.Location = new System.Drawing.Point(26, 174);
            this.labelnew.Name = "labelnew";
            this.labelnew.Size = new System.Drawing.Size(170, 19);
            this.labelnew.TabIndex = 3;
            this.labelnew.Text = "New Version Available :";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Version : ";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.EnabledCalc = true;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.btnUpdate.Location = new System.Drawing.Point(30, 223);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(261, 40);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new ReaLTaiizor.Controls.AloneButton.ClickEventHandler(this.btnUpdate_Click);
            // 
            // bw_updateChecker
            // 
            this.bw_updateChecker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_updateChecker_DoWork);
            this.bw_updateChecker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_updateChecker_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(353, 296);
            this.Controls.Add(this.airForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(112, 35);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "themeForm1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.airForm1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.AirForm airForm1;
        private ReaLTaiizor.Controls.AloneButton btnUpdate;
        private System.Windows.Forms.Label lbheader;
        private System.Windows.Forms.Label lbnew;
        private System.Windows.Forms.Label lbcurrent;
        private System.Windows.Forms.Label labelnew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker bw_updateChecker;
    }
}

