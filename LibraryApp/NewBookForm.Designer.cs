namespace LibraryApp
{
    partial class NewBookForm
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
            this.statusLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.authorTB = new System.Windows.Forms.TextBox();
            this.titleTB = new System.Windows.Forms.TextBox();
            this.addBookBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.statusLabel.Location = new System.Drawing.Point(301, 316);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 13);
            this.statusLabel.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Author";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Title";
            // 
            // authorTB
            // 
            this.authorTB.Location = new System.Drawing.Point(12, 64);
            this.authorTB.Name = "authorTB";
            this.authorTB.Size = new System.Drawing.Size(199, 20);
            this.authorTB.TabIndex = 13;
            // 
            // titleTB
            // 
            this.titleTB.Location = new System.Drawing.Point(12, 25);
            this.titleTB.Name = "titleTB";
            this.titleTB.Size = new System.Drawing.Size(199, 20);
            this.titleTB.TabIndex = 12;
            // 
            // addBookBtn
            // 
            this.addBookBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(108)))), ((int)(((byte)(101)))));
            this.addBookBtn.FlatAppearance.BorderSize = 0;
            this.addBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBookBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBookBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.addBookBtn.Location = new System.Drawing.Point(12, 129);
            this.addBookBtn.Name = "addBookBtn";
            this.addBookBtn.Size = new System.Drawing.Size(199, 37);
            this.addBookBtn.TabIndex = 21;
            this.addBookBtn.Text = "Add Book";
            this.addBookBtn.UseVisualStyleBackColor = false;
            this.addBookBtn.Click += new System.EventHandler(this.addBookBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Price";
            // 
            // priceTB
            // 
            this.priceTB.Location = new System.Drawing.Point(12, 103);
            this.priceTB.Name = "priceTB";
            this.priceTB.Size = new System.Drawing.Size(199, 20);
            this.priceTB.TabIndex = 22;
            // 
            // NewBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(190)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(229, 177);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.priceTB);
            this.Controls.Add(this.addBookBtn);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.authorTB);
            this.Controls.Add(this.titleTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NewBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NewBookForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox authorTB;
        private System.Windows.Forms.TextBox titleTB;
        private System.Windows.Forms.Button addBookBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox priceTB;
    }
}