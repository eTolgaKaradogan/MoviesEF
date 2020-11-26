using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoviesEF.Models;
using MoviesEF.Services;
using MoviesEF.Contexts;
using System.Data.Entity;
using MoviesEF.Entities;

namespace MoviesEF
{
    public partial class DirectorEditForm : Form
    {
        DirectorService directorService = new DirectorService();
        MoviesContext db = new MoviesContext();

        public DirectorEditForm()
        {
            InitializeComponent();
        }

        private void DirectorEditForm_Load(object sender, EventArgs e)
        {
            try
            {
                var directorModel = directorService.Details(Convert.ToInt32(lId.Text));
                tbName.Text = directorModel.Name;
                tbSurname.Text = directorModel.Surname;
                if (directorModel.Retired == true)
                {
                    rbYes.Checked = true;
                }
                else
                {
                    rbNo.Checked = true;
                }
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbName.Text) || string.IsNullOrWhiteSpace(tbSurname.Text))
                {
                    MessageBox.Show("Fields cannot be empty!");
                    return;
                }
                //var directorModel = db.Directors.SingleOrDefault(d => d.Id == Convert.ToInt32(lId.Text));
                var directorModel = directorService.Details(Convert.ToInt32(lId.Text));
                directorModel.Name = tbName.Text.Trim();
                directorModel.Surname = tbSurname.Text.Trim();
                if (rbYes.Checked)
                {
                    directorModel.Retired = true;
                }
                else
                {
                    directorModel.Retired = false;
                }
                db.Entry(directorModel).State = EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Changes saved!");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }

        }
    }
}
