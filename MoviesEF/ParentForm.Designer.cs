namespace MoviesEF
{
    partial class ParentForm
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
            this.moviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDirectorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reviewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listReviewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addReviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moviesToolStripMenuItem,
            this.directorsToolStripMenuItem,
            this.reviewsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1238, 42);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // moviesToolStripMenuItem
            // 
            this.moviesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listMoviesToolStripMenuItem,
            this.addMovieToolStripMenuItem});
            this.moviesToolStripMenuItem.Name = "moviesToolStripMenuItem";
            this.moviesToolStripMenuItem.Size = new System.Drawing.Size(112, 38);
            this.moviesToolStripMenuItem.Text = "Movies";
            // 
            // listMoviesToolStripMenuItem
            // 
            this.listMoviesToolStripMenuItem.Name = "listMoviesToolStripMenuItem";
            this.listMoviesToolStripMenuItem.Size = new System.Drawing.Size(268, 44);
            this.listMoviesToolStripMenuItem.Text = "List Movies";
            this.listMoviesToolStripMenuItem.Click += new System.EventHandler(this.listMoviesToolStripMenuItem_Click);
            // 
            // addMovieToolStripMenuItem
            // 
            this.addMovieToolStripMenuItem.Name = "addMovieToolStripMenuItem";
            this.addMovieToolStripMenuItem.Size = new System.Drawing.Size(268, 44);
            this.addMovieToolStripMenuItem.Text = "Add Movie";
            this.addMovieToolStripMenuItem.Click += new System.EventHandler(this.addMovieToolStripMenuItem_Click);
            // 
            // directorsToolStripMenuItem
            // 
            this.directorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dirToolStripMenuItem,
            this.addDirectorsToolStripMenuItem});
            this.directorsToolStripMenuItem.Name = "directorsToolStripMenuItem";
            this.directorsToolStripMenuItem.Size = new System.Drawing.Size(130, 38);
            this.directorsToolStripMenuItem.Text = "Directors";
            // 
            // dirToolStripMenuItem
            // 
            this.dirToolStripMenuItem.Name = "dirToolStripMenuItem";
            this.dirToolStripMenuItem.Size = new System.Drawing.Size(294, 44);
            this.dirToolStripMenuItem.Text = "List Directors";
            this.dirToolStripMenuItem.Click += new System.EventHandler(this.dirToolStripMenuItem_Click);
            // 
            // addDirectorsToolStripMenuItem
            // 
            this.addDirectorsToolStripMenuItem.Name = "addDirectorsToolStripMenuItem";
            this.addDirectorsToolStripMenuItem.Size = new System.Drawing.Size(294, 44);
            this.addDirectorsToolStripMenuItem.Text = "Add Directors";
            this.addDirectorsToolStripMenuItem.Click += new System.EventHandler(this.addDirectorsToolStripMenuItem_Click);
            // 
            // reviewsToolStripMenuItem
            // 
            this.reviewsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listReviewsToolStripMenuItem,
            this.addReviewToolStripMenuItem});
            this.reviewsToolStripMenuItem.Name = "reviewsToolStripMenuItem";
            this.reviewsToolStripMenuItem.Size = new System.Drawing.Size(119, 38);
            this.reviewsToolStripMenuItem.Text = "Reviews";
            // 
            // listReviewsToolStripMenuItem
            // 
            this.listReviewsToolStripMenuItem.Name = "listReviewsToolStripMenuItem";
            this.listReviewsToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.listReviewsToolStripMenuItem.Text = "List Reviews";
            this.listReviewsToolStripMenuItem.Click += new System.EventHandler(this.listReviewsToolStripMenuItem_Click);
            // 
            // addReviewToolStripMenuItem
            // 
            this.addReviewToolStripMenuItem.Name = "addReviewToolStripMenuItem";
            this.addReviewToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.addReviewToolStripMenuItem.Text = "Add Review";
            this.addReviewToolStripMenuItem.Click += new System.EventHandler(this.addReviewToolStripMenuItem_Click);
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1238, 846);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ParentForm";
            this.Text = "Movies EF";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem moviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listMoviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDirectorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reviewsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listReviewsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addReviewToolStripMenuItem;
    }
}

