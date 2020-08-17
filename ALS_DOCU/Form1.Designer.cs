namespace ALS_DOCU
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.insertMod = new System.Windows.Forms.Button();
            this.searchMod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Location = new System.Drawing.Point(2, 41);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(641, 381);
            this.MainPanel.TabIndex = 0;
            // 
            // insertMod
            // 
            this.insertMod.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.insertMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertMod.Location = new System.Drawing.Point(12, 5);
            this.insertMod.Name = "insertMod";
            this.insertMod.Size = new System.Drawing.Size(99, 30);
            this.insertMod.TabIndex = 1;
            this.insertMod.Text = "I N S E R T E R";
            this.insertMod.UseVisualStyleBackColor = false;
            this.insertMod.Click += new System.EventHandler(this.insertMod_Click);
            // 
            // searchMod
            // 
            this.searchMod.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.searchMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchMod.Location = new System.Drawing.Point(117, 5);
            this.searchMod.Name = "searchMod";
            this.searchMod.Size = new System.Drawing.Size(99, 30);
            this.searchMod.TabIndex = 2;
            this.searchMod.Text = "S E A R C H E R";
            this.searchMod.UseVisualStyleBackColor = false;
            this.searchMod.Click += new System.EventHandler(this.searchMod_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 425);
            this.Controls.Add(this.searchMod);
            this.Controls.Add(this.insertMod);
            this.Controls.Add(this.MainPanel);
            this.Name = "Form1";
            this.Text = "ALS DOCUMENTOR v0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button insertMod;
        private System.Windows.Forms.Button searchMod;
    }
}

