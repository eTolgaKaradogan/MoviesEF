namespace MoviesEF
{
    partial class DirectorAddForm
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.bSave = new System.Windows.Forms.Button();
            this.lSurname = new System.Windows.Forms.Label();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.lRetired = new System.Windows.Forms.Label();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.bClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(13, 13);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(68, 25);
            this.lName.TabIndex = 0;
            this.lName.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(178, 10);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(309, 31);
            this.tbName.TabIndex = 1;
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(178, 158);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(150, 36);
            this.bSave.TabIndex = 2;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // lSurname
            // 
            this.lSurname.AutoSize = true;
            this.lSurname.Location = new System.Drawing.Point(13, 61);
            this.lSurname.Name = "lSurname";
            this.lSurname.Size = new System.Drawing.Size(98, 25);
            this.lSurname.TabIndex = 0;
            this.lSurname.Text = "Surname";
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(178, 58);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(309, 31);
            this.tbSurname.TabIndex = 1;
            // 
            // lRetired
            // 
            this.lRetired.AutoSize = true;
            this.lRetired.Location = new System.Drawing.Point(13, 110);
            this.lRetired.Name = "lRetired";
            this.lRetired.Size = new System.Drawing.Size(81, 25);
            this.lRetired.TabIndex = 3;
            this.lRetired.Text = "Retired";
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Location = new System.Drawing.Point(178, 108);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(81, 29);
            this.rbYes.TabIndex = 4;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "Yes";
            this.rbYes.UseVisualStyleBackColor = true;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(280, 108);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(70, 29);
            this.rbNo.TabIndex = 5;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(335, 158);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(152, 36);
            this.bClear.TabIndex = 6;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // DirectorAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 615);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.rbNo);
            this.Controls.Add(this.rbYes);
            this.Controls.Add(this.lRetired);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.lSurname);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lName);
            this.Name = "DirectorAddForm";
            this.Text = "Add Director";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Label lSurname;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label lRetired;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.Button bClear;
    }
}