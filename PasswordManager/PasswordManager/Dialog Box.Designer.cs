namespace PasswordManager
{
    partial class dialog_Box
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
            this.dialog_Text = new System.Windows.Forms.Label();
            this.OK_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dialog_Text
            // 
            this.dialog_Text.AutoSize = true;
            this.dialog_Text.Location = new System.Drawing.Point(52, 45);
            this.dialog_Text.Name = "dialog_Text";
            this.dialog_Text.Size = new System.Drawing.Size(115, 13);
            this.dialog_Text.TabIndex = 0;
            this.dialog_Text.Text = "CLOSE APPLICATION";
            // 
            // OK_Btn
            // 
            this.OK_Btn.Location = new System.Drawing.Point(67, 76);
            this.OK_Btn.Name = "OK_Btn";
            this.OK_Btn.Size = new System.Drawing.Size(75, 23);
            this.OK_Btn.TabIndex = 1;
            this.OK_Btn.Text = "OK";
            this.OK_Btn.UseVisualStyleBackColor = true;
            this.OK_Btn.Click += new System.EventHandler(this.OK_Btn_Click);
            // 
            // dialog_Box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 123);
            this.Controls.Add(this.OK_Btn);
            this.Controls.Add(this.dialog_Text);
            this.Name = "dialog_Box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dialog_Text;
        private System.Windows.Forms.Button OK_Btn;
    }
}