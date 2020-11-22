using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviesEF
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }
        void ShowForm(Form form)
        {
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void listMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoviesForm form = new MoviesForm();
            ShowForm(form);
        }

        private void addMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MovieAddForm form = new MovieAddForm();
            ShowForm(form);
        }

        private void addDirectorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DirectorAddForm form = new DirectorAddForm();
            ShowForm(form);
        }

        private void dirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DirectorsForm form = new DirectorsForm();
            ShowForm(form);
        }

        private void listReviewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReviewsForm form = new ReviewsForm();
            ShowForm(form);
        }

        private void addReviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReviewAddForm form = new ReviewAddForm();
            ShowForm(form);
        }
    }
}
