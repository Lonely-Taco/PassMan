namespace PasswordManager
{
    partial class new_DB
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
            this.label_DB_name = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.new_DB_text = new System.Windows.Forms.TextBox();
            this.new_db_pass_text = new System.Windows.Forms.TextBox();
            this.crte_new_DB_Btn = new System.Windows.Forms.Button();
            this.cancle_crte_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_DB_name
            // 
            this.label_DB_name.AutoSize = true;
            this.label_DB_name.Location = new System.Drawing.Point(87, 44);
            this.label_DB_name.Name = "label_DB_name";
            this.label_DB_name.Size = new System.Drawing.Size(82, 13);
            this.label_DB_name.TabIndex = 0;
            this.label_DB_name.Text = "Database name";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(87, 80);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(53, 13);
            this.label_Password.TabIndex = 1;
            this.label_Password.Text = "Password";
            // 
            // new_DB_text
            // 
            this.new_DB_text.Location = new System.Drawing.Point(249, 44);
            this.new_DB_text.Name = "new_DB_text";
            this.new_DB_text.Size = new System.Drawing.Size(100, 20);
            this.new_DB_text.TabIndex = 2;
            // 
            // new_db_pass_text
            // 
            this.new_db_pass_text.Location = new System.Drawing.Point(249, 80);
            this.new_db_pass_text.Name = "new_db_pass_text";
            this.new_db_pass_text.Size = new System.Drawing.Size(100, 20);
            this.new_db_pass_text.TabIndex = 3;
            this.new_db_pass_text.UseSystemPasswordChar = true;
            // 
            // crte_new_DB_Btn
            // 
            this.crte_new_DB_Btn.Location = new System.Drawing.Point(249, 128);
            this.crte_new_DB_Btn.Name = "crte_new_DB_Btn";
            this.crte_new_DB_Btn.Size = new System.Drawing.Size(146, 23);
            this.crte_new_DB_Btn.TabIndex = 4;
            this.crte_new_DB_Btn.Text = "Create new database";
            this.crte_new_DB_Btn.UseVisualStyleBackColor = true;
            // 
            // cancle_crte_Btn
            // 
            this.cancle_crte_Btn.Location = new System.Drawing.Point(249, 171);
            this.cancle_crte_Btn.Name = "cancle_crte_Btn";
            this.cancle_crte_Btn.Size = new System.Drawing.Size(146, 23);
            this.cancle_crte_Btn.TabIndex = 5;
            this.cancle_crte_Btn.Text = "Cancel";
            this.cancle_crte_Btn.UseVisualStyleBackColor = true;
            this.cancle_crte_Btn.Click += new System.EventHandler(this.cancle_crte_Btn_Click);
            // 
            // new_DB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 277);
            this.Controls.Add(this.cancle_crte_Btn);
            this.Controls.Add(this.crte_new_DB_Btn);
            this.Controls.Add(this.new_db_pass_text);
            this.Controls.Add(this.new_DB_text);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_DB_name);
            this.Name = "new_DB";
            this.Text = " New Database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_DB_name;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox new_DB_text;
        private System.Windows.Forms.TextBox new_db_pass_text;
        private System.Windows.Forms.Button crte_new_DB_Btn;
        private System.Windows.Forms.Button cancle_crte_Btn;
    }
}