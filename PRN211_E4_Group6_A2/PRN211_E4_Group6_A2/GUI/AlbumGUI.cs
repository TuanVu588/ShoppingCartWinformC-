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
    public partial class AlbumGUI : Form
    {
        MusicStoreContext context;
        public AlbumGUI()
        {
            InitializeComponent();
            context = new MusicStoreContext();
            cbGenre.DataSource = context.Genres.ToList();
            cbGenre.DisplayMember = "Name";
            cbGenre.ValueMember = "GenreId";
            bindGrid();
        }

        private void comGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindGrid();
        }

        private void bindGrid()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = context.Albums.Where(r => r.Genre.Name.Contains(cbGenre.Text)).ToList();
            dataGridView1.Columns["AlbumId"].Visible = false;
            dataGridView1.Columns["GenreId"].Visible = false;
            dataGridView1.Columns["Artist"].Visible = false;
            dataGridView1.Columns["OrderDetails"].Visible = false;
            dataGridView1.Columns["Carts"].Visible = false;
            dataGridView1.Columns["Genre"].Visible = false;
            int count = dataGridView1.Columns.Count;
            lbNumberAlbums.Text = $"The number of Albums:  {dataGridView1.Rows.Count}";
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn
            {
                Text = "Edit",
                Name = "Edit",
                UseColumnTextForButtonValue = true,
            };
            dataGridView1.Columns.Insert(count, btnEdit);

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn
            {
                Text = "Delete",
                Name = "Delete",
                UseColumnTextForButtonValue = true,
            };
            dataGridView1.Columns.Insert(count + 1, btnDelete);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
            {
                int albumId = (int)dataGridView1.Rows[e.RowIndex].Cells["AlbumId"].Value;
                DialogResult dr = MessageBox.Show("Do you want to delete?", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        var carts = context.Carts.Where(x => x.AlbumId == albumId).ToList();
                        var orderDetails = context.OrderDetails.Where(x => x.AlbumId == albumId).ToList();
                        context.RemoveRange(carts);
                        context.RemoveRange(orderDetails);
                        Album album = context.Albums.Find(albumId);
                        context.Albums.Remove(album);
                        context.SaveChanges();
                        MessageBox.Show("That album is deleted!");
                        bindGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index)
            {
                int albumId = (int)dataGridView1.Rows[e.RowIndex].Cells["AlbumId"].Value;
                AlbumAddEditGUI albumAddEditGUI = new AlbumAddEditGUI(albumId);
                DialogResult dr = albumAddEditGUI.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    context = new MusicStoreContext();
                    bindGrid();
                }

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = context.Albums.Where(r => r.Title.Contains(tbTitle.Text)).ToList();
            dataGridView1.Columns["AlbumId"].Visible = false;
            dataGridView1.Columns["GenreId"].Visible = false;
            dataGridView1.Columns["Artist"].Visible = false;
            dataGridView1.Columns["OrderDetails"].Visible = false;
            dataGridView1.Columns["Carts"].Visible = false;
            dataGridView1.Columns["Genre"].Visible = false;
            int count = dataGridView1.Columns.Count;
            lbNumberAlbums.Text = $"The number of Albums:  {dataGridView1.Rows.Count}";
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn
            {
                Text = "Edit",
                Name = "Edit",
                UseColumnTextForButtonValue = true,
            };
            dataGridView1.Columns.Insert(count, btnEdit);

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn
            {
                Text = "Delete",
                Name = "Delete",
                UseColumnTextForButtonValue = true,
            };
            dataGridView1.Columns.Insert(count + 1, btnDelete);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AlbumAddEditGUI albumAddEditGUI = new AlbumAddEditGUI(-1);
            DialogResult dr = albumAddEditGUI.ShowDialog();
            if (dr == DialogResult.OK)
                bindGrid();
        }
    }
}

