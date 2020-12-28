namespace LibraryApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.leftPanel = new System.Windows.Forms.Panel();
            this.ordersPanelBtn = new System.Windows.Forms.Button();
            this.requestsPanelBtn = new System.Windows.Forms.Button();
            this.booksPanelBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.appNameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.userInfoLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.booksPanel = new System.Windows.Forms.Panel();
            this.addBookBtn = new System.Windows.Forms.Button();
            this.orderBooksBtn = new System.Windows.Forms.Button();
            this.booksPanelListView = new System.Windows.Forms.ListView();
            this.idCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.titleCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.authorCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ordersPanel = new System.Windows.Forms.Panel();
            this.ordersPanelListView = new System.Windows.Forms.ListView();
            this.orderIdCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderUsernameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderTotalCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewOrderBtn = new System.Windows.Forms.Button();
            this.requestsPanel = new System.Windows.Forms.Panel();
            this.delRequestBtn = new System.Windows.Forms.Button();
            this.requestsPanelListView = new System.Windows.Forms.ListView();
            this.colReqId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colReqTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colReqAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.requestBtn = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.booksPanel.SuspendLayout();
            this.ordersPanel.SuspendLayout();
            this.requestsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.leftPanel.Controls.Add(this.ordersPanelBtn);
            this.leftPanel.Controls.Add(this.requestsPanelBtn);
            this.leftPanel.Controls.Add(this.booksPanelBtn);
            this.leftPanel.Controls.Add(this.panel3);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(167, 411);
            this.leftPanel.TabIndex = 1;
            // 
            // ordersPanelBtn
            // 
            this.ordersPanelBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ordersPanelBtn.FlatAppearance.BorderSize = 0;
            this.ordersPanelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordersPanelBtn.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersPanelBtn.ForeColor = System.Drawing.Color.White;
            this.ordersPanelBtn.Image = global::LibraryApp.Properties.Resources.history_solid;
            this.ordersPanelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ordersPanelBtn.Location = new System.Drawing.Point(0, 232);
            this.ordersPanelBtn.Name = "ordersPanelBtn";
            this.ordersPanelBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ordersPanelBtn.Size = new System.Drawing.Size(167, 97);
            this.ordersPanelBtn.TabIndex = 2;
            this.ordersPanelBtn.Text = "     All Orders";
            this.ordersPanelBtn.UseVisualStyleBackColor = true;
            this.ordersPanelBtn.Click += new System.EventHandler(this.ordersPanelBtn_Click);
            // 
            // requestsPanelBtn
            // 
            this.requestsPanelBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.requestsPanelBtn.FlatAppearance.BorderSize = 0;
            this.requestsPanelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.requestsPanelBtn.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestsPanelBtn.ForeColor = System.Drawing.Color.White;
            this.requestsPanelBtn.Image = global::LibraryApp.Properties.Resources.concierge_bell_solid;
            this.requestsPanelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.requestsPanelBtn.Location = new System.Drawing.Point(0, 156);
            this.requestsPanelBtn.Name = "requestsPanelBtn";
            this.requestsPanelBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.requestsPanelBtn.Size = new System.Drawing.Size(167, 76);
            this.requestsPanelBtn.TabIndex = 4;
            this.requestsPanelBtn.Text = "   Requests";
            this.requestsPanelBtn.UseVisualStyleBackColor = true;
            this.requestsPanelBtn.Click += new System.EventHandler(this.requestsPanelBtn_Click);
            // 
            // booksPanelBtn
            // 
            this.booksPanelBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.booksPanelBtn.FlatAppearance.BorderSize = 0;
            this.booksPanelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.booksPanelBtn.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksPanelBtn.ForeColor = System.Drawing.Color.White;
            this.booksPanelBtn.Image = global::LibraryApp.Properties.Resources.book_open_solid;
            this.booksPanelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.booksPanelBtn.Location = new System.Drawing.Point(0, 63);
            this.booksPanelBtn.Name = "booksPanelBtn";
            this.booksPanelBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.booksPanelBtn.Size = new System.Drawing.Size(167, 93);
            this.booksPanelBtn.TabIndex = 1;
            this.booksPanelBtn.Text = "Books";
            this.booksPanelBtn.UseVisualStyleBackColor = true;
            this.booksPanelBtn.Click += new System.EventHandler(this.booksPanelBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.appNameLabel);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(167, 63);
            this.panel3.TabIndex = 0;
            // 
            // appNameLabel
            // 
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.appNameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(108)))), ((int)(((byte)(101)))));
            this.appNameLabel.Location = new System.Drawing.Point(52, 20);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(109, 25);
            this.appNameLabel.TabIndex = 5;
            this.appNameLabel.Text = "Library App";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(12, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 39);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.TopPanel.Controls.Add(this.userInfoLabel);
            this.TopPanel.Controls.Add(this.panel1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(167, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(617, 63);
            this.TopPanel.TabIndex = 2;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            // 
            // userInfoLabel
            // 
            this.userInfoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.userInfoLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.userInfoLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInfoLabel.ForeColor = System.Drawing.Color.White;
            this.userInfoLabel.Location = new System.Drawing.Point(286, 0);
            this.userInfoLabel.Name = "userInfoLabel";
            this.userInfoLabel.Size = new System.Drawing.Size(270, 63);
            this.userInfoLabel.TabIndex = 5;
            this.userInfoLabel.Text = "label1";
            this.userInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(556, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(61, 63);
            this.panel1.TabIndex = 6;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.Transparent;
            this.exitBtn.Image = global::LibraryApp.Properties.Resources.times_solid_pink;
            this.exitBtn.Location = new System.Drawing.Point(11, 12);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(38, 40);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // booksPanel
            // 
            this.booksPanel.Controls.Add(this.addBookBtn);
            this.booksPanel.Controls.Add(this.orderBooksBtn);
            this.booksPanel.Controls.Add(this.booksPanelListView);
            this.booksPanel.Location = new System.Drawing.Point(173, 69);
            this.booksPanel.Name = "booksPanel";
            this.booksPanel.Size = new System.Drawing.Size(599, 330);
            this.booksPanel.TabIndex = 3;
            // 
            // addBookBtn
            // 
            this.addBookBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(108)))), ((int)(((byte)(101)))));
            this.addBookBtn.FlatAppearance.BorderSize = 0;
            this.addBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBookBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addBookBtn.ForeColor = System.Drawing.Color.White;
            this.addBookBtn.Location = new System.Drawing.Point(334, 290);
            this.addBookBtn.Name = "addBookBtn";
            this.addBookBtn.Size = new System.Drawing.Size(128, 37);
            this.addBookBtn.TabIndex = 2;
            this.addBookBtn.Text = "Add Book";
            this.addBookBtn.UseVisualStyleBackColor = false;
            this.addBookBtn.Visible = false;
            this.addBookBtn.Click += new System.EventHandler(this.addBookBtn_Click);
            // 
            // orderBooksBtn
            // 
            this.orderBooksBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(108)))), ((int)(((byte)(101)))));
            this.orderBooksBtn.FlatAppearance.BorderSize = 0;
            this.orderBooksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderBooksBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.orderBooksBtn.ForeColor = System.Drawing.Color.White;
            this.orderBooksBtn.Location = new System.Drawing.Point(468, 290);
            this.orderBooksBtn.Name = "orderBooksBtn";
            this.orderBooksBtn.Size = new System.Drawing.Size(128, 37);
            this.orderBooksBtn.TabIndex = 1;
            this.orderBooksBtn.Text = "Order Selected Books";
            this.orderBooksBtn.UseVisualStyleBackColor = false;
            this.orderBooksBtn.Click += new System.EventHandler(this.orderBooksBtn_Click);
            // 
            // booksPanelListView
            // 
            this.booksPanelListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.booksPanelListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idCol,
            this.titleCol,
            this.authorCol,
            this.columnHeader1});
            this.booksPanelListView.ForeColor = System.Drawing.Color.White;
            this.booksPanelListView.HideSelection = false;
            this.booksPanelListView.Location = new System.Drawing.Point(3, 3);
            this.booksPanelListView.Name = "booksPanelListView";
            this.booksPanelListView.Size = new System.Drawing.Size(593, 281);
            this.booksPanelListView.TabIndex = 0;
            this.booksPanelListView.UseCompatibleStateImageBehavior = false;
            this.booksPanelListView.View = System.Windows.Forms.View.Details;
            // 
            // idCol
            // 
            this.idCol.Text = "Id";
            this.idCol.Width = 35;
            // 
            // titleCol
            // 
            this.titleCol.Text = "Title";
            this.titleCol.Width = 290;
            // 
            // authorCol
            // 
            this.authorCol.Text = "Author";
            this.authorCol.Width = 182;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Price";
            // 
            // ordersPanel
            // 
            this.ordersPanel.Controls.Add(this.ordersPanelListView);
            this.ordersPanel.Controls.Add(this.viewOrderBtn);
            this.ordersPanel.Location = new System.Drawing.Point(173, 69);
            this.ordersPanel.Name = "ordersPanel";
            this.ordersPanel.Size = new System.Drawing.Size(599, 330);
            this.ordersPanel.TabIndex = 4;
            // 
            // ordersPanelListView
            // 
            this.ordersPanelListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.ordersPanelListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.orderIdCol,
            this.orderUsernameCol,
            this.orderTotalCol});
            this.ordersPanelListView.ForeColor = System.Drawing.Color.White;
            this.ordersPanelListView.HideSelection = false;
            this.ordersPanelListView.Location = new System.Drawing.Point(3, 3);
            this.ordersPanelListView.Name = "ordersPanelListView";
            this.ordersPanelListView.Size = new System.Drawing.Size(593, 281);
            this.ordersPanelListView.TabIndex = 0;
            this.ordersPanelListView.UseCompatibleStateImageBehavior = false;
            this.ordersPanelListView.View = System.Windows.Forms.View.Details;
            // 
            // orderIdCol
            // 
            this.orderIdCol.Text = "Id";
            this.orderIdCol.Width = 35;
            // 
            // orderUsernameCol
            // 
            this.orderUsernameCol.Text = "Username";
            this.orderUsernameCol.Width = 430;
            // 
            // orderTotalCol
            // 
            this.orderTotalCol.Text = "Total";
            this.orderTotalCol.Width = 96;
            // 
            // viewOrderBtn
            // 
            this.viewOrderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(108)))), ((int)(((byte)(101)))));
            this.viewOrderBtn.FlatAppearance.BorderSize = 0;
            this.viewOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewOrderBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewOrderBtn.ForeColor = System.Drawing.Color.White;
            this.viewOrderBtn.Location = new System.Drawing.Point(468, 290);
            this.viewOrderBtn.Name = "viewOrderBtn";
            this.viewOrderBtn.Size = new System.Drawing.Size(128, 37);
            this.viewOrderBtn.TabIndex = 1;
            this.viewOrderBtn.Text = "View Selected Order";
            this.viewOrderBtn.UseVisualStyleBackColor = false;
            this.viewOrderBtn.Click += new System.EventHandler(this.viewOrderBtn_Click);
            // 
            // requestsPanel
            // 
            this.requestsPanel.Controls.Add(this.delRequestBtn);
            this.requestsPanel.Controls.Add(this.requestsPanelListView);
            this.requestsPanel.Controls.Add(this.requestBtn);
            this.requestsPanel.Location = new System.Drawing.Point(173, 69);
            this.requestsPanel.Name = "requestsPanel";
            this.requestsPanel.Size = new System.Drawing.Size(599, 330);
            this.requestsPanel.TabIndex = 5;
            // 
            // delRequestBtn
            // 
            this.delRequestBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(108)))), ((int)(((byte)(101)))));
            this.delRequestBtn.FlatAppearance.BorderSize = 0;
            this.delRequestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delRequestBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delRequestBtn.ForeColor = System.Drawing.Color.White;
            this.delRequestBtn.Location = new System.Drawing.Point(334, 290);
            this.delRequestBtn.Name = "delRequestBtn";
            this.delRequestBtn.Size = new System.Drawing.Size(150, 37);
            this.delRequestBtn.TabIndex = 2;
            this.delRequestBtn.Text = "Delete Selected Request";
            this.delRequestBtn.UseVisualStyleBackColor = false;
            this.delRequestBtn.Visible = false;
            this.delRequestBtn.Click += new System.EventHandler(this.delRequestBtn_Click);
            // 
            // requestsPanelListView
            // 
            this.requestsPanelListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.requestsPanelListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colReqId,
            this.colReqTitle,
            this.colReqAuthor});
            this.requestsPanelListView.ForeColor = System.Drawing.Color.White;
            this.requestsPanelListView.HideSelection = false;
            this.requestsPanelListView.Location = new System.Drawing.Point(3, 3);
            this.requestsPanelListView.Name = "requestsPanelListView";
            this.requestsPanelListView.Size = new System.Drawing.Size(593, 281);
            this.requestsPanelListView.TabIndex = 0;
            this.requestsPanelListView.UseCompatibleStateImageBehavior = false;
            this.requestsPanelListView.View = System.Windows.Forms.View.Details;
            // 
            // colReqId
            // 
            this.colReqId.Text = "Id";
            this.colReqId.Width = 35;
            // 
            // colReqTitle
            // 
            this.colReqTitle.Text = "Title";
            this.colReqTitle.Width = 290;
            // 
            // colReqAuthor
            // 
            this.colReqAuthor.Text = "Author";
            this.colReqAuthor.Width = 242;
            // 
            // requestBtn
            // 
            this.requestBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(108)))), ((int)(((byte)(101)))));
            this.requestBtn.FlatAppearance.BorderSize = 0;
            this.requestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.requestBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestBtn.ForeColor = System.Drawing.Color.White;
            this.requestBtn.Location = new System.Drawing.Point(490, 290);
            this.requestBtn.Name = "requestBtn";
            this.requestBtn.Size = new System.Drawing.Size(106, 37);
            this.requestBtn.TabIndex = 1;
            this.requestBtn.Text = "Request A Book";
            this.requestBtn.UseVisualStyleBackColor = false;
            this.requestBtn.Click += new System.EventHandler(this.requestBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(138)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.requestsPanel);
            this.Controls.Add(this.ordersPanel);
            this.Controls.Add(this.booksPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library App";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.leftPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.booksPanel.ResumeLayout(false);
            this.ordersPanel.ResumeLayout(false);
            this.requestsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Button booksPanelBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label appNameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel booksPanel;
        private System.Windows.Forms.ListView booksPanelListView;
        private System.Windows.Forms.ColumnHeader idCol;
        private System.Windows.Forms.ColumnHeader titleCol;
        private System.Windows.Forms.ColumnHeader authorCol;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button requestsPanelBtn;
        private System.Windows.Forms.Button orderBooksBtn;
        private System.Windows.Forms.Panel ordersPanel;
        private System.Windows.Forms.Button viewOrderBtn;
        private System.Windows.Forms.ListView ordersPanelListView;
        private System.Windows.Forms.ColumnHeader orderIdCol;
        private System.Windows.Forms.ColumnHeader orderUsernameCol;
        private System.Windows.Forms.ColumnHeader orderTotalCol;
        private System.Windows.Forms.Panel requestsPanel;
        private System.Windows.Forms.Button delRequestBtn;
        private System.Windows.Forms.ListView requestsPanelListView;
        private System.Windows.Forms.ColumnHeader colReqId;
        private System.Windows.Forms.ColumnHeader colReqTitle;
        private System.Windows.Forms.ColumnHeader colReqAuthor;
        private System.Windows.Forms.Button requestBtn;
        private System.Windows.Forms.Button addBookBtn;
        private System.Windows.Forms.Button ordersPanelBtn;
        private System.Windows.Forms.Label userInfoLabel;
        private System.Windows.Forms.Panel panel1;
    }
}