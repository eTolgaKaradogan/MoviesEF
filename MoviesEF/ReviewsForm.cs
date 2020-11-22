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
    }
}
