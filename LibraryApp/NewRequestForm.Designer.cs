namespace LibraryApp
{
    partial class NewRequestForm
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
            this.submitRequestBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.authorTB = new System.Windows.Forms.TextBox();
            this.titleTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // submitRequestBtn
            // 
            this.submitRequestBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(108)))), ((int)(((byte)(101)))));
            this.submitRequestBtn.FlatAppearance.BorderSize = 0;
            this.submitRequestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitRequestBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitRequestBtn.ForeColor = System.Drawing.Color.White;
            this.submitRequestBtn.Location = new System.Drawing.Point(12, 90);
            this.submitRequestBtn.Name = "submitRequestBtn";
            this.submitRequestBtn.Size = new System.Drawing.Size(199, 37);
            this.submitRequestBtn.TabIndex = 28;
            this.submitRequestBtn.Text = "Submit Request";
            this.submitRequestBtn.UseVisualStyleBackColor = false;
            this.submitRequestBtn.Click += new System.EventHandler(this.submitRequestBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Author";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Title";
            // 
            // authorTB
            // 
            this.authorTB.Location = new System.Drawing.Point(12, 64);
            this.authorTB.Name = "authorTB";
            this.authorTB.Size = new System.Drawing.Size(199, 20);
            this.authorTB.TabIndex = 25;
            // 
            // titleTB
            // 
            this.titleTB.Location = new System.Drawing.Point(12, 25);
            this.titleTB.Name = "titleTB";
            this.titleTB.Size = new System.Drawing.Size(199, 20);
            this.titleTB.TabIndex = 24;
            // 
            // NewRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(138)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(225, 142);
            this.Controls.Add(this.submitRequestBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.authorTB);
            this.Controls.Add(this.titleTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NewRequestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NewRequestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button submitRequestBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox authorTB;
        private System.Windows.Forms.TextBox titleTB;
    }
}