namespace ALS_DOCU
{
    partial class Insert
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PrototypeName = new System.Windows.Forms.TextBox();
            this.desc = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newCatTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddNewEntryBtn = new System.Windows.Forms.Button();
            this.cancelLastAddBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PrototypeName
            // 
            this.PrototypeName.Location = new System.Drawing.Point(13, 71);
            this.PrototypeName.Name = "PrototypeName";
            this.PrototypeName.Size = new System.Drawing.Size(616, 20);
            this.PrototypeName.TabIndex = 0;
            // 
            // desc
            // 
            this.desc.Location = new System.Drawing.Point(13, 117);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(616, 212);
            this.desc.TabIndex = 1;
            this.desc.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(358, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "M A I N    C A T E G O R Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "A D D    N E W  C A T";
            // 
            // newCatTxt
            // 
            this.newCatTxt.Location = new System.Drawing.Point(391, 29);
            this.newCatTxt.Name = "newCatTxt";
            this.newCatTxt.Size = new System.Drawing.Size(185, 20);
            this.newCatTxt.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(583, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 21);
            this.button1.TabIndex = 6;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "P R O TO T Y P E";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "D E S C R I P T I O N";
            // 
            // AddNewEntryBtn
            // 
            this.AddNewEntryBtn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.AddNewEntryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewEntryBtn.Location = new System.Drawing.Point(116, 335);
            this.AddNewEntryBtn.Name = "AddNewEntryBtn";
            this.AddNewEntryBtn.Size = new System.Drawing.Size(513, 43);
            this.AddNewEntryBtn.TabIndex = 9;
            this.AddNewEntryBtn.Text = "A D D";
            this.AddNewEntryBtn.UseVisualStyleBackColor = false;
            this.AddNewEntryBtn.Click += new System.EventHandler(this.AddNewEntryBtn_Click);
            // 
            // cancelLastAddBtn
            // 
            this.cancelLastAddBtn.BackColor = System.Drawing.Color.Salmon;
            this.cancelLastAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelLastAddBtn.Location = new System.Drawing.Point(13, 335);
            this.cancelLastAddBtn.Name = "cancelLastAddBtn";
            this.cancelLastAddBtn.Size = new System.Drawing.Size(94, 43);
            this.cancelLastAddBtn.TabIndex = 10;
            this.cancelLastAddBtn.Text = "[ C ]";
            this.cancelLastAddBtn.UseVisualStyleBackColor = false;
            // 
            // Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cancelLastAddBtn);
            this.Controls.Add(this.AddNewEntryBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.newCatTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.PrototypeName);
            this.Name = "Insert";
            this.Size = new System.Drawing.Size(641, 381);
            this.Load += new System.EventHandler(this.Insert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PrototypeName;
        private System.Windows.Forms.RichTextBox desc;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newCatTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddNewEntryBtn;
        private System.Windows.Forms.Button cancelLastAddBtn;
    }
}
