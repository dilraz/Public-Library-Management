namespace PublicLibraryApplication
{
    partial class request
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(request));
            this.label1 = new System.Windows.Forms.Label();
            this._gName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this._editButton = new System.Windows.Forms.Button();
            this._gEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(193, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(715, 106);
            this.label1.TabIndex = 8;
            this.label1.Text = "Request Book(S)";
            // 
            // _gName
            // 
            this._gName.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._gName.Location = new System.Drawing.Point(336, 26);
            this._gName.Multiline = true;
            this._gName.Name = "_gName";
            this._gName.Size = new System.Drawing.Size(548, 63);
            this._gName.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this._gEmail);
            this.panel1.Controls.Add(this._gName);
            this.panel1.Location = new System.Drawing.Point(68, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 224);
            this.panel1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(290, 43);
            this.label5.TabIndex = 2;
            this.label5.Text = "Enter Your Name";
            // 
            // _editButton
            // 
            this._editButton.BackColor = System.Drawing.Color.Maroon;
            this._editButton.Font = new System.Drawing.Font("Microsoft YaHei", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._editButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this._editButton.Location = new System.Drawing.Point(404, 451);
            this._editButton.Name = "_editButton";
            this._editButton.Size = new System.Drawing.Size(271, 74);
            this._editButton.TabIndex = 10;
            this._editButton.Text = "REQUEST";
            this._editButton.UseVisualStyleBackColor = false;
            this._editButton.Click += new System.EventHandler(this._editButton_Click);
            // 
            // _gEmail
            // 
            this._gEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._gEmail.Location = new System.Drawing.Point(336, 116);
            this._gEmail.Multiline = true;
            this._gEmail.Name = "_gEmail";
            this._gEmail.Size = new System.Drawing.Size(548, 63);
            this._gEmail.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 43);
            this.label4.TabIndex = 2;
            this.label4.Text = "Enter Your Email";
            // 
            // request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1096, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._editButton);
            this.Name = "request";
            this.Text = "request";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _gName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button _editButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _gEmail;
    }
}