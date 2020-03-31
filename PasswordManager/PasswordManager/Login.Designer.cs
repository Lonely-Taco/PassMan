namespace PasswordManager
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.MP_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MP_Input = new System.Windows.Forms.TextBox();
            this.Choose_Btn = new System.Windows.Forms.Button();
            this.NewDB = new System.Windows.Forms.Button();
            this.Okay_Btn = new System.Windows.Forms.Button();
            this.Cancel_Btn = new System.Windows.Forms.Button();
            this.Choose = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // MP_label
            // 
            this.MP_label.AutoSize = true;
            this.MP_label.Location = new System.Drawing.Point(82, 106);
            this.MP_label.Name = "MP_label";
            this.MP_label.Size = new System.Drawing.Size(88, 13);
            this.MP_label.TabIndex = 1;
            this.MP_label.Text = "Master Password";
            this.MP_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Choose Database";
            // 
            // MP_Input
            // 
            this.MP_Input.Location = new System.Drawing.Point(198, 103);
            this.MP_Input.Name = "MP_Input";
            this.MP_Input.Size = new System.Drawing.Size(100, 20);
            this.MP_Input.TabIndex = 3;
            this.MP_Input.UseSystemPasswordChar = true;
            // 
            // Choose_Btn
            // 
            this.Choose_Btn.Location = new System.Drawing.Point(198, 50);
            this.Choose_Btn.Name = "Choose_Btn";
            this.Choose_Btn.Size = new System.Drawing.Size(75, 23);
            this.Choose_Btn.TabIndex = 4;
            this.Choose_Btn.Text = "choose";
            this.Choose_Btn.UseVisualStyleBackColor = true;
            this.Choose_Btn.Click += new System.EventHandler(this.Choose_Btn_Click);
            // 
            // NewDB
            // 
            this.NewDB.Location = new System.Drawing.Point(70, 152);
            this.NewDB.Name = "NewDB";
            this.NewDB.Size = new System.Drawing.Size(126, 23);
            this.NewDB.TabIndex = 5;
            this.NewDB.Text = "New Database";
            this.NewDB.UseVisualStyleBackColor = true;
            this.NewDB.Click += new System.EventHandler(this.NewDB_Click);
            // 
            // Okay_Btn
            // 
            this.Okay_Btn.Location = new System.Drawing.Point(321, 101);
            this.Okay_Btn.Name = "Okay_Btn";
            this.Okay_Btn.Size = new System.Drawing.Size(75, 23);
            this.Okay_Btn.TabIndex = 6;
            this.Okay_Btn.Text = "Okay";
            this.Okay_Btn.UseVisualStyleBackColor = true;
            this.Okay_Btn.Click += new System.EventHandler(this.Okay_Btn_Click);
            // 
            // Cancel_Btn
            // 
            this.Cancel_Btn.Location = new System.Drawing.Point(429, 101);
            this.Cancel_Btn.Name = "Cancel_Btn";
            this.Cancel_Btn.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Btn.TabIndex = 7;
            this.Cancel_Btn.Text = "Cancel";
            this.Cancel_Btn.UseVisualStyleBackColor = true;
            this.Cancel_Btn.Click += new System.EventHandler(this.Cancel_Btn_Click);
            // 
            // Choose
            // 
            this.Choose.FileName = "Database";
            this.Choose.FileOk += new System.ComponentModel.CancelEventHandler(this.Choose_FileOk);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 208);
            this.Controls.Add(this.Cancel_Btn);
            this.Controls.Add(this.Okay_Btn);
            this.Controls.Add(this.NewDB);
            this.Controls.Add(this.Choose_Btn);
            this.Controls.Add(this.MP_Input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MP_label);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Password Manager";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MP_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MP_Input;
        private System.Windows.Forms.Button Choose_Btn;
        private System.Windows.Forms.Button NewDB;
        private System.Windows.Forms.Button Okay_Btn;
        private System.Windows.Forms.Button Cancel_Btn;
        private System.Windows.Forms.OpenFileDialog Choose;
    }
}

