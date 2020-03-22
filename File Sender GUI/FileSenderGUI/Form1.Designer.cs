namespace FileSenderGUI
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
            this.IP = new System.Windows.Forms.TextBox();
            this.Port = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Messages = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SendFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // IP
            // 
            this.IP.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IP.ForeColor = System.Drawing.Color.Black;
            this.IP.Location = new System.Drawing.Point(12, 36);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(148, 26);
            this.IP.TabIndex = 1;
            // 
            // Port
            // 
            this.Port.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Port.ForeColor = System.Drawing.Color.Black;
            this.Port.Location = new System.Drawing.Point(166, 36);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(83, 26);
            this.Port.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Server IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(179, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port";
            // 
            // Messages
            // 
            this.Messages.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Messages.ForeColor = System.Drawing.Color.Black;
            this.Messages.Location = new System.Drawing.Point(12, 155);
            this.Messages.Name = "Messages";
            this.Messages.Size = new System.Drawing.Size(237, 195);
            this.Messages.TabIndex = 5;
            this.Messages.Text = "";
            this.Messages.TextChanged += new System.EventHandler(this.Messages_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(82, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Messages";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // SendFile
            // 
            this.SendFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SendFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendFile.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendFile.ForeColor = System.Drawing.Color.White;
            this.SendFile.Location = new System.Drawing.Point(12, 74);
            this.SendFile.Margin = new System.Windows.Forms.Padding(0);
            this.SendFile.Name = "SendFile";
            this.SendFile.Size = new System.Drawing.Size(237, 40);
            this.SendFile.TabIndex = 7;
            this.SendFile.Text = "Select and send file";
            this.SendFile.UseVisualStyleBackColor = false;
            this.SendFile.Click += new System.EventHandler(this.SendFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(262, 362);
            this.Controls.Add(this.SendFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Messages);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.IP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "File Sender";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox IP;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox Messages;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SendFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

