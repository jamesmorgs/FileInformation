namespace FileInformation
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.txtCreated = new System.Windows.Forms.TextBox();
            this.txtModified = new System.Windows.Forms.TextBox();
            this.txtAccessed = new System.Windows.Forms.TextBox();
            this.lblCreated = new System.Windows.Forms.Label();
            this.lblModified = new System.Windows.Forms.Label();
            this.lblAccessed = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(69, 54);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Select File";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(160, 56);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(504, 20);
            this.txtFilePath.TabIndex = 1;
            // 
            // txtCreated
            // 
            this.txtCreated.Location = new System.Drawing.Point(160, 99);
            this.txtCreated.Name = "txtCreated";
            this.txtCreated.Size = new System.Drawing.Size(238, 20);
            this.txtCreated.TabIndex = 2;
            // 
            // txtModified
            // 
            this.txtModified.Location = new System.Drawing.Point(160, 135);
            this.txtModified.Name = "txtModified";
            this.txtModified.Size = new System.Drawing.Size(238, 20);
            this.txtModified.TabIndex = 3;
            // 
            // txtAccessed
            // 
            this.txtAccessed.Location = new System.Drawing.Point(160, 172);
            this.txtAccessed.Name = "txtAccessed";
            this.txtAccessed.Size = new System.Drawing.Size(238, 20);
            this.txtAccessed.TabIndex = 4;
            // 
            // lblCreated
            // 
            this.lblCreated.AutoSize = true;
            this.lblCreated.Location = new System.Drawing.Point(46, 102);
            this.lblCreated.Name = "lblCreated";
            this.lblCreated.Size = new System.Drawing.Size(98, 13);
            this.lblCreated.TabIndex = 5;
            this.lblCreated.Text = "Created Date/Time";
            // 
            // lblModified
            // 
            this.lblModified.AutoSize = true;
            this.lblModified.Location = new System.Drawing.Point(43, 138);
            this.lblModified.Name = "lblModified";
            this.lblModified.Size = new System.Drawing.Size(101, 13);
            this.lblModified.TabIndex = 6;
            this.lblModified.Text = "Modified Date/Time";
            // 
            // lblAccessed
            // 
            this.lblAccessed.AutoSize = true;
            this.lblAccessed.Location = new System.Drawing.Point(36, 175);
            this.lblAccessed.Name = "lblAccessed";
            this.lblAccessed.Size = new System.Drawing.Size(108, 13);
            this.lblAccessed.TabIndex = 7;
            this.lblAccessed.Text = "Accessed Date/Time";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(69, 214);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 590);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblAccessed);
            this.Controls.Add(this.lblModified);
            this.Controls.Add(this.lblCreated);
            this.Controls.Add(this.txtAccessed);
            this.Controls.Add(this.txtModified);
            this.Controls.Add(this.txtCreated);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnSelect);
            this.Name = "Form1";
            this.Text = "File Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.TextBox txtCreated;
        private System.Windows.Forms.TextBox txtModified;
        private System.Windows.Forms.TextBox txtAccessed;
        private System.Windows.Forms.Label lblCreated;
        private System.Windows.Forms.Label lblModified;
        private System.Windows.Forms.Label lblAccessed;
        private System.Windows.Forms.Button btnClear;
    }
}

