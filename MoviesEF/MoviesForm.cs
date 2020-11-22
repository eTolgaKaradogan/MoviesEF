using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoviesEF.Services;
using MoviesEF.Contexts;
using MoviesEF.Entities;

namespace MoviesEF
{
    public partial class MoviesForm : Form
    {
        MovieService service = new MovieService();
        MoviesContext db = new MoviesContext();
        public MoviesForm()
        {
            InitializeComponent();
        }

        private void MoviesForm_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void FillGrid()
        {
            try
            {
                dgvMovies.DataSource = service.List();
                dgvMovies.Columns["Id"].Visible = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error occured!");
            }
        }

        private void MoviesForm_Shown(object sender, EventArgs e)
        {
            dgvMovies.ClearSelection();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvMovies.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row!");
                return;
            }
            string id = dgvMovies.SelectedRows[0].Cells["Id"].Value.ToString();
            MovieEditForm form = new MovieEditForm();
            form.lId.Text = id; //başka formdan label,textbox vs kullanmak için labelin değerin özelliklerinde modified'ı public yapmak gerekir.
            form.Show();
        }

        private void deleteMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvMovies.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row!");
                return;
            }
            DialogResult result = MessageBox.Show("Do you want to delete selected movie?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int selectedMoviesId = Convert.ToInt32(dgvMovies.SelectedRows[0].Cells["Id"].Value);
                Movie movie = db.Movies.Find(selectedMoviesId);
                //List<MovieDirector> movieDirectors = movie.MovieDirectors.ToList();
                //db.MovieDirectors.RemoveRange(movieDirectors);
                db.Movies.Remove(movie);
                db.SaveChanges();
                MessageBox.Show("Movie is deleted!");
                FillGrid();
            }
        }
    }
}
