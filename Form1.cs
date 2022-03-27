using System;
using System.Windows.Forms;
using System.Drawing;

namespace Library_MyReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 1)
            {
                LoadListView(0);
                butBooksList.Enabled = false;
                butBooksDetailes.Enabled = true;
             
            }
        }
        private void LoadListView(int nbr)
        {
            listView1.Items.Clear();
            listView1.Columns.Clear();
            switch (nbr)
            {
                case 0:
                    listView1.View = View.LargeIcon;
                    break;
                case 1:
                    listView1.View = View.Details;
                    break;
            }
            ListViewItem item1 = new ListViewItem("Oxford", 0);
            item1.SubItems.Add("Anime");
            item1.SubItems.Add("Inconnu");
            ListViewItem item2 = new ListViewItem("didi", 1);
            item2.SubItems.Add("Anime");
            item2.SubItems.Add("Inconnu");
            ListViewItem item3 = new ListViewItem("kiki", 0);
            item3.SubItems.Add("Anime");
            item3.SubItems.Add("Inconnu");

            // Create columns for the items and subitems.
            listView1.Columns.Add("Pictures", listView1.Width / 3, HorizontalAlignment.Left);
            listView1.Columns.Add("Genre", listView1.Width / 3, HorizontalAlignment.Left);
            listView1.Columns.Add("Name of the Anime", listView1.Width / 3, HorizontalAlignment.Left);

            //Add the items to the ListView.
            listView1.Items.AddRange(new ListViewItem[] { item1, item2, item3 });

            // Create two ImageList objects.
            ImageList imageListSmall = new ImageList();
            ImageList imageListLarge = new ImageList();

            // Initialize the ImageList objects with bitmaps.
            //imageListSmall.Images.Add(Properties.Resources._1);
            //imageListSmall.Images.Add(Properties.Resources._2);
            //imageListLarge.Images.Add(Properties.Resources._1);
            //imageListLarge.Images.Add(Properties.Resources._2);
            //Assign the ImageList objects to the ListView.

            // set the siz to the Image
            imageListSmall.ImageSize = new Size(50, 50);
            imageListLarge.ImageSize = new Size(60, 80);

            listView1.LargeImageList = imageListLarge;
            listView1.SmallImageList = imageListSmall;

        }

        private void butBooksList_Click(object sender, EventArgs e)
        {
            LoadListView(0);
            butBooksList.Enabled = false;
            butBooksDetailes.Enabled = true;
        }

        private void butBooksDetailes_Click(object sender, EventArgs e)
        {
            LoadListView(1);
            butBooksList.Enabled = true;
            butBooksDetailes.Enabled = false;
        }


          
    }
}


