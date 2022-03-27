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
            ListViewItem item1 = new ListViewItem("All about the USA", 0);
            item1.SubItems.Add("Anime");
            item1.SubItems.Add("Inconnu");
            ListViewItem item2 = new ListViewItem("Women Who Changed the World", 1);
            item2.SubItems.Add("Anime");
            item2.SubItems.Add("Inconnu");
            ListViewItem item3 = new ListViewItem("Catch Me If You Can", 2);
            item3.SubItems.Add("Anime");
            item3.SubItems.Add("Inconnu");
            ListViewItem item4 = new ListViewItem("Amazing Architects and Artists", 3);
            item3.SubItems.Add("Anime");
            item3.SubItems.Add("Inconnu");
            ListViewItem item5 = new ListViewItem("A Ghost", 4);
            item3.SubItems.Add("Anime");
            item3.SubItems.Add("Inconnu");
            ListViewItem item6 = new ListViewItem("A Sea Change", 5);
            item3.SubItems.Add("Anime");
            item3.SubItems.Add("Inconnu");
            ListViewItem item7 = new ListViewItem("Death of the Eviction Man", 6);
            item3.SubItems.Add("Anime");
            item3.SubItems.Add("Inconnu");
            ListViewItem item8 = new ListViewItem("Barchester Towers", 7);
            item3.SubItems.Add("Anime");
            item3.SubItems.Add("Inconnu");
            ListViewItem item9 = new ListViewItem("Fear and Loathing in Las Vegas", 8);
            item3.SubItems.Add("Anime");
            item3.SubItems.Add("Inconnu");
            ListViewItem item10 = new ListViewItem("Peter Pan", 9);
            item3.SubItems.Add("Anime");
            item3.SubItems.Add("Inconnu");
            ListViewItem item11 = new ListViewItem("Amazing Thinkers and Humanitarians", 10);
            item3.SubItems.Add("Anime");
            item3.SubItems.Add("Inconnu");
            ListViewItem item12 = new ListViewItem("Oxford", 11);
            item3.SubItems.Add("Anime");
            item3.SubItems.Add("Inconnu");

            // Create columns for the items and subitems.
            listView1.Columns.Add("Pictures", listView1.Width / 3, HorizontalAlignment.Left);
            listView1.Columns.Add("Genre", listView1.Width / 3, HorizontalAlignment.Left);
            listView1.Columns.Add("Name of the Anime", listView1.Width / 3, HorizontalAlignment.Left);

            //Add the items to the ListView.
            listView1.Items.AddRange(new ListViewItem[] { item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12 });

            // Create two ImageList objects.
            ImageList imageListSmall = new ImageList();
            ImageList imageListLarge = new ImageList();

            // Initialize the ImageList objects with bitmaps.
            imageListSmall.Images.Add(Properties.Resources.All_about_the_USA_Emily_Winston);
            imageListSmall.Images.Add(Properties.Resources.Women_Who_Changed_the_World_Sue_Leather);
            imageListSmall.Images.Add(Properties.Resources.Catch_Me_If_You_Can_Frank_W_Abagnale);
            imageListSmall.Images.Add(Properties.Resources.Amazing_Architects_and_Artists_FH_Cornish);
            imageListSmall.Images.Add(Properties.Resources.A_Ghost_Robert_Harris);
            imageListSmall.Images.Add(Properties.Resources.A_Sea_Change_Veronica_Henry);
            imageListSmall.Images.Add(Properties.Resources.Death_of_the_Eviction_Man_Gayle_Tiller);
            imageListSmall.Images.Add(Properties.Resources.Barchester_Towers_Anthony_Trollope);
            imageListSmall.Images.Add(Properties.Resources.Fear_and_Loathing_in_Las_Vegas_Hunter_S_Thompson);
            imageListSmall.Images.Add(Properties.Resources.Peter_Pan_J_M_Barrie);
            imageListSmall.Images.Add(Properties.Resources.Amazing_Thinkers_and_Humanitarians_Katerina_Mestheneou);
            imageListSmall.Images.Add(Properties.Resources.Oxford_Hopkins_Andy);



            imageListLarge.Images.Add(Properties.Resources.All_about_the_USA_Emily_Winston);
            imageListLarge.Images.Add(Properties.Resources.Women_Who_Changed_the_World_Sue_Leather);
            imageListLarge.Images.Add(Properties.Resources.Catch_Me_If_You_Can_Frank_W_Abagnale);
            imageListLarge.Images.Add(Properties.Resources.Amazing_Architects_and_Artists_FH_Cornish);
            imageListLarge.Images.Add(Properties.Resources.A_Ghost_Robert_Harris);
            imageListLarge.Images.Add(Properties.Resources.A_Sea_Change_Veronica_Henry);
            imageListLarge.Images.Add(Properties.Resources.Death_of_the_Eviction_Man_Gayle_Tiller);
            imageListLarge.Images.Add(Properties.Resources.Barchester_Towers_Anthony_Trollope);
            imageListLarge.Images.Add(Properties.Resources.Fear_and_Loathing_in_Las_Vegas_Hunter_S_Thompson);
            imageListLarge.Images.Add(Properties.Resources.Peter_Pan_J_M_Barrie);
            imageListLarge.Images.Add(Properties.Resources.Amazing_Thinkers_and_Humanitarians_Katerina_Mestheneou);
            imageListLarge.Images.Add(Properties.Resources.Oxford_Hopkins_Andy);

            //Assign the ImageList objects to the ListView.

            // set the siz to the Image
            imageListSmall.ImageSize = new Size(60, 80);
            imageListLarge.ImageSize = new Size(80, 120);

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


