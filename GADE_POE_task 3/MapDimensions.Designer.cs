namespace GADE_POE_task_3
{
    partial class MapDimensions
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
            this.lblMapWidth = new System.Windows.Forms.Label();
            this.lblMapHeight = new System.Windows.Forms.Label();
            this.txtMapWidth = new System.Windows.Forms.TextBox();
            this.txtMapHeight = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMapWidth
            // 
            this.lblMapWidth.AutoSize = true;
            this.lblMapWidth.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMapWidth.Location = new System.Drawing.Point(71, 119);
            this.lblMapWidth.Name = "lblMapWidth";
            this.lblMapWidth.Size = new System.Drawing.Size(109, 21);
            this.lblMapWidth.TabIndex = 0;
            this.lblMapWidth.Text = "Map Width";
            // 
            // lblMapHeight
            // 
            this.lblMapHeight.AutoSize = true;
            this.lblMapHeight.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMapHeight.Location = new System.Drawing.Point(286, 119);
            this.lblMapHeight.Name = "lblMapHeight";
            this.lblMapHeight.Size = new System.Drawing.Size(120, 21);
            this.lblMapHeight.TabIndex = 1;
            this.lblMapHeight.Text = "Map Height";
            // 
            // txtMapWidth
            // 
            this.txtMapWidth.Location = new System.Drawing.Point(80, 213);
            this.txtMapWidth.Name = "txtMapWidth";
            this.txtMapWidth.Size = new System.Drawing.Size(100, 22);
            this.txtMapWidth.TabIndex = 2;
            // 
            // txtMapHeight
            // 
            this.txtMapHeight.Location = new System.Drawing.Point(290, 213);
            this.txtMapHeight.Name = "txtMapHeight";
            this.txtMapHeight.Size = new System.Drawing.Size(100, 22);
            this.txtMapHeight.TabIndex = 3;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(189, 307);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(104, 43);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // MapDimensions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 427);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtMapHeight);
            this.Controls.Add(this.txtMapWidth);
            this.Controls.Add(this.lblMapHeight);
            this.Controls.Add(this.lblMapWidth);
            this.Name = "MapDimensions";
            this.Text = "MapDimensions";
            this.Load += new System.EventHandler(this.MapDimensions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMapWidth;
        private System.Windows.Forms.Label lblMapHeight;
        private System.Windows.Forms.TextBox txtMapWidth;
        private System.Windows.Forms.TextBox txtMapHeight;
        private System.Windows.Forms.Button btnEnter;
    }
}