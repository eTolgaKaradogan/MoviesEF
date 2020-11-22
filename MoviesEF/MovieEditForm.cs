using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
    public partial class MovieEditForm : Form
    {
        MovieService movieService = new MovieService();
        DirectorService directorService = new DirectorService();
        MoviesContext db = new MoviesContext();
        public MovieEditForm()
        {
            InitializeComponent();
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

        private void MovieEditForm_Load(object sender, EventArgs e)
        {
            try
            {
                FillYears();
                FillDirectors();
                var movieModel = movieService.Details(Convert.ToInt32(lId.Text));
                tbName.Text = movieModel.Name;
                tbBoxOffice.Text = movieModel.BoxOfficeReturn.HasValue ? movieModel.BoxOfficeReturn.Value.ToString() : "";
                cbProductionYear.Text = movieModel.ProductionYear;
                DirectorModel directorModel;
                for (int i = 0; i < lbDirectors.Items.Count; i++)
                {
                    directorModel = lbDirectors.Items[i] as DirectorModel;
                    foreach (var directorId in movieModel.DirectorIds)
                    {
                        if (directorModel.Id == directorId)
                        {
                            lbDirectors.SetSelected(i, true);
                            break;
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error occured!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MovieModel movieModel = movieService.Details(Convert.ToInt32(lId.Text));
                movieModel.Name = tbName.Text.Trim();
                movieModel.ProductionYear = cbProductionYear.Text;
                movieModel.BoxOfficeReturn = null;
                if (!string.IsNullOrWhiteSpace(tbBoxOffice.Text))
                {
                    movieModel.BoxOfficeReturn = Convert.ToDouble(tbBoxOffice.Text.Trim().Replace(",", "."), CultureInfo.InvariantCulture);
                }
                //todo:
                // listbox elemanlarının set edilmesi
                //DirectorModel directorModel;
                //for (int i = 0; i < lbDirectors.SelectedItems.Count; i++)
                //{
                //    directorModel = lbDirectors.SelectedItems[i] as DirectorModel;
                //    foreach (var selectedItem in movieModel.Id)
                //    {

                //    }
                //}
                //movieModel.Id = new List<int>();
                //List<int> newList = new List<int>();
                
                //DirectorModel directorModel;
                //foreach (var selectedItem in lbDirectors.SelectedItems)
                //{
                //    directorModel = selectedItem as DirectorModel;
                //    movieModel.Id.
                //    //DirectorModel.Id = selectedItem;
                //    //directorModel = selectedItem as DirectorModel;
                //    //movieModel.DirectorIds = directorModel.Id;
                //}
                    db.Entry(movieModel).State = EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Done!");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
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
