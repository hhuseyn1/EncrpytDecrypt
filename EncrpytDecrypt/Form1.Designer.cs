namespace EncrpytDecrypt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Encryptbtn = new System.Windows.Forms.RadioButton();
            this.Decryptbtn = new System.Windows.Forms.RadioButton();
            this.Filebtn = new System.Windows.Forms.Button();
            this.Passwordlbl = new System.Windows.Forms.Label();
            this.FilePathtxtbox = new System.Windows.Forms.TextBox();
            this.Passwordtxtbox = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Startbtn = new System.Windows.Forms.Button();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Encryptbtn
            // 
            this.Encryptbtn.AutoSize = true;
            this.Encryptbtn.Location = new System.Drawing.Point(292, 103);
            this.Encryptbtn.Name = "Encryptbtn";
            this.Encryptbtn.Size = new System.Drawing.Size(65, 19);
            this.Encryptbtn.TabIndex = 0;
            this.Encryptbtn.TabStop = true;
            this.Encryptbtn.Text = "Encrpyt";
            this.Encryptbtn.UseVisualStyleBackColor = true;
            // 
            // Decryptbtn
            // 
            this.Decryptbtn.AutoSize = true;
            this.Decryptbtn.Location = new System.Drawing.Point(384, 106);
            this.Decryptbtn.Name = "Decryptbtn";
            this.Decryptbtn.Size = new System.Drawing.Size(66, 19);
            this.Decryptbtn.TabIndex = 1;
            this.Decryptbtn.TabStop = true;
            this.Decryptbtn.Text = "Decrypt";
            this.Decryptbtn.UseVisualStyleBackColor = true;
            // 
            // Filebtn
            // 
            this.Filebtn.Location = new System.Drawing.Point(12, 27);
            this.Filebtn.Name = "Filebtn";
            this.Filebtn.Size = new System.Drawing.Size(75, 23);
            this.Filebtn.TabIndex = 2;
            this.Filebtn.Text = "File";
            this.Filebtn.UseVisualStyleBackColor = true;
            this.Filebtn.Click += new System.EventHandler(this.Filebtn_Click);
            // 
            // Passwordlbl
            // 
            this.Passwordlbl.AutoSize = true;
            this.Passwordlbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Passwordlbl.Location = new System.Drawing.Point(12, 103);
            this.Passwordlbl.Name = "Passwordlbl";
            this.Passwordlbl.Size = new System.Drawing.Size(66, 17);
            this.Passwordlbl.TabIndex = 3;
            this.Passwordlbl.Text = "Password";
            // 
            // FilePathtxtbox
            // 
            this.FilePathtxtbox.Location = new System.Drawing.Point(113, 27);
            this.FilePathtxtbox.Name = "FilePathtxtbox";
            this.FilePathtxtbox.Size = new System.Drawing.Size(373, 23);
            this.FilePathtxtbox.TabIndex = 4;
            // 
            // Passwordtxtbox
            // 
            this.Passwordtxtbox.Location = new System.Drawing.Point(84, 102);
            this.Passwordtxtbox.Name = "Passwordtxtbox";
            this.Passwordtxtbox.Size = new System.Drawing.Size(180, 23);
            this.Passwordtxtbox.TabIndex = 5;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 148);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(474, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // Startbtn
            // 
            this.Startbtn.Location = new System.Drawing.Point(316, 205);
            this.Startbtn.Name = "Startbtn";
            this.Startbtn.Size = new System.Drawing.Size(75, 23);
            this.Startbtn.TabIndex = 7;
            this.Startbtn.Text = "Start";
            this.Startbtn.UseVisualStyleBackColor = true;
            this.Startbtn.Click += new System.EventHandler(this.Startbtn_Click);
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Location = new System.Drawing.Point(411, 205);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.Cancelbtn.TabIndex = 8;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 261);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.Startbtn);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Passwordtxtbox);
            this.Controls.Add(this.FilePathtxtbox);
            this.Controls.Add(this.Passwordlbl);
            this.Controls.Add(this.Filebtn);
            this.Controls.Add(this.Decryptbtn);
            this.Controls.Add(this.Encryptbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton Encryptbtn;
        private RadioButton Decryptbtn;
        private Button Filebtn;
        private Label Passwordlbl;
        private TextBox FilePathtxtbox;
        private TextBox Passwordtxtbox;
        private ProgressBar progressBar1;
        private Button Startbtn;
        private Button Cancelbtn;
    }
}