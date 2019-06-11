namespace Lab12
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayBatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageStudentToolStripMenuItem,
            this.batchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageStudentToolStripMenuItem
            // 
            this.manageStudentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newStudentToolStripMenuItem,
            this.displayStudentsToolStripMenuItem});
            this.manageStudentToolStripMenuItem.Name = "manageStudentToolStripMenuItem";
            this.manageStudentToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.manageStudentToolStripMenuItem.Text = "Manage Student";
            // 
            // newStudentToolStripMenuItem
            // 
            this.newStudentToolStripMenuItem.Name = "newStudentToolStripMenuItem";
            this.newStudentToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.newStudentToolStripMenuItem.Text = "New Student";
            this.newStudentToolStripMenuItem.Click += new System.EventHandler(this.newStudentToolStripMenuItem_Click);
            // 
            // displayStudentsToolStripMenuItem
            // 
            this.displayStudentsToolStripMenuItem.Name = "displayStudentsToolStripMenuItem";
            this.displayStudentsToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.displayStudentsToolStripMenuItem.Text = "Display Students";
            this.displayStudentsToolStripMenuItem.Click += new System.EventHandler(this.displayStudentsToolStripMenuItem_Click);
            // 
            // batchToolStripMenuItem
            // 
            this.batchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBatchToolStripMenuItem,
            this.displayBatchToolStripMenuItem});
            this.batchToolStripMenuItem.Name = "batchToolStripMenuItem";
            this.batchToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.batchToolStripMenuItem.Text = "Batch";
            // 
            // newBatchToolStripMenuItem
            // 
            this.newBatchToolStripMenuItem.Name = "newBatchToolStripMenuItem";
            this.newBatchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newBatchToolStripMenuItem.Text = "New Batch";
            this.newBatchToolStripMenuItem.Click += new System.EventHandler(this.newBatchToolStripMenuItem_Click);
            // 
            // displayBatchToolStripMenuItem
            // 
            this.displayBatchToolStripMenuItem.Name = "displayBatchToolStripMenuItem";
            this.displayBatchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.displayBatchToolStripMenuItem.Text = "Display Batch";
            this.displayBatchToolStripMenuItem.Click += new System.EventHandler(this.displayBatchToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem batchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newBatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayBatchToolStripMenuItem;
    }
}

