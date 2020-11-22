namespace MoviesEF
{
    partial class MovieAddForm
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
            this.lName = new System.Windows.Forms.Label();
            this.lProductionYear = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbProductionYear = new System.Windows.Forms.ComboBox();
            this.lDirectors = new System.Windows.Forms.Label();
            this.tbBoxOffice = new System.Windows.Forms.TextBox();
            this.lbDirectors = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(12, 53);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(68, 25);
            this.lName.TabIndex = 0;
            this.lName.Text = "Name";
            // 
            // lProductionYear
            // 
            this.lProductionYear.AutoSize = true;
            this.lProductionYear.Location = new System.Drawing.Point(12, 104);
            this.lProductionYear.Name = "lProductionYear";
            this.lProductionYear.Size = new System.Drawing.Size(167, 25);
            this.lProductionYear.TabIndex = 0;
            this.lProductionYear.Text = "Production Year";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(240, 50);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(439, 31);
            this.tbName.TabIndex = 1;
            // 
            // cbProductionYear
            // 
            this.cbProductionYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductionYear.FormattingEnabled = true;
            this.cbProductionYear.Location = new System.Drawing.Point(240, 101);
            this.cbProductionYear.Name = "cbProductionYear";
            this.cbProductionYear.Size = new System.Drawing.Size(227, 33);
            this.cbProductionYear.TabIndex = 2;
            // 
            // lDirectors
            // 
            this.lDirectors.AutoSize = true;
            this.lDirectors.Location = new System.Drawing.Point(12, 206);
            this.lDirectors.Name = "lDirectors";
            this.lDirectors.Size = new System.Drawing.Size(98, 25);
            this.lDirectors.TabIndex = 0;
            this.lDirectors.Text = "Directors";
            // 
            // tbBoxOffice
            // 
            this.tbBoxOffice.Location = new System.Drawing.Point(240, 151);
            this.tbBoxOffice.Name = "tbBoxOffice";
            this.tbBoxOffice.Size = new System.Drawing.Size(439, 31);
            this.tbBoxOffice.TabIndex = 1;
            // 
            // lbDirectors
            // 
            this.lbDirectors.FormattingEnabled = true;
            this.lbDirectors.ItemHeight = 25;
            this.lbDirectors.Location = new System.Drawing.Point(240, 206);
            this.lbDirectors.Name = "lbDirectors";
            this.lbDirectors.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbDirectors.Size = new System.Drawing.Size(439, 229);
            this.lbDirectors.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Box Office Return";
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(383, 441);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(137, 44);
            this.bClear.TabIndex = 4;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MovieAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1291, 913);
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
            this.Name = "MovieAddForm";
            this.Text = "Add Movie";
            this.Load += new System.EventHandler(this.MovieAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lProductionYear;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox cbProductionYear;
        private System.Windows.Forms.Label lDirectors;
        private System.Windows.Forms.TextBox tbBoxOffice;
        private System.Windows.Forms.ListBox lbDirectors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button button1;
    }
}