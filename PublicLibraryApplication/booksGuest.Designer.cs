namespace PublicLibraryApplication
{
    partial class booksGuest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(booksGuest));
            this._refresh = new System.Windows.Forms.Button();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._name = new System.Windows.Forms.Label();
            this._msgError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._lstBooks = new System.Windows.Forms.ListView();
            this._id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._bName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._aName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._pages = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saveFileDialogBooks = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogBooks = new System.Windows.Forms.OpenFileDialog();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.goToHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _refresh
            // 
            this._refresh.BackColor = System.Drawing.SystemColors.ButtonFace;
            this._refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this._refresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this._refresh.FlatAppearance.BorderSize = 2;
            this._refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._refresh.Location = new System.Drawing.Point(989, 167);
            this._refresh.Name = "_refresh";
            this._refresh.Size = new System.Drawing.Size(114, 34);
            this._refresh.TabIndex = 12;
            this._refresh.Text = "Refresh List";
            this._refresh.UseVisualStyleBackColor = false;
            this._refresh.Click += new System.EventHandler(this._refresh_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // issueBookToolStripMenuItem
            // 
            this.issueBookToolStripMenuItem.Name = "issueBookToolStripMenuItem";
            this.issueBookToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.issueBookToolStripMenuItem.Text = "Request Book(s)";
            this.issueBookToolStripMenuItem.Click += new System.EventHandler(this.IssueBookToolStripMenuItem_Click);
            // 
            // searchBookToolStripMenuItem
            // 
            this.searchBookToolStripMenuItem.Name = "searchBookToolStripMenuItem";
            this.searchBookToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.searchBookToolStripMenuItem.Text = "Search Book";
            this.searchBookToolStripMenuItem.Click += new System.EventHandler(this.SearchBookToolStripMenuItem_Click);
            // 
            // _name
            // 
            this._name.AutoSize = true;
            this._name.BackColor = System.Drawing.Color.Transparent;
            this._name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._name.ForeColor = System.Drawing.Color.Red;
            this._name.Location = new System.Drawing.Point(448, 46);
            this._name.Name = "_name";
            this._name.Size = new System.Drawing.Size(0, 25);
            this._name.TabIndex = 11;
            // 
            // _msgError
            // 
            this._msgError.BackColor = System.Drawing.Color.RosyBrown;
            this._msgError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._msgError.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._msgError.Location = new System.Drawing.Point(55, 167);
            this._msgError.Name = "_msgError";
            this._msgError.Size = new System.Drawing.Size(1048, 34);
            this._msgError.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaShell;
            this.label1.Location = new System.Drawing.Point(163, 81);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(25, 5, 5, 5);
            this.label1.Size = new System.Drawing.Size(851, 71);
            this.label1.TabIndex = 8;
            this.label1.Text = "Windsor Public Library Books Directory";
            // 
            // _lstBooks
            // 
            this._lstBooks.BackColor = System.Drawing.Color.Snow;
            this._lstBooks.CheckBoxes = true;
            this._lstBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._id,
            this._bName,
            this._aName,
            this._pages});
            this._lstBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this._lstBooks.ForeColor = System.Drawing.SystemColors.InfoText;
            this._lstBooks.FullRowSelect = true;
            this._lstBooks.GridLines = true;
            this._lstBooks.HideSelection = false;
            this._lstBooks.Location = new System.Drawing.Point(45, 204);
            this._lstBooks.Name = "_lstBooks";
            this._lstBooks.Size = new System.Drawing.Size(1068, 594);
            this._lstBooks.TabIndex = 7;
            this._lstBooks.UseCompatibleStateImageBehavior = false;
            this._lstBooks.View = System.Windows.Forms.View.Details;
            this._lstBooks.DoubleClick += new System.EventHandler(this._lstBooks_DoubleClick);
            // 
            // _id
            // 
            this._id.Text = "BOOK ID";
            this._id.Width = 80;
            // 
            // _bName
            // 
            this._bName.Text = "BOOK NAME";
            this._bName.Width = 375;
            // 
            // _aName
            // 
            this._aName.Text = "AUTHOR NAME";
            this._aName.Width = 216;
            // 
            // _pages
            // 
            this._pages.Text = "NO OF PAGES";
            this._pages.Width = 102;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchBookToolStripMenuItem,
            this.issueBookToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.goToHomeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1168, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // goToHomeToolStripMenuItem
            // 
            this.goToHomeToolStripMenuItem.Name = "goToHomeToolStripMenuItem";
            this.goToHomeToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.goToHomeToolStripMenuItem.Text = "Go To Home";
            this.goToHomeToolStripMenuItem.Click += new System.EventHandler(this.GoToHomeToolStripMenuItem_Click);
            // 
            // booksGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1168, 834);
            this.Controls.Add(this._refresh);
            this.Controls.Add(this._name);
            this.Controls.Add(this._msgError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._lstBooks);
            this.Controls.Add(this.menuStrip1);
            this.Name = "booksGuest";
            this.Text = "Books Directory (Guest)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _refresh;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchBookToolStripMenuItem;
        private System.Windows.Forms.Label _name;
        private System.Windows.Forms.Label _msgError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView _lstBooks;
        private System.Windows.Forms.ColumnHeader _id;
        private System.Windows.Forms.ColumnHeader _bName;
        private System.Windows.Forms.ColumnHeader _aName;
        private System.Windows.Forms.ColumnHeader _pages;
        private System.Windows.Forms.SaveFileDialog saveFileDialogBooks;
        private System.Windows.Forms.OpenFileDialog openFileDialogBooks;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem goToHomeToolStripMenuItem;
    }
}