namespace GADE_POE_task_3
{
    partial class FrmMain
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
            this.rtbBuildingInfo = new System.Windows.Forms.RichTextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbBuild = new System.Windows.Forms.ComboBox();
            this.lblBuildings = new System.Windows.Forms.Label();
            this.lblUnits = new System.Windows.Forms.Label();
            this.rtbUnitInfo = new System.Windows.Forms.RichTextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblRoundCount = new System.Windows.Forms.Label();
            this.lblMap = new System.Windows.Forms.Label();
            this.TimerTick = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // rtbBuildingInfo
            // 
            this.rtbBuildingInfo.Location = new System.Drawing.Point(607, 234);
            this.rtbBuildingInfo.Margin = new System.Windows.Forms.Padding(4);
            this.rtbBuildingInfo.Name = "rtbBuildingInfo";
            this.rtbBuildingInfo.Size = new System.Drawing.Size(167, 154);
            this.rtbBuildingInfo.TabIndex = 21;
            this.rtbBuildingInfo.Text = "";
            this.rtbBuildingInfo.TextChanged += new System.EventHandler(this.rtbBuildingInfo_TextChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(198, 452);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(110, 46);
            this.btnLoad.TabIndex = 20;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(40, 452);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 46);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbBuild
            // 
            this.cmbBuild.FormattingEnabled = true;
            this.cmbBuild.Location = new System.Drawing.Point(607, 202);
            this.cmbBuild.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBuild.Name = "cmbBuild";
            this.cmbBuild.Size = new System.Drawing.Size(211, 24);
            this.cmbBuild.TabIndex = 18;
            this.cmbBuild.SelectedIndexChanged += new System.EventHandler(this.cmbBuild_SelectedIndexChanged);
            // 
            // lblBuildings
            // 
            this.lblBuildings.AutoSize = true;
            this.lblBuildings.Location = new System.Drawing.Point(747, 91);
            this.lblBuildings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuildings.Name = "lblBuildings";
            this.lblBuildings.Size = new System.Drawing.Size(65, 17);
            this.lblBuildings.TabIndex = 17;
            this.lblBuildings.Text = "Buildings";
            this.lblBuildings.Click += new System.EventHandler(this.lblBuildings_Click);
            // 
            // lblUnits
            // 
            this.lblUnits.AutoSize = true;
            this.lblUnits.Location = new System.Drawing.Point(502, 91);
            this.lblUnits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(40, 17);
            this.lblUnits.TabIndex = 16;
            this.lblUnits.Text = "Units";
            this.lblUnits.Click += new System.EventHandler(this.lblUnits_Click);
            // 
            // rtbUnitInfo
            // 
            this.rtbUnitInfo.Location = new System.Drawing.Point(405, 190);
            this.rtbUnitInfo.Margin = new System.Windows.Forms.Padding(4);
            this.rtbUnitInfo.Name = "rtbUnitInfo";
            this.rtbUnitInfo.Size = new System.Drawing.Size(167, 154);
            this.rtbUnitInfo.TabIndex = 15;
            this.rtbUnitInfo.Text = "";
            this.rtbUnitInfo.TextChanged += new System.EventHandler(this.rtbUnitInfo_TextChanged);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(607, 410);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(115, 46);
            this.btnStop.TabIndex = 14;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(433, 410);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(115, 46);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblRoundCount
            // 
            this.lblRoundCount.AutoSize = true;
            this.lblRoundCount.Location = new System.Drawing.Point(497, 128);
            this.lblRoundCount.Name = "lblRoundCount";
            this.lblRoundCount.Size = new System.Drawing.Size(50, 17);
            this.lblRoundCount.TabIndex = 12;
            this.lblRoundCount.Text = "Round";
            this.lblRoundCount.Click += new System.EventHandler(this.lblRoundCount_Click);
            // 
            // lblMap
            // 
            this.lblMap.AutoSize = true;
            this.lblMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMap.Location = new System.Drawing.Point(40, 78);
            this.lblMap.Name = "lblMap";
            this.lblMap.Size = new System.Drawing.Size(37, 19);
            this.lblMap.TabIndex = 11;
            this.lblMap.Text = "Map";
            this.lblMap.Click += new System.EventHandler(this.lblMap_Click);
            // 
            // TimerTick
            // 
            this.TimerTick.Tick += new System.EventHandler(this.TimerTick_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 591);
            this.Controls.Add(this.rtbBuildingInfo);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbBuild);
            this.Controls.Add(this.lblBuildings);
            this.Controls.Add(this.lblUnits);
            this.Controls.Add(this.rtbUnitInfo);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblRoundCount);
            this.Controls.Add(this.lblMap);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbBuildingInfo;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbBuild;
        private System.Windows.Forms.Label lblBuildings;
        private System.Windows.Forms.Label lblUnits;
        private System.Windows.Forms.RichTextBox rtbUnitInfo;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblRoundCount;
        private System.Windows.Forms.Label lblMap;
        private System.Windows.Forms.Timer TimerTick;
    }
}

