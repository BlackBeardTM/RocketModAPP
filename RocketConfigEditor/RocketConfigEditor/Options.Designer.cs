namespace RocketConfigEditor
{
    partial class Options
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtHostName = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbLocal = new System.Windows.Forms.CheckBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.txtDirPath = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnSaveOptions = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.radESSL = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host name:";
            // 
            // txtHostName
            // 
            this.txtHostName.Location = new System.Drawing.Point(12, 32);
            this.txtHostName.Name = "txtHostName";
            this.txtHostName.Size = new System.Drawing.Size(212, 20);
            this.txtHostName.TabIndex = 1;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(230, 32);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 20);
            this.txtPort.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port:";
            // 
            // cbLocal
            // 
            this.cbLocal.AutoSize = true;
            this.cbLocal.Location = new System.Drawing.Point(96, 12);
            this.cbLocal.Name = "cbLocal";
            this.cbLocal.Size = new System.Drawing.Size(130, 17);
            this.cbLocal.TabIndex = 4;
            this.cbLocal.Text = "Local(not working yet)";
            this.cbLocal.UseVisualStyleBackColor = true;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(9, 57);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(115, 13);
            this.lblPath.TabIndex = 5;
            this.lblPath.Text = "Rocket Directory Path:";
            // 
            // txtDirPath
            // 
            this.txtDirPath.Location = new System.Drawing.Point(12, 73);
            this.txtDirPath.Name = "txtDirPath";
            this.txtDirPath.Size = new System.Drawing.Size(212, 20);
            this.txtDirPath.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(10, 97);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(111, 13);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "User Name: (Optional)";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(13, 114);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(146, 20);
            this.txtUserName.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password:(Optional)";
            // 
            // txtPass
            // 
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.Location = new System.Drawing.Point(199, 114);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(149, 20);
            this.txtPass.TabIndex = 11;
            // 
            // btnSaveOptions
            // 
            this.btnSaveOptions.Location = new System.Drawing.Point(294, 140);
            this.btnSaveOptions.Name = "btnSaveOptions";
            this.btnSaveOptions.Size = new System.Drawing.Size(54, 23);
            this.btnSaveOptions.TabIndex = 14;
            this.btnSaveOptions.Text = "Save";
            this.btnSaveOptions.UseVisualStyleBackColor = true;
            this.btnSaveOptions.Click += new System.EventHandler(this.btnSaveOptions_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(213, 140);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // radESSL
            // 
            this.radESSL.AutoSize = true;
            this.radESSL.Location = new System.Drawing.Point(249, 58);
            this.radESSL.Name = "radESSL";
            this.radESSL.Size = new System.Drawing.Size(81, 17);
            this.radESSL.TabIndex = 16;
            this.radESSL.TabStop = true;
            this.radESSL.Text = "Enable SSL";
            this.radESSL.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(360, 180);
            this.Controls.Add(this.radESSL);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveOptions);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtDirPath);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.cbLocal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtHostName);
            this.Controls.Add(this.label1);
            this.Enabled = false;
            this.Name = "Options";
            this.Text = "Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Options_FormClosing);
            this.Load += new System.EventHandler(this.Options_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHostName;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbLocal;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox txtDirPath;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnSaveOptions;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton radESSL;
    }
}