using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoviesEF.Entities;
using MoviesEF.Services;
using MoviesEF.Contexts;

namespace MoviesEF
{
    public partial class DirectorsForm : Form
    {
        MoviesContext db = new MoviesContext();
        DirectorService directorService = new DirectorService();
        public DirectorsForm()
        {
            InitializeComponent();
        }

        private void DirectorsForm_Load(object sender, EventArgs e)
        {
            FillDirectors();
        }

        private void FillDirectors()
        {
            dgvDirectors.DataSource = directorService.List();
            dgvDirectors.ClearSelection();
            dgvDirectors.Columns["Id"].Visible = false;
            dgvDirectors.Columns["Name"].Visible = false;
            dgvDirectors.Columns["Surname"].Visible = false;
            dgvDirectors.Columns["FullName"].DisplayIndex = 0;
        }

        private void deleteDirectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDirectors.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a director!");
                return;
            }
            DialogResult result = MessageBox.Show("Do you want to delete director?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int selectedDirector = Convert.ToInt32(dgvDirectors.SelectedRows[0].Cells["Id"].Value);
                Director director = db.Directors.Find(selectedDirector);
                db.Directors.Remove(director);
                db.SaveChanges();
                MessageBox.Show("Director deleted!");
                FillDirectors();
            }
        }

        private void editDirectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDirectors.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a director!");
                return;
            }
            string id = dgvDirectors.SelectedRows[0].Cells["Id"].Value.ToString();
            DirectorEditForm form = new DirectorEditForm();
            form.lId.Text = id;
            form.Show();
        }
    }
}
