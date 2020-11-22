namespace MoviesEF
{
    partial class MovieEditForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.lbDirectors = new System.Windows.Forms.ListBox();
            this.cbProductionYear = new System.Windows.Forms.ComboBox();
            this.tbBoxOffice = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lDirectors = new System.Windows.Forms.Label();
            this.lProductionYear = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.lId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 44);
            this.button1.TabIndex = 13;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(387, 414);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(137, 44);
            this.bClear.TabIndex = 14;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // lbDirectors
            // 
            this.lbDirectors.FormattingEnabled = true;
            this.lbDirectors.ItemHeight = 25;
            this.lbDirectors.Location = new System.Drawing.Point(244, 179);
            this.lbDirectors.Name = "lbDirectors";
            this.lbDirectors.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbDirectors.Size = new System.Drawing.Size(439, 229);
            this.lbDirectors.TabIndex = 12;
            // 
            // cbProductionYear
            // 
            this.cbProductionYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductionYear.FormattingEnabled = true;
            this.cbProductionYear.Location = new System.Drawing.Point(244, 74);
            this.cbProductionYear.Name = "cbProductionYear";
            this.cbProductionYear.Size = new System.Drawing.Size(227, 33);
            this.cbProductionYear.TabIndex = 11;
            // 
            // tbBoxOffice
            // 
            this.tbBoxOffice.Location = new System.Drawing.Point(244, 124);
            this.tbBoxOffice.Name = "tbBoxOffice";
            this.tbBoxOffice.Size = new System.Drawing.Size(439, 31);
            this.tbBoxOffice.TabIndex = 9;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(244, 23);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(439, 31);
            this.tbName.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Box Office Return";
            // 
            // lDirectors
            // 
            this.lDirectors.AutoSize = true;
            this.lDirectors.Location = new System.Drawing.Point(16, 179);
            this.lDirectors.Name = "lDirectors";
            this.lDirectors.Size = new System.Drawing.Size(98, 25);
            this.lDirectors.TabIndex = 6;
            this.lDirectors.Text = "Directors";
            // 
            // lProductionYear
            // 
            this.lProductionYear.AutoSize = true;
            this.lProductionYear.Location = new System.Drawing.Point(16, 77);
            this.lProductionYear.Name = "lProductionYear";
            this.lProductionYear.Size = new System.Drawing.Size(167, 25);
            this.lProductionYear.TabIndex = 7;
            this.lProductionYear.Text = "Production Year";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(16, 26);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(68, 25);
            this.lName.TabIndex = 8;
            this.lName.Text = "Name";
            // 
            // lId
            // 
            this.lId.AutoSize = true;
            this.lId.Location = new System.Drawing.Point(690, 23);
            this.lId.Name = "lId";
            this.lId.Size = new System.Drawing.Size(34, 25);
            this.lId.TabIndex = 15;
            this.lId.Text = "lId";
            this.lId.Visible = false;
            // 
            // MovieEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 770);
            this.Controls.Add(this.lId);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.lbDirectors);
            this.Controls.Add(this.cbProductionYear);
            this.Controls.Add(this.tbBoxOffice);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lDirectors);
            this.Controls.Add(this.lProductionYear);
            this.Controls.Add(this.lName);
            this.Name = "MovieEditForm";
            this.Text = "Edit Movie";
            this.Load += new System.EventHandler(this.MovieEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.ListBox lbDirectors;
        private System.Windows.Forms.ComboBox cbProductionYear;
        private System.Windows.Forms.TextBox tbBoxOffice;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lDirectors;
        private System.Windows.Forms.Label lProductionYear;
        private System.Windows.Forms.Label lName;
        public System.Windows.Forms.Label lId;
    }
}