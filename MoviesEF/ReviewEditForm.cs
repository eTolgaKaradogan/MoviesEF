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

namespace MoviesEF
{
    public partial class ReviewEditForm : Form
    {
        ReviewsService reviewsService = new ReviewsService();
        public ReviewEditForm()
        {
            InitializeComponent();
        }

        private void ReviewEditForm_Load(object sender, EventArgs e)
        {
            FillMovies();
            FillRatings();
            var reviewModel = reviewsService.Details(Convert.ToInt32(lId.Text));
            cbMovie.SelectedItem = reviewModel.Movie;
            cbRating.SelectedItem = reviewModel.Rating;
            tbContent.Text = reviewModel.Content;
        }

        private void FillRatings()
        {
            cbRating.Items.Add("Select");
            for (int i = 0; i < 11; i++)
            {
                cbRating.Items.Add(i);
            }
            cbRating.SelectedIndex = 0;
        }

        private void FillMovies()
        {
            cbMovie.DisplayMember = "Id";
            cbMovie.ValueMember = "Name";
            cbMovie.DataSource = reviewsService.Details(Convert.ToInt32(lId.Text));
        }
    }
}
