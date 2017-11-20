namespace RocketConfigEditor
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
            this.components = new System.ComponentModel.Container();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.cdColorCommand = new System.Windows.Forms.ColorDialog();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tcPlugins = new System.Windows.Forms.TabPage();
            this.btnEditPluginsConfig = new System.Windows.Forms.Button();
            this.cbPlugins = new System.Windows.Forms.ComboBox();
            this.tctRocket = new System.Windows.Forms.TabPage();
            this.gbRocketConfig = new System.Windows.Forms.GroupBox();
            this.gbAddPermGroup = new System.Windows.Forms.GroupBox();
            this.rtxtParentGroups = new System.Windows.Forms.RichTextBox();
            this.lblParentGroups = new System.Windows.Forms.Label();
            this.lblCommands = new System.Windows.Forms.Label();
            this.rtxtCommands = new System.Windows.Forms.RichTextBox();
            this.lblmem = new System.Windows.Forms.Label();
            this.rtxtAddMembers = new System.Windows.Forms.RichTextBox();
            this.btnAddPermGroup = new System.Windows.Forms.Button();
            this.txtGrpName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGrpId = new System.Windows.Forms.TextBox();
            this.gbPermChange = new System.Windows.Forms.GroupBox();
            this.nudCooldown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRpermAdd = new System.Windows.Forms.Button();
            this.cbGroup = new System.Windows.Forms.ComboBox();
            this.lblcmd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcmdAdd = new System.Windows.Forms.TextBox();
            this.cbPermConAdd = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tcUniversal = new System.Windows.Forms.TabControl();
            this.btnloacalDirectory = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnColorChange = new System.Windows.Forms.Button();
            this.tcPlugins.SuspendLayout();
            this.tctRocket.SuspendLayout();
            this.gbRocketConfig.SuspendLayout();
            this.gbAddPermGroup.SuspendLayout();
            this.gbPermChange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCooldown)).BeginInit();
            this.tcUniversal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(564, 27);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(88, 23);
            this.btnOptions.TabIndex = 1;
            this.btnOptions.Text = "Options...";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(564, 85);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(88, 23);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load Data";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(564, 114);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(88, 23);
            this.btnUpload.TabIndex = 4;
            this.btnUpload.Text = "Upload All Files";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(564, 56);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(88, 23);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Download Files";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(564, 145);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(51, 13);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Complete";
            // 
            // tcPlugins
            // 
            this.tcPlugins.Controls.Add(this.btnEditPluginsConfig);
            this.tcPlugins.Controls.Add(this.cbPlugins);
            this.tcPlugins.Location = new System.Drawing.Point(4, 22);
            this.tcPlugins.Name = "tcPlugins";
            this.tcPlugins.Size = new System.Drawing.Size(538, 312);
            this.tcPlugins.TabIndex = 2;
            this.tcPlugins.Text = "Plugins";
            this.tcPlugins.UseVisualStyleBackColor = true;
            // 
            // btnEditPluginsConfig
            // 
            this.btnEditPluginsConfig.Location = new System.Drawing.Point(141, 20);
            this.btnEditPluginsConfig.Name = "btnEditPluginsConfig";
            this.btnEditPluginsConfig.Size = new System.Drawing.Size(75, 23);
            this.btnEditPluginsConfig.TabIndex = 1;
            this.btnEditPluginsConfig.Text = "Edit config";
            this.btnEditPluginsConfig.UseVisualStyleBackColor = true;
            this.btnEditPluginsConfig.Click += new System.EventHandler(this.btnEditPluginsConfig_Click);
            // 
            // cbPlugins
            // 
            this.cbPlugins.Enabled = false;
            this.cbPlugins.FormattingEnabled = true;
            this.cbPlugins.Location = new System.Drawing.Point(14, 22);
            this.cbPlugins.Name = "cbPlugins";
            this.cbPlugins.Size = new System.Drawing.Size(121, 21);
            this.cbPlugins.TabIndex = 0;
            // 
            // tctRocket
            // 
            this.tctRocket.AutoScroll = true;
            this.tctRocket.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tctRocket.Controls.Add(this.gbRocketConfig);
            this.tctRocket.Location = new System.Drawing.Point(4, 22);
            this.tctRocket.Name = "tctRocket";
            this.tctRocket.Padding = new System.Windows.Forms.Padding(3);
            this.tctRocket.Size = new System.Drawing.Size(538, 383);
            this.tctRocket.TabIndex = 0;
            this.tctRocket.Text = "Rocket Config";
            this.tctRocket.UseVisualStyleBackColor = true;
            // 
            // gbRocketConfig
            // 
            this.gbRocketConfig.Controls.Add(this.gbAddPermGroup);
            this.gbRocketConfig.Controls.Add(this.gbPermChange);
            this.gbRocketConfig.Location = new System.Drawing.Point(7, 7);
            this.gbRocketConfig.Name = "gbRocketConfig";
            this.gbRocketConfig.Size = new System.Drawing.Size(474, 447);
            this.gbRocketConfig.TabIndex = 1;
            this.gbRocketConfig.TabStop = false;
            this.gbRocketConfig.Text = "Permissions.config";
            // 
            // gbAddPermGroup
            // 
            this.gbAddPermGroup.Controls.Add(this.btnColorChange);
            this.gbAddPermGroup.Controls.Add(this.rtxtParentGroups);
            this.gbAddPermGroup.Controls.Add(this.lblParentGroups);
            this.gbAddPermGroup.Controls.Add(this.lblCommands);
            this.gbAddPermGroup.Controls.Add(this.rtxtCommands);
            this.gbAddPermGroup.Controls.Add(this.lblmem);
            this.gbAddPermGroup.Controls.Add(this.rtxtAddMembers);
            this.gbAddPermGroup.Controls.Add(this.btnAddPermGroup);
            this.gbAddPermGroup.Controls.Add(this.txtGrpName);
            this.gbAddPermGroup.Controls.Add(this.label4);
            this.gbAddPermGroup.Controls.Add(this.label3);
            this.gbAddPermGroup.Controls.Add(this.txtGrpId);
            this.gbAddPermGroup.Location = new System.Drawing.Point(235, 18);
            this.gbAddPermGroup.Name = "gbAddPermGroup";
            this.gbAddPermGroup.Size = new System.Drawing.Size(233, 489);
            this.gbAddPermGroup.TabIndex = 7;
            this.gbAddPermGroup.TabStop = false;
            this.gbAddPermGroup.Text = "Add Permission Group";
            // 
            // rtxtParentGroups
            // 
            this.rtxtParentGroups.Location = new System.Drawing.Point(6, 363);
            this.rtxtParentGroups.Name = "rtxtParentGroups";
            this.rtxtParentGroups.Size = new System.Drawing.Size(221, 61);
            this.rtxtParentGroups.TabIndex = 10;
            this.rtxtParentGroups.Text = "";
            // 
            // lblParentGroups
            // 
            this.lblParentGroups.AutoSize = true;
            this.lblParentGroups.Location = new System.Drawing.Point(6, 347);
            this.lblParentGroups.Name = "lblParentGroups";
            this.lblParentGroups.Size = new System.Drawing.Size(81, 13);
            this.lblParentGroups.TabIndex = 9;
            this.lblParentGroups.Text = "Parent Group(s)";
            // 
            // lblCommands
            // 
            this.lblCommands.AutoSize = true;
            this.lblCommands.Location = new System.Drawing.Point(6, 256);
            this.lblCommands.Name = "lblCommands";
            this.lblCommands.Size = new System.Drawing.Size(65, 13);
            this.lblCommands.TabIndex = 8;
            this.lblCommands.Text = "Command(s)";
            // 
            // rtxtCommands
            // 
            this.rtxtCommands.Location = new System.Drawing.Point(7, 272);
            this.rtxtCommands.Name = "rtxtCommands";
            this.rtxtCommands.Size = new System.Drawing.Size(221, 72);
            this.rtxtCommands.TabIndex = 7;
            this.rtxtCommands.Text = "";
            // 
            // lblmem
            // 
            this.lblmem.AutoSize = true;
            this.lblmem.Location = new System.Drawing.Point(6, 163);
            this.lblmem.Name = "lblmem";
            this.lblmem.Size = new System.Drawing.Size(56, 13);
            this.lblmem.TabIndex = 6;
            this.lblmem.Text = "Member(s)";
            // 
            // rtxtAddMembers
            // 
            this.rtxtAddMembers.Location = new System.Drawing.Point(6, 179);
            this.rtxtAddMembers.Name = "rtxtAddMembers";
            this.rtxtAddMembers.Size = new System.Drawing.Size(221, 74);
            this.rtxtAddMembers.TabIndex = 5;
            this.rtxtAddMembers.Text = "";
            // 
            // btnAddPermGroup
            // 
            this.btnAddPermGroup.Location = new System.Drawing.Point(7, 430);
            this.btnAddPermGroup.Name = "btnAddPermGroup";
            this.btnAddPermGroup.Size = new System.Drawing.Size(75, 23);
            this.btnAddPermGroup.TabIndex = 4;
            this.btnAddPermGroup.Text = "Add";
            this.btnAddPermGroup.UseVisualStyleBackColor = true;
            this.btnAddPermGroup.Click += new System.EventHandler(this.btnAddPermGroup_Click);
            // 
            // txtGrpName
            // 
            this.txtGrpName.Location = new System.Drawing.Point(7, 84);
            this.txtGrpName.Name = "txtGrpName";
            this.txtGrpName.Size = new System.Drawing.Size(134, 20);
            this.txtGrpName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Group Display Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Group ID";
            // 
            // txtGrpId
            // 
            this.txtGrpId.Location = new System.Drawing.Point(7, 41);
            this.txtGrpId.Name = "txtGrpId";
            this.txtGrpId.Size = new System.Drawing.Size(134, 20);
            this.txtGrpId.TabIndex = 0;
            // 
            // gbPermChange
            // 
            this.gbPermChange.Controls.Add(this.nudCooldown);
            this.gbPermChange.Controls.Add(this.label5);
            this.gbPermChange.Controls.Add(this.btnRpermAdd);
            this.gbPermChange.Controls.Add(this.cbGroup);
            this.gbPermChange.Controls.Add(this.lblcmd);
            this.gbPermChange.Controls.Add(this.label1);
            this.gbPermChange.Controls.Add(this.txtcmdAdd);
            this.gbPermChange.Controls.Add(this.cbPermConAdd);
            this.gbPermChange.Controls.Add(this.label2);
            this.gbPermChange.Location = new System.Drawing.Point(6, 18);
            this.gbPermChange.Name = "gbPermChange";
            this.gbPermChange.Size = new System.Drawing.Size(222, 267);
            this.gbPermChange.TabIndex = 6;
            this.gbPermChange.TabStop = false;
            this.gbPermChange.Text = "Edit Permission Group";
            // 
            // nudCooldown
            // 
            this.nudCooldown.Location = new System.Drawing.Point(7, 180);
            this.nudCooldown.Maximum = new decimal(new int[] {
            8000000,
            0,
            0,
            0});
            this.nudCooldown.Name = "nudCooldown";
            this.nudCooldown.Size = new System.Drawing.Size(120, 20);
            this.nudCooldown.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cooldown";
            // 
            // btnRpermAdd
            // 
            this.btnRpermAdd.Location = new System.Drawing.Point(6, 238);
            this.btnRpermAdd.Name = "btnRpermAdd";
            this.btnRpermAdd.Size = new System.Drawing.Size(89, 23);
            this.btnRpermAdd.TabIndex = 6;
            this.btnRpermAdd.Text = "Add/Change";
            this.btnRpermAdd.UseVisualStyleBackColor = true;
            this.btnRpermAdd.Click += new System.EventHandler(this.btnRpermAdd_Click);
            // 
            // cbGroup
            // 
            this.cbGroup.FormattingEnabled = true;
            this.cbGroup.Location = new System.Drawing.Point(6, 41);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.Size = new System.Drawing.Size(121, 21);
            this.cbGroup.TabIndex = 1;
            // 
            // lblcmd
            // 
            this.lblcmd.AutoSize = true;
            this.lblcmd.Location = new System.Drawing.Point(3, 121);
            this.lblcmd.Name = "lblcmd";
            this.lblcmd.Size = new System.Drawing.Size(57, 13);
            this.lblcmd.TabIndex = 5;
            this.lblcmd.Text = "Command:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group:";
            // 
            // txtcmdAdd
            // 
            this.txtcmdAdd.Location = new System.Drawing.Point(6, 137);
            this.txtcmdAdd.Name = "txtcmdAdd";
            this.txtcmdAdd.ReadOnly = true;
            this.txtcmdAdd.Size = new System.Drawing.Size(121, 20);
            this.txtcmdAdd.TabIndex = 4;
            // 
            // cbPermConAdd
            // 
            this.cbPermConAdd.FormattingEnabled = true;
            this.cbPermConAdd.Items.AddRange(new object[] {
            "Command",
            "Color"});
            this.cbPermConAdd.Location = new System.Drawing.Point(6, 93);
            this.cbPermConAdd.Name = "cbPermConAdd";
            this.cbPermConAdd.Size = new System.Drawing.Size(121, 21);
            this.cbPermConAdd.TabIndex = 2;
            this.cbPermConAdd.SelectedIndexChanged += new System.EventHandler(this.cbPermConAdd_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Add/Change:";
            // 
            // tcUniversal
            // 
            this.tcUniversal.Controls.Add(this.tctRocket);
            this.tcUniversal.Controls.Add(this.tcPlugins);
            this.tcUniversal.Location = new System.Drawing.Point(12, 12);
            this.tcUniversal.Name = "tcUniversal";
            this.tcUniversal.SelectedIndex = 0;
            this.tcUniversal.Size = new System.Drawing.Size(546, 409);
            this.tcUniversal.TabIndex = 0;
            this.tcUniversal.SelectedIndexChanged += new System.EventHandler(this.tcUniversal_SelectedIndexChanged);
            // 
            // btnloacalDirectory
            // 
            this.btnloacalDirectory.Location = new System.Drawing.Point(564, 398);
            this.btnloacalDirectory.Name = "btnloacalDirectory";
            this.btnloacalDirectory.Size = new System.Drawing.Size(92, 23);
            this.btnloacalDirectory.TabIndex = 7;
            this.btnloacalDirectory.Text = "local directory";
            this.btnloacalDirectory.UseVisualStyleBackColor = true;
            this.btnloacalDirectory.Click += new System.EventHandler(this.btnloacalDirectory_Click);
            // 
            // btnColorChange
            // 
            this.btnColorChange.Location = new System.Drawing.Point(7, 110);
            this.btnColorChange.Name = "btnColorChange";
            this.btnColorChange.Size = new System.Drawing.Size(220, 47);
            this.btnColorChange.TabIndex = 11;
            this.btnColorChange.Text = "Color";
            this.btnColorChange.UseVisualStyleBackColor = true;
            this.btnColorChange.Click += new System.EventHandler(this.btnColorChange_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(664, 433);
            this.Controls.Add(this.btnloacalDirectory);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.tcUniversal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Rocket Config Editor";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tcPlugins.ResumeLayout(false);
            this.tctRocket.ResumeLayout(false);
            this.gbRocketConfig.ResumeLayout(false);
            this.gbAddPermGroup.ResumeLayout(false);
            this.gbAddPermGroup.PerformLayout();
            this.gbPermChange.ResumeLayout(false);
            this.gbPermChange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCooldown)).EndInit();
            this.tcUniversal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.ColorDialog cdColorCommand;
        private System.Windows.Forms.Button btnConnect;
        public System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TabPage tcPlugins;
        private System.Windows.Forms.Button btnEditPluginsConfig;
        private System.Windows.Forms.ComboBox cbPlugins;
        private System.Windows.Forms.TabPage tctRocket;
        private System.Windows.Forms.GroupBox gbRocketConfig;
        private System.Windows.Forms.GroupBox gbAddPermGroup;
        private System.Windows.Forms.RichTextBox rtxtParentGroups;
        private System.Windows.Forms.Label lblParentGroups;
        private System.Windows.Forms.Label lblCommands;
        private System.Windows.Forms.RichTextBox rtxtCommands;
        private System.Windows.Forms.Label lblmem;
        private System.Windows.Forms.RichTextBox rtxtAddMembers;
        private System.Windows.Forms.Button btnAddPermGroup;
        private System.Windows.Forms.TextBox txtGrpName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGrpId;
        private System.Windows.Forms.GroupBox gbPermChange;
        private System.Windows.Forms.Button btnRpermAdd;
        private System.Windows.Forms.ComboBox cbGroup;
        private System.Windows.Forms.Label lblcmd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcmdAdd;
        private System.Windows.Forms.ComboBox cbPermConAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tcUniversal;
        private System.Windows.Forms.Button btnloacalDirectory;
        private System.Windows.Forms.NumericUpDown nudCooldown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnColorChange;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

