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
using MoviesEF.Entities;
using MoviesEF.Models;
using MoviesEF.Services;

namespace MoviesEF
{
    public partial class ReviewAddForm : Form
    {
        MoviesContext db = new MoviesContext();
        ReviewsService reviewsService = new ReviewsService();
        MovieService movieService = new MovieService();
        public ReviewAddForm()
        {
            InitializeComponent();
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            cbMovie.SelectedIndex = 0;
            cbRating.SelectedIndex = 0;
            tbContent.Clear();
        }

        private void ReviewAddForm_Load(object sender, EventArgs e)
        {
            cbRating.Items.Add("Select");
            for (int i = 0; i < 11; i++)
            {
                cbRating.Items.Add(i);
            }
            cbRating.SelectedIndex = 0;
            FillMovies();
        }

        private void FillMovies()
        {
            cbMovie.DataSource = movieService.List();
            cbMovie.DisplayMember = "Name";
            cbMovie.ValueMember = "Id";
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbContent.Text) || cbMovie.SelectedIndex == 0 || cbRating.SelectedIndex == 0)
                {
                    MessageBox.Show("Fields cannot be empty!");
                    return;
                }
                ReviewModel addReviewModel = new ReviewModel();
                addReviewModel.Content = tbContent.Text;
                addReviewModel.Rating = Convert.ToInt32(cbRating.SelectedItem);
                addReviewModel.Movie = (Movie)cbMovie.SelectedItem;
                reviewsService.Add(addReviewModel);
                MessageBox.Show("Review added!");
            }
            catch (Exception exc)
            {
                MessageBox.Show(Convert.ToString(exc));
            }
        }
    }
}
