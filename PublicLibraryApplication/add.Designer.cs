﻿namespace PublicLibraryApplication
{
    partial class add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add));
            this.label1 = new System.Windows.Forms.Label();
            this._id = new System.Windows.Forms.TextBox();
            this._name = new System.Windows.Forms.TextBox();
            this._aName = new System.Windows.Forms.TextBox();
            this._pages = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._addButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(102, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(651, 106);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Book";
            // 
            // _id
            // 
            this._id.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._id.Location = new System.Drawing.Point(297, 25);
            this._id.Multiline = true;
            this._id.Name = "_id";
            this._id.Size = new System.Drawing.Size(474, 63);
            this._id.TabIndex = 1;
            this._id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._id_KeyPress);
            // 
            // _name
            // 
            this._name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._name.Location = new System.Drawing.Point(297, 108);
            this._name.Multiline = true;
            this._name.Name = "_name";
            this._name.Size = new System.Drawing.Size(474, 63);
            this._name.TabIndex = 1;
            // 
            // _aName
            // 
            this._aName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._aName.Location = new System.Drawing.Point(297, 189);
            this._aName.Multiline = true;
            this._aName.Name = "_aName";
            this._aName.Size = new System.Drawing.Size(474, 63);
            this._aName.TabIndex = 1;
            // 
            // _pages
            // 
            this._pages.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._pages.Location = new System.Drawing.Point(297, 277);
            this._pages.Multiline = true;
            this._pages.Name = "_pages";
            this._pages.Size = new System.Drawing.Size(474, 63);
            this._pages.TabIndex = 1;
            this._pages.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._pages_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 43);
            this.label2.TabIndex = 2;
            this.label2.Text = "Book ID";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this._pages);
            this.panel1.Controls.Add(this._id);
            this.panel1.Controls.Add(this._aName);
            this.panel1.Controls.Add(this._name);
            this.panel1.Location = new System.Drawing.Point(51, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 382);
            this.panel1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 43);
            this.label5.TabIndex = 2;
            this.label5.Text = "No of Pages";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 43);
            this.label4.TabIndex = 2;
            this.label4.Text = "Author Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 43);
            this.label3.TabIndex = 2;
            this.label3.Text = "Book Name";
            // 
            // _addButton
            // 
            this._addButton.BackColor = System.Drawing.Color.Maroon;
            this._addButton.Font = new System.Drawing.Font("Microsoft YaHei", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._addButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this._addButton.Location = new System.Drawing.Point(327, 528);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(271, 74);
            this._addButton.TabIndex = 4;
            this._addButton.Text = "ADD";
            this._addButton.UseVisualStyleBackColor = false;
            this._addButton.Click += new System.EventHandler(this._addButton_Click);
            // 
            // add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(935, 752);
            this.Controls.Add(this._addButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "add";
            this.Text = "add";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _id;
        private System.Windows.Forms.TextBox _name;
        private System.Windows.Forms.TextBox _aName;
        private System.Windows.Forms.TextBox _pages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button _addButton;
    }
}