namespace MoviesEF
{
    partial class ReviewAddForm
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
            this.lContent = new System.Windows.Forms.Label();
            this.lMovie = new System.Windows.Forms.Label();
            this.lRating = new System.Windows.Forms.Label();
            this.cbMovie = new System.Windows.Forms.ComboBox();
            this.cbRating = new System.Windows.Forms.ComboBox();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.bSave = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lContent
            // 
            this.lContent.AutoSize = true;
            this.lContent.Location = new System.Drawing.Point(30, 154);
            this.lContent.Name = "lContent";
            this.lContent.Size = new System.Drawing.Size(87, 25);
            this.lContent.TabIndex = 0;
            this.lContent.Text = "Content";
            // 
            // lMovie
            // 
            this.lMovie.AutoSize = true;
            this.lMovie.Location = new System.Drawing.Point(30, 38);
            this.lMovie.Name = "lMovie";
            this.lMovie.Size = new System.Drawing.Size(70, 25);
            this.lMovie.TabIndex = 0;
            this.lMovie.Text = "Movie";
            // 
            // lRating
            // 
            this.lRating.AutoSize = true;
            this.lRating.Location = new System.Drawing.Point(30, 93);
            this.lRating.Name = "lRating";
            this.lRating.Size = new System.Drawing.Size(74, 25);
            this.lRating.TabIndex = 1;
            this.lRating.Text = "Rating";
            // 
            // cbMovie
            // 
            this.cbMovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMovie.FormattingEnabled = true;
            this.cbMovie.Location = new System.Drawing.Point(168, 38);
            this.cbMovie.Name = "cbMovie";
            this.cbMovie.Size = new System.Drawing.Size(299, 33);
            this.cbMovie.TabIndex = 2;
            // 
            // cbRating
            // 
            this.cbRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRating.FormattingEnabled = true;
            this.cbRating.Location = new System.Drawing.Point(168, 93);
            this.cbRating.Name = "cbRating";
            this.cbRating.Size = new System.Drawing.Size(299, 33);
            this.cbRating.TabIndex = 2;
            // 
            // tbContent
            // 
            this.tbContent.Location = new System.Drawing.Point(168, 154);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(537, 221);
            this.tbContent.TabIndex = 3;
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(168, 381);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(167, 46);
            this.bSave.TabIndex = 4;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(341, 381);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(167, 46);
            this.bClear.TabIndex = 4;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // ReviewAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 790);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.cbRating);
            this.Controls.Add(this.cbMovie);
            this.Controls.Add(this.lRating);
            this.Controls.Add(this.lMovie);
            this.Controls.Add(this.lContent);
            this.Name = "ReviewAddForm";
            this.Text = "Add Review";
            this.Load += new System.EventHandler(this.ReviewAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lContent;
        private System.Windows.Forms.Label lMovie;
        private System.Windows.Forms.Label lRating;
        private System.Windows.Forms.ComboBox cbMovie;
        private System.Windows.Forms.ComboBox cbRating;
        private System.Windows.Forms.TextBox tbContent;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bClear;
    }
}