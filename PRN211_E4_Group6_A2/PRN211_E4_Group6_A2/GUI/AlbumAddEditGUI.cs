using PRN211_E4_Group6_A2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN211_E4_Group6_A2.GUI
{
    public partial class AlbumAddEditGUI : Form
    {
        MusicStoreContext context;
        int id;
        public AlbumAddEditGUI(int albumId)
        {
            InitializeComponent();
            id = albumId;
            context = new MusicStoreContext();
            comGenre.DataSource = context.Genres.ToList<Genre>();
            comGenre.DisplayMember = "Name";
            comGenre.ValueMember = "GenreId";

            comArtist.DataSource = context.Artists.ToList<Artist>();
            comArtist.DisplayMember = "Name";
            comArtist.ValueMember = "ArtistId";


            if (albumId != -1)
            {
                Album album = context.Albums.Find(albumId);
                txtTitle.Text = album.Title;
                txtPrice.Text = album.Price.ToString();
                comGenre.SelectedIndex = album.GenreId - 1;
                comArtist.Text = context.Artists.Where(r => r.ArtistId == album.ArtistId).Select(r => r.Name).FirstOrDefault();
                txtImage.Text = album.AlbumUrl;
                try
                {
                    pictureBox1.Image = Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString() + txtImage.Text);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch
                {
                    pictureBox1.Image = null;
                }
            }
        }

        private void btnChose_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
            openFileDialog1.InitialDirectory = path + "\\Images";
            openFileDialog1.ShowDialog();
            txtImage.Text = "/Images/" + openFileDialog1.SafeFileName.ToString();
            try
            {
                pictureBox1.Image = Image.FromFile(path + txtImage.Text);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch
            {
                pictureBox1.Image = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id == -1)
            {
                Album album = new Album
                {
                    Title = txtTitle.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    GenreId = context.Genres.Where(r => r.Name == comGenre.Text).Select(r => r.GenreId).FirstOrDefault(),
                    ArtistId = context.Artists.Where(r => r.Name == comArtist.Text).Select(r => r.ArtistId).FirstOrDefault(),
                    AlbumUrl = txtImage.Text
                };

                try
                {
                    context.Albums.Add(album);
                    context.SaveChanges();
                    MessageBox.Show("That album was added!");
                }
                catch
                {
                    MessageBox.Show("Failled!");
                }
            }
            else
            {
                try
                {
                    Album album = context.Albums.Find(id);
                    album.Title = txtTitle.Text;
                    album.Price = decimal.Parse(txtPrice.Text);
                    album.GenreId = context.Genres.Where(r => r.Name == comGenre.Text).Select(r => r.GenreId).FirstOrDefault();
                    album.ArtistId = context.Artists.Where(r => r.Name == comArtist.Text).Select(r => r.ArtistId).FirstOrDefault();
                    album.AlbumUrl = txtImage.Text;
                    context.Albums.Update(album);
                    context.SaveChanges();
                    MessageBox.Show("That album was edited!");
                }
                catch
                {
                    MessageBox.Show("Failled!");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

