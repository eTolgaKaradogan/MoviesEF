namespace MoviesEF
{
    partial class DirectorEditForm
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
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.lRetired = new System.Windows.Forms.Label();
            this.bSave = new System.Windows.Forms.Button();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.lSurname = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.Label();
            this.lId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(308, 137);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(70, 29);
            this.rbNo.TabIndex = 13;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Location = new System.Drawing.Point(206, 137);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(81, 29);
            this.rbYes.TabIndex = 12;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "Yes";
            this.rbYes.UseVisualStyleBackColor = true;
            // 
            // lRetired
            // 
            this.lRetired.AutoSize = true;
            this.lRetired.Location = new System.Drawing.Point(41, 139);
            this.lRetired.Name = "lRetired";
            this.lRetired.Size = new System.Drawing.Size(81, 25);
            this.lRetired.TabIndex = 11;
            this.lRetired.Text = "Retired";
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(206, 191);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(150, 36);
            this.bSave.TabIndex = 10;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(206, 87);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(309, 31);
            this.tbSurname.TabIndex = 8;
            // 
            // lSurname
            // 
            this.lSurname.AutoSize = true;
            this.lSurname.Location = new System.Drawing.Point(41, 90);
            this.lSurname.Name = "lSurname";
            this.lSurname.Size = new System.Drawing.Size(98, 25);
            this.lSurname.TabIndex = 6;
            this.lSurname.Text = "Surname";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(206, 39);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(309, 31);
            this.tbName.TabIndex = 9;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(41, 42);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(68, 25);
            this.lName.TabIndex = 7;
            this.lName.Text = "Name";
            // 
            // lId
            // 
            this.lId.AutoSize = true;
            this.lId.Location = new System.Drawing.Point(533, 39);
            this.lId.Name = "lId";
            this.lId.Size = new System.Drawing.Size(70, 25);
            this.lId.TabIndex = 14;
            this.lId.Text = "label1";
            this.lId.Visible = false;
            // 
            // DirectorEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 673);
            this.Controls.Add(this.lId);
            this.Controls.Add(this.rbNo);
            this.Controls.Add(this.rbYes);
            this.Controls.Add(this.lRetired);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.lSurname);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lName);
            this.Name = "DirectorEditForm";
            this.Text = "Edit Director";
            this.Load += new System.EventHandler(this.DirectorEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.Label lRetired;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label lSurname;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lName;
        public System.Windows.Forms.Label lId;
    }
}