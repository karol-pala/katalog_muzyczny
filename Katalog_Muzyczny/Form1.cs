using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Katalog_Muzyczny
{
    public partial class Form1 : Form
    {
        Database DB;
        private int activeRowIndex;
        
        public Form1()
        {
            DB = new Database();
            
            InitializeComponent();
        }

        //interfejs
        private void msiAddAlbum_Click(object sender, EventArgs e)
        {
            gbAlbumList.Visible = false;
            gbFiltres.Visible = false;
            gbEditAlbum.Visible = false;
            gbAddAlbum.Visible = true;
            gbShortAlbumList.Visible = true;
        }

        private void msiEditAlbum_Click(object sender, EventArgs e)
        {
            gbAddAlbum.Visible = false;
            gbFiltres.Visible = false;
            gbAlbumList.Visible = false;
            gbEditAlbum.Visible = true;
            gbShortAlbumList.Visible = true;
        }

        private void btnAddAlbum_Click(object sender, EventArgs e)
        {
            Album album = new Album();
            if(tbAlbumName.Text != "")
            {
                if (tbAlbumArtist.Text != "")
                {
                    try
                    {
                        album.Name = tbAlbumName.Text;
                        album.Artist = tbAlbumArtist.Text;
                        album.Style = tbStyle.Text;
                        album.Label = tbLabel.Text;
                        album.Format = tbFormat.Text;
                        album.Year = Int32.Parse(tbYear.Text);
                        album.Country = tbCountry.Text;
                    } catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    

                    DB.InsertEntry(album);
                    
                    tbAlbumName.Text = null;
                    tbAlbumArtist.Text = null;
                    tbStyle.Text = null;
                    tbLabel.Text = null;
                    tbFormat.Text = null;
                    tbYear.Text = null;
                    tbCountry.Text = null;
                    
                } else
                {
                    MessageBox.Show("Podaj artystę");
                }
            }
            else
            {
                MessageBox.Show("Podaj nazwę albumu");
            }
            FillShortAlbumList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillShortAlbumList();
        }

        private void msiView_Click(object sender, EventArgs e)
        {
            gbAddAlbum.Visible = false;
            gbEditAlbum.Visible = false;
            gbShortAlbumList.Visible = false;
            gbAlbumList.Visible = true;
            gbFiltres.Visible = true;
            FillAlbumList();
        }

        //obsługa krótszej listy albumów

        private void FillShortAlbumList()
        {
            List<ShortAlbum> albums = new List<ShortAlbum>();
            int DBLength = DB.Entries();
            for(int i = 0; i < DBLength; i++)
            {
                Album album = new Album();
                DB.ReadEntry(i, ref album);
                ShortAlbum shortAlbum = new ShortAlbum();
                shortAlbum.Name = album.Name;
                shortAlbum.Artist = album.Artist;
                shortAlbum.Style = album.Style;
                albums.Add(shortAlbum);
            }
            dgvShortAlbumList.DataSource = albums;
        }

        private void dgvShortAlbumList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            activeRowIndex = e.RowIndex;
            SwitchEditForm(true);
            Album album = new Album();
            DB.ReadEntry(e.RowIndex, ref album);
            FillEditForm(album);
            if (TestEditForm() == true)
            {
                btnEditAlbum.Enabled = true;
                btnDeleteAlbum.Enabled = true;
            }
        }

        //obsługa dłuższej listy albumów

        private void FillAlbumList()
        {
            List<Album> albums = new List<Album>()
;
            int DBLength = DB.Entries();
            for(int i = 0; i < DBLength; i++)
            {
                Album album = new Album();
                DB.ReadEntry(i, ref album);
                albums.Add(album);
            }
            dgvAlbumList.DataSource = albums;
        }

        private void FilterAlbumList(string keys)
        {
            List<Album> album = new List<Album>();
            
        }
        
        //obsługa formularza do edycji

        private void SwitchEditForm(bool flag)
        {
            tbEditName.Enabled = flag;
            tbEditArtist.Enabled = flag;
            tbEditStyle.Enabled = flag;
            tbEditLabel.Enabled = flag;
            tbEditFormat.Enabled = flag;
            tbEditYear.Enabled = flag;
            tbEditCountry.Enabled = flag;
        }

        private void FillEditForm(Album album)
        {
            tbEditName.Text = album.Name;
            tbEditArtist.Text = album.Artist;
            tbEditStyle.Text = album.Style;
            tbEditLabel.Text = album.Label;
            tbEditFormat.Text = album.Format;
            tbEditYear.Text = album.Year.ToString();
            tbEditCountry.Text = album.Country;
        }

        private void ClearEditForm()
        {
            tbEditName.Text = "";
            tbEditArtist.Text = "";
            tbEditStyle.Text = "";
            tbEditLabel.Text = "";
            tbEditFormat.Text = "";
            tbEditYear.Text = "";
            tbEditCountry.Text = "";
        }
        
        private bool TestEditForm()
        {
            bool name = (tbEditName.Text != "");
            bool artist = (tbEditArtist.Text != "");
            

            if((name && artist) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnEditAlbum_Click(object sender, EventArgs e)
        {
            Album album = new Album();
            try
            {
                album.Name = tbEditName.Text;
                album.Artist = tbEditArtist.Text;
                album.Style = tbEditStyle.Text;
                album.Label = tbEditLabel.Text;
                album.Format = tbEditFormat.Text;
                album.Year = Int32.Parse(tbEditYear.Text);
                album.Country = tbEditCountry.Text;
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            DB.UpdateEntry(activeRowIndex, album);
            FillShortAlbumList();
            ClearEditForm();
            SwitchEditForm(false);
            btnEditAlbum.Enabled = false;
            btnDeleteAlbum.Enabled = false;
        }

        private void btnDeleteAlbum_Click(object sender, EventArgs e)
        {
            DB.DeleteEntry(activeRowIndex);
            FillShortAlbumList();
            ClearEditForm();
            SwitchEditForm(false);
            btnEditAlbum.Enabled = false;
            btnDeleteAlbum.Enabled = false;
        }

        //testy

        private void btnRead_Click(object sender, EventArgs e)
        {
            Album a = new Album();
            DB.ReadEntry(1, ref a);
            MessageBox.Show($"{a.Name};{a.Artist};{a.Style}");
            FillShortAlbumList();
        }

        //Wyszukiwanie

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(tbSearch.Text != "")
            {
                string key = tbSearch.Text;
                string id = "";
                List<Album> albums = new List<Album>();
                if(cbSearch.Text != "")
                {
                    switch (cbSearch.Text)
                    {
                        case "Nazwa":
                            id = DB.Select(key, 0);
                            break;
                        case "Artysta":
                            id = DB.Select(key, 1);
                            break;
                        case "Styl":
                            id = DB.Select(key, 2);
                            break;
                        case "Wydawnictwo":
                            id = DB.Select(key, 3);
                            break;
                        case "Format":
                            id = DB.Select(key, 4);
                            break;
                        case "Rok":
                            id = DB.Select(key, 5);
                            break;
                        case "Kraj":
                            id = DB.Select(key, 6);
                            break;
                    }
                    string[] ids = id.Split(';');
                    if(ids.Length > 1)
                    {
                        for (int j = 0; j < ids.Length; j++)
                        {
                            Album album = new Album();
                            string tempString = ids[j];

                            if (tempString != "")
                            {
                                int temp = Int32.Parse(tempString);
                                DB.ReadEntry(temp, ref album);
                                albums.Add(album);
                            }

                        }
                        dgvAlbumList.DataSource = albums;
                    } else
                    {
                        MessageBox.Show("Podana fraza nie istnieje w katalogu");
                    }
                    
                } else
                {
                    MessageBox.Show("Wybierz kolumnę do przeszukiwania");
                }
                
                
            } else
            {
                MessageBox.Show("Wpisz szukaną frazę");
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            FillAlbumList();
        }
    }
}
