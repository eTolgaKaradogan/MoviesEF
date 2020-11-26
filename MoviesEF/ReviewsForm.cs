using MoviesEF.Contexts;
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
using MoviesEF.Entities;

namespace MoviesEF
{
    public partial class ReviewsForm : Form
    {
        MoviesContext db = new MoviesContext();
        ReviewsService reviewsService = new ReviewsService();
        public ReviewsForm()
        {
            InitializeComponent();
        }

        private void ReviewsForm_Load(object sender, EventArgs e)
        {
            FillReviews();
        }

        private void FillReviews()
        {
            dgvReviews.DataSource = reviewsService.List();
            dgvReviews.Columns["Id"].Visible = false;
        }

        private void deleteReviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvReviews.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a review!");
                return;
            }
            DialogResult result = MessageBox.Show("Do you want to delete?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int selectedReview = Convert.ToInt32(dgvReviews.SelectedRows[0].Cells["Id"].Value);
                Review review = db.Reviews.Find(selectedReview);
                db.Reviews.Remove(review);
                db.SaveChanges();
                MessageBox.Show("Review deleted!");
                FillReviews();
            }
        }

        private void editReviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvReviews.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a review!");
                return;
            }
            ReviewEditForm form = new ReviewEditForm();
            form.Show();
        }
    }
}
