namespace MoviesEF
{
    partial class ReviewEditForm
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
            this.bSave = new System.Windows.Forms.Button();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.cbRating = new System.Windows.Forms.ComboBox();
            this.cbMovie = new System.Windows.Forms.ComboBox();
            this.lRating = new System.Windows.Forms.Label();
            this.lMovie = new System.Windows.Forms.Label();
            this.lContent = new System.Windows.Forms.Label();
            this.lId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(170, 402);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(167, 46);
            this.bSave.TabIndex = 12;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            // 
            // tbContent
            // 
            this.tbContent.Location = new System.Drawing.Point(170, 175);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(537, 221);
            this.tbContent.TabIndex = 10;
            // 
            // cbRating
            // 
            this.cbRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRating.FormattingEnabled = true;
            this.cbRating.Location = new System.Drawing.Point(170, 114);
            this.cbRating.Name = "cbRating";
            this.cbRating.Size = new System.Drawing.Size(299, 33);
            this.cbRating.TabIndex = 8;
            // 
            // cbMovie
            // 
            this.cbMovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMovie.FormattingEnabled = true;
            this.cbMovie.Location = new System.Drawing.Point(170, 59);
            this.cbMovie.Name = "cbMovie";
            this.cbMovie.Size = new System.Drawing.Size(299, 33);
            this.cbMovie.TabIndex = 9;
            // 
            // lRating
            // 
            this.lRating.AutoSize = true;
            this.lRating.Location = new System.Drawing.Point(32, 114);
            this.lRating.Name = "lRating";
            this.lRating.Size = new System.Drawing.Size(74, 25);
            this.lRating.TabIndex = 7;
            this.lRating.Text = "Rating";
            // 
            // lMovie
            // 
            this.lMovie.AutoSize = true;
            this.lMovie.Location = new System.Drawing.Point(32, 59);
            this.lMovie.Name = "lMovie";
            this.lMovie.Size = new System.Drawing.Size(70, 25);
            this.lMovie.TabIndex = 5;
            this.lMovie.Text = "Movie";
            // 
            // lContent
            // 
            this.lContent.AutoSize = true;
            this.lContent.Location = new System.Drawing.Point(32, 175);
            this.lContent.Name = "lContent";
            this.lContent.Size = new System.Drawing.Size(87, 25);
            this.lContent.TabIndex = 6;
            this.lContent.Text = "Content";
            // 
            // lId
            // 
            this.lId.AutoSize = true;
            this.lId.Location = new System.Drawing.Point(495, 59);
            this.lId.Name = "lId";
            this.lId.Size = new System.Drawing.Size(70, 25);
            this.lId.TabIndex = 13;
            this.lId.Text = "label1";
            this.lId.Visible = false;
            // 
            // ReviewEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 614);
            this.Controls.Add(this.lId);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.cbRating);
            this.Controls.Add(this.cbMovie);
            this.Controls.Add(this.lRating);
            this.Controls.Add(this.lMovie);
            this.Controls.Add(this.lContent);
            this.Name = "ReviewEditForm";
            this.Text = "ReviewEditForm";
            this.Load += new System.EventHandler(this.ReviewEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.TextBox tbContent;
        private System.Windows.Forms.ComboBox cbRating;
        private System.Windows.Forms.ComboBox cbMovie;
        private System.Windows.Forms.Label lRating;
        private System.Windows.Forms.Label lMovie;
        private System.Windows.Forms.Label lContent;
        public System.Windows.Forms.Label lId;
    }
}