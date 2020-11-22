using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoviesEF.Contexts;
using MoviesEF.Models;
using MoviesEF.Services;

namespace MoviesEF
{
    public partial class DirectorAddForm : Form
    {
        MoviesContext db = new MoviesContext();
        DirectorService directorService = new DirectorService();

        public DirectorAddForm()
        {
            InitializeComponent();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbName.Text))
                {
                    MessageBox.Show(lName.Text + " cannot be empty!");
                    return;
                }
                DirectorModel addDirectorModel = new DirectorModel();
                addDirectorModel.Name = tbName.Text;
                addDirectorModel.Surname = tbSurname.Text;
                if (rbYes.Checked)
                {
                    addDirectorModel.Retired = true;
                }
                else
                {
                    addDirectorModel.Retired = false;
                }
                directorService.Add(addDirectorModel);
                ClearDirector();
                MessageBox.Show("Director added!");
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            ClearDirector();
        }

        private void ClearDirector()
        {
            tbName.Clear();
            tbSurname.Clear();
            rbYes.Checked = false;
            rbNo.Checked = false;
        }
    }
}
