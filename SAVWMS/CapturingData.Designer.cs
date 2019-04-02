namespace SAVWMS
{
    partial class CapturingData
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
            this.btnstart = new System.Windows.Forms.Button();
            this.cmbaddress = new System.Windows.Forms.ComboBox();
            this.labaddress = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnconnect = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnstart
            // 
            this.btnstart.Font = new System.Drawing.Font("隶书", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnstart.Location = new System.Drawing.Point(28, 107);
            this.btnstart.Margin = new System.Windows.Forms.Padding(2);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(306, 72);
            this.btnstart.TabIndex = 0;
            this.btnstart.Text = "开始扫码并采集体积";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // cmbaddress
            // 
            this.cmbaddress.FormattingEnabled = true;
            this.cmbaddress.Location = new System.Drawing.Point(141, 22);
            this.cmbaddress.Margin = new System.Windows.Forms.Padding(2);
            this.cmbaddress.Name = "cmbaddress";
            this.cmbaddress.Size = new System.Drawing.Size(209, 20);
            this.cmbaddress.TabIndex = 1;
            // 
            // labaddress
            // 
            this.labaddress.AutoSize = true;
            this.labaddress.Font = new System.Drawing.Font("隶书", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labaddress.Location = new System.Drawing.Point(9, 17);
            this.labaddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labaddress.Name = "labaddress";
            this.labaddress.Size = new System.Drawing.Size(130, 24);
            this.labaddress.TabIndex = 2;
            this.labaddress.Text = "设备地址：";
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("隶书", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnupdate.Location = new System.Drawing.Point(369, 10);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(174, 38);
            this.btnupdate.TabIndex = 3;
            this.btnupdate.Text = "更新设备地址";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnconnect
            // 
            this.btnconnect.Font = new System.Drawing.Font("隶书", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnconnect.Location = new System.Drawing.Point(579, 10);
            this.btnconnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnconnect.Name = "btnconnect";
            this.btnconnect.Size = new System.Drawing.Size(182, 38);
            this.btnconnect.TabIndex = 4;
            this.btnconnect.Text = "连接到此设备";
            this.btnconnect.UseVisualStyleBackColor = true;
            this.btnconnect.Click += new System.EventHandler(this.btnconnect_Click);
            // 
            // btnstop
            // 
            this.btnstop.Font = new System.Drawing.Font("隶书", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnstop.Location = new System.Drawing.Point(28, 216);
            this.btnstop.Margin = new System.Windows.Forms.Padding(2);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(306, 72);
            this.btnstop.TabIndex = 5;
            this.btnstop.Text = "停止工作";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // CapturingData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 412);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.btnconnect);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.labaddress);
            this.Controls.Add(this.cmbaddress);
            this.Controls.Add(this.btnstart);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CapturingData";
            this.Text = "数据采集功能";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.ComboBox cmbaddress;
        private System.Windows.Forms.Label labaddress;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnconnect;
        private System.Windows.Forms.Button btnstop;
    }
}