namespace MoviesEF
{
    partial class ReviewsForm
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
            this.dgvReviews = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviews)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReviews
            // 
            this.dgvReviews.AllowUserToAddRows = false;
            this.dgvReviews.AllowUserToDeleteRows = false;
            this.dgvReviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReviews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReviews.Location = new System.Drawing.Point(0, 0);
            this.dgvReviews.Name = "dgvReviews";
            this.dgvReviews.ReadOnly = true;
            this.dgvReviews.RowHeadersWidth = 82;
            this.dgvReviews.RowTemplate.Height = 33;
            this.dgvReviews.Size = new System.Drawing.Size(1016, 875);
            this.dgvReviews.TabIndex = 0;
            // 
            // ReviewsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 875);
            this.Controls.Add(this.dgvReviews);
            this.Name = "ReviewsForm";
            this.Text = "Reviews";
            this.Load += new System.EventHandler(this.ReviewsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviews)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReviews;
    }
}