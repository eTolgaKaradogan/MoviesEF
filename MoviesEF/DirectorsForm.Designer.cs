namespace MoviesEF
{
    partial class DirectorsForm
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
            this.dgvDirectors = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editDirectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDirectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirectors)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDirectors
            // 
            this.dgvDirectors.AllowUserToAddRows = false;
            this.dgvDirectors.AllowUserToDeleteRows = false;
            this.dgvDirectors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDirectors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDirectors.Location = new System.Drawing.Point(0, 42);
            this.dgvDirectors.Name = "dgvDirectors";
            this.dgvDirectors.ReadOnly = true;
            this.dgvDirectors.RowHeadersWidth = 82;
            this.dgvDirectors.RowTemplate.Height = 33;
            this.dgvDirectors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDirectors.Size = new System.Drawing.Size(1187, 758);
            this.dgvDirectors.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editDirectorToolStripMenuItem,
            this.deleteDirectorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1187, 42);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editDirectorToolStripMenuItem
            // 
            this.editDirectorToolStripMenuItem.Name = "editDirectorToolStripMenuItem";
            this.editDirectorToolStripMenuItem.Size = new System.Drawing.Size(167, 38);
            this.editDirectorToolStripMenuItem.Text = "Edit Director";
            this.editDirectorToolStripMenuItem.Click += new System.EventHandler(this.editDirectorToolStripMenuItem_Click);
            // 
            // deleteDirectorToolStripMenuItem
            // 
            this.deleteDirectorToolStripMenuItem.Name = "deleteDirectorToolStripMenuItem";
            this.deleteDirectorToolStripMenuItem.Size = new System.Drawing.Size(197, 38);
            this.deleteDirectorToolStripMenuItem.Text = "Delete Director";
            this.deleteDirectorToolStripMenuItem.Click += new System.EventHandler(this.deleteDirectorToolStripMenuItem_Click);
            // 
            // DirectorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 800);
            this.Controls.Add(this.dgvDirectors);
            this.Controls.Add(this.menuStrip1);
            this.Name = "DirectorsForm";
            this.Text = "DirectorsForm";
            this.Load += new System.EventHandler(this.DirectorsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirectors)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDirectors;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editDirectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDirectorToolStripMenuItem;
    }
}