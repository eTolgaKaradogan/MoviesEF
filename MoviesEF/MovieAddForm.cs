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
using MoviesEF.Models;
using System.Globalization;

namespace MoviesEF
{
    public partial class MovieAddForm : Form
    {
        DirectorService directorService = new DirectorService();
        MovieService movieService = new MovieService();
        public MovieAddForm()
        {
            InitializeComponent();
        }

        private void MovieAddForm_Load(object sender, EventArgs e)
        {
            FillYears();
            FillDirectors();
        }

        private void FillDirectors()
        {
            try
            {
                lbDirectors.ValueMember = "Id";
                lbDirectors.DisplayMember = "FullName";
                lbDirectors.DataSource = directorService.List();
                lbDirectors.ClearSelected();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error occured!");
            }
        }

        private void FillYears()
        {
            cbProductionYear.Items.Clear();
            cbProductionYear.Items.Add("-- Select --");
            for (int i = DateTime.Now.Year + 1; i >= 1950; i--)
            {
                cbProductionYear.Items.Add(i);
            }
            cbProductionYear.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbName.Text) || cbProductionYear.SelectedIndex == 0 || lbDirectors.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Fields cannot be empty!");
                    return;
                }
                MovieModel addMovieModel = new MovieModel();
                addMovieModel.Name = tbName.Text.Trim();
                addMovieModel.ProductionYear = cbProductionYear.Text;
                addMovieModel.BoxOfficeReturn = null;
                if (!string.IsNullOrWhiteSpace(tbBoxOffice.Text))
                {
                    addMovieModel.BoxOfficeReturn = Convert.ToDouble(tbBoxOffice.Text.Trim().Replace(",", "."), CultureInfo.InvariantCulture);
                }
                addMovieModel.DirectorIds = new List<int>();
                foreach (var selectedItem in lbDirectors.SelectedItems)
                {
                    var directorModel = selectedItem as DirectorModel;
                    // var directorModel = (DirectorModel)selectedItem;     2.YOL
                    addMovieModel.DirectorIds.Add(directorModel.Id);                    
                }
                movieService.Add(addMovieModel);
                MessageBox.Show("Movie saved!");
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error occured!");
            }
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            tbName.Clear();
            cbProductionYear.SelectedIndex = 0;
            tbBoxOffice.Clear();
            lbDirectors.ClearSelected();
        }
    }
}
