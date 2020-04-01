namespace PasswordManager
{
    partial class DB
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
            this.components = new System.ComponentModel.Container();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.titlenameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add_Entry_Btn = new System.Windows.Forms.Button();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.add_Entry_Btn);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(442, 386);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Entries";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(7, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 41);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(450, 412);
            this.tabControl1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.titlenameToolStripMenuItem,
            this.copyPasswordToolStripMenuItem,
            this.editEntryToolStripMenuItem,
            this.deleteEntryToolStripMenuItem,
            this.closeMenuToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(156, 114);
            // 
            // titlenameToolStripMenuItem
            // 
            this.titlenameToolStripMenuItem.Name = "titlenameToolStripMenuItem";
            this.titlenameToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.titlenameToolStripMenuItem.Text = "Titlename";
            // 
            // copyPasswordToolStripMenuItem
            // 
            this.copyPasswordToolStripMenuItem.Name = "copyPasswordToolStripMenuItem";
            this.copyPasswordToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.copyPasswordToolStripMenuItem.Text = "Copy password";
            // 
            // editEntryToolStripMenuItem
            // 
            this.editEntryToolStripMenuItem.Name = "editEntryToolStripMenuItem";
            this.editEntryToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.editEntryToolStripMenuItem.Text = "Edit entry";
            // 
            // deleteEntryToolStripMenuItem
            // 
            this.deleteEntryToolStripMenuItem.Name = "deleteEntryToolStripMenuItem";
            this.deleteEntryToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.deleteEntryToolStripMenuItem.Text = "Delete entry";
            // 
            // closeMenuToolStripMenuItem
            // 
            this.closeMenuToolStripMenuItem.Name = "closeMenuToolStripMenuItem";
            this.closeMenuToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.closeMenuToolStripMenuItem.Text = "Close menu";
            // 
            // add_Entry_Btn
            // 
            this.add_Entry_Btn.Location = new System.Drawing.Point(7, 19);
            this.add_Entry_Btn.Name = "add_Entry_Btn";
            this.add_Entry_Btn.Size = new System.Drawing.Size(75, 23);
            this.add_Entry_Btn.TabIndex = 2;
            this.add_Entry_Btn.Text = "Add Entry";
            this.add_Entry_Btn.UseVisualStyleBackColor = true;
            this.add_Entry_Btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // DB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 437);
            this.Controls.Add(this.tabControl1);
            this.Name = "DB";
            this.Text = "DB_name";
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem titlenameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeMenuToolStripMenuItem;
        private System.Windows.Forms.Button add_Entry_Btn;
    }
}