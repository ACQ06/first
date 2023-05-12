namespace first
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTheProgrammersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programsToolStripMenuItem,
            this.aboutTheProgrammersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(373, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programsToolStripMenuItem
            // 
            this.programsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorToolStripMenuItem,
            this.picturesToolStripMenuItem,
            this.treeviewToolStripMenuItem,
            this.listviewToolStripMenuItem});
            this.programsToolStripMenuItem.Name = "programsToolStripMenuItem";
            this.programsToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.programsToolStripMenuItem.Text = "Programs";
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            this.calculatorToolStripMenuItem.Click += new System.EventHandler(this.calculatorToolStripMenuItem_Click);
            // 
            // picturesToolStripMenuItem
            // 
            this.picturesToolStripMenuItem.Name = "picturesToolStripMenuItem";
            this.picturesToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.picturesToolStripMenuItem.Text = "Pictures";
            // 
            // treeviewToolStripMenuItem
            // 
            this.treeviewToolStripMenuItem.Name = "treeviewToolStripMenuItem";
            this.treeviewToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.treeviewToolStripMenuItem.Text = "Treeview";
            // 
            // listviewToolStripMenuItem
            // 
            this.listviewToolStripMenuItem.Name = "listviewToolStripMenuItem";
            this.listviewToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.listviewToolStripMenuItem.Text = "Listview";
            // 
            // aboutTheProgrammersToolStripMenuItem
            // 
            this.aboutTheProgrammersToolStripMenuItem.Name = "aboutTheProgrammersToolStripMenuItem";
            this.aboutTheProgrammersToolStripMenuItem.Size = new System.Drawing.Size(147, 20);
            this.aboutTheProgrammersToolStripMenuItem.Text = "About the programmers";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 239);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Form3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem picturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem treeviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutTheProgrammersToolStripMenuItem;
    }
}