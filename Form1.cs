using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.IO;

namespace Library_MyReader
{
    public partial class Form1 : Form
    {
        private int SelectedImageIndex = 0;
        private List<Image> LoadedImages { get; set; }
       // private List<Image> image { get; set; }
       // private List<string> LoadedTexts { get; set; }
     
        private string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"images");
      

        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (tabControl.SelectedIndex == 1)
            //{
            //    //LoadListView(0);
            //    //butBooksList.Enabled = false;
            //    //butBooksDetailes.Enabled = true;

            //}
            if (tabControl.SelectedIndex == 1)
            {
                var di = Directory.GetFiles(path);
                LoadImagesFromFolder(di);
                InitListView();


            }
        }
        //private void LoadListView(int nbr)
        //{ 
        //    switch (nbr)
        //    {
        //        case 0:
        //            listView1.View = View.LargeIcon;
        //            break;
        //        case 1:
        //            listView1.View = View.Details;
        //            break;
        //    }
        //    ListViewItem item1 = new ListViewItem("All about the USA", 0);
        //    item1.SubItems.Add("Anime");
        //    item1.SubItems.Add("Inconnu");
        //    ListViewItem item2 = new ListViewItem("Women Who Changed the World", 1);
        //    item2.SubItems.Add("Anime");
        //    item2.SubItems.Add("Inconnu");
        //    ListViewItem item3 = new ListViewItem("Catch Me If You Can", 2);
        //    item3.SubItems.Add("Anime");
        //    item3.SubItems.Add("Inconnu");
        //    ListViewItem item4 = new ListViewItem("Amazing Architects and Artists", 3);
        //    item3.SubItems.Add("Anime");
        //    item3.SubItems.Add("Inconnu");
        //    ListViewItem item5 = new ListViewItem("A Ghost", 4);
        //    item3.SubItems.Add("Anime");
        //    item3.SubItems.Add("Inconnu");
        //    ListViewItem item6 = new ListViewItem("A Sea Change", 5);
        //    item3.SubItems.Add("Anime");
        //    item3.SubItems.Add("Inconnu");
        //    ListViewItem item7 = new ListViewItem("Death of the Eviction Man", 6);
        //    item3.SubItems.Add("Anime");
        //    item3.SubItems.Add("Inconnu");
        //    ListViewItem item8 = new ListViewItem("Barchester Towers", 7);
        //    item3.SubItems.Add("Anime");
        //    item3.SubItems.Add("Inconnu");
        //    ListViewItem item9 = new ListViewItem("Fear and Loathing in Las Vegas", 8);
        //    item3.SubItems.Add("Anime");
        //    item3.SubItems.Add("Inconnu");
        //    ListViewItem item10 = new ListViewItem("Peter Pan", 9);
        //    item3.SubItems.Add("Anime");
        //    item3.SubItems.Add("Inconnu");
        //    ListViewItem item11 = new ListViewItem("Amazing Thinkers and Humanitarians", 10);
        //    item3.SubItems.Add("Anime");
        //    item3.SubItems.Add("Inconnu");
        //    ListViewItem item12 = new ListViewItem("Oxford", 11);
        //    item3.SubItems.Add("Anime");
        //    item3.SubItems.Add("Inconnu");

        //    // Создание столбцов для элементов и подпунктов
        //    listView1.Columns.Add("Pictures", listView1.Width / 3, HorizontalAlignment.Left);
        //    listView1.Columns.Add("Genre", listView1.Width / 3, HorizontalAlignment.Left);
        //    listView1.Columns.Add("Author", listView1.Width / 3, HorizontalAlignment.Left);

        //    //Добавить элементы в ListView.
        //    listView1.Items.AddRange(new ListViewItem[] { item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12 });

        //    // Создаем два объекта ImageList.
        //    ImageList imageListSmall = new ImageList();
        //    ImageList imageListLarge = new ImageList();

        //    // Инициализация объектов ImageList с помощью растровых изображений.
        //    imageListSmall.Images.Add(Properties.Resources.All_about_the_USA_Emily_Winston);
        //    imageListSmall.Images.Add(Properties.Resources.Women_Who_Changed_the_World_Sue_Leather);
        //    imageListSmall.Images.Add(Properties.Resources.Catch_Me_If_You_Can_Frank_W_Abagnale);
        //    imageListSmall.Images.Add(Properties.Resources.Amazing_Architects_and_Artists_FH_Cornish);
        //    imageListSmall.Images.Add(Properties.Resources.A_Ghost_Robert_Harris);
        //    imageListSmall.Images.Add(Properties.Resources.A_Sea_Change_Veronica_Henry);
        //    imageListSmall.Images.Add(Properties.Resources.Death_of_the_Eviction_Man_Gayle_Tiller);
        //    imageListSmall.Images.Add(Properties.Resources.Barchester_Towers_Anthony_Trollope);
        //    imageListSmall.Images.Add(Properties.Resources.Fear_and_Loathing_in_Las_Vegas_Hunter_S_Thompson);
        //    imageListSmall.Images.Add(Properties.Resources.Peter_Pan_J_M_Barrie);
        //    imageListSmall.Images.Add(Properties.Resources.Amazing_Thinkers_and_Humanitarians_Katerina_Mestheneou);
        //    imageListSmall.Images.Add(Properties.Resources.Oxford_Hopkins_Andy);



        //    imageListLarge.Images.Add(Properties.Resources.All_about_the_USA_Emily_Winston);
        //    imageListLarge.Images.Add(Properties.Resources.Women_Who_Changed_the_World_Sue_Leather);
        //    imageListLarge.Images.Add(Properties.Resources.Catch_Me_If_You_Can_Frank_W_Abagnale);
        //    imageListLarge.Images.Add(Properties.Resources.Amazing_Architects_and_Artists_FH_Cornish);
        //    imageListLarge.Images.Add(Properties.Resources.A_Ghost_Robert_Harris);
        //    imageListLarge.Images.Add(Properties.Resources.A_Sea_Change_Veronica_Henry);
        //    imageListLarge.Images.Add(Properties.Resources.Death_of_the_Eviction_Man_Gayle_Tiller);
        //    imageListLarge.Images.Add(Properties.Resources.Barchester_Towers_Anthony_Trollope);
        //    imageListLarge.Images.Add(Properties.Resources.Fear_and_Loathing_in_Las_Vegas_Hunter_S_Thompson);
        //    imageListLarge.Images.Add(Properties.Resources.Peter_Pan_J_M_Barrie);
        //    imageListLarge.Images.Add(Properties.Resources.Amazing_Thinkers_and_Humanitarians_Katerina_Mestheneou);
        //    imageListLarge.Images.Add(Properties.Resources.Oxford_Hopkins_Andy);



        //    // установить значение SIZE на изображение
        //    imageListSmall.ImageSize = new Size(60, 80);
        //    imageListLarge.ImageSize = new Size(80, 120);

        //    listView1.LargeImageList = imageListLarge;
        //    listView1.SmallImageList = imageListSmall;

        //}

        //private void butBooksList_Click(object sender, EventArgs e)
        //{
        //    LoadListView(0);
        //    butBooksList.Enabled = false;
        //    butBooksDetailes.Enabled = true;
        //}

        //private void butBooksDetailes_Click(object sender, EventArgs e)
        //{
        //    LoadListView(1);
        //    butBooksList.Enabled = true;
        //    butBooksDetailes.Enabled = false;
        //}
   
      
       

        //загрузка коллекции изображений
        private void LoadImagesFromFolder(string[] paths)
        {
            LoadedImages = new List<Image>();
            var index = 1;
            foreach (var path in paths)
            {
                var tempImage = Image.FromFile(path);
                LoadedImages.Add(tempImage);
                index++;
            }
        }

        private void InitListView()
        {

            //инициализация ImageList
            ImageList images = new ImageList();
            images.ImageSize = new Size(80, 120);

            foreach (var image in LoadedImages)
            {
                images.Images.Add(image);
            }

            // настройка ListView
            imageList.LargeImageList = images;
            for (int itemIndex = 1; itemIndex <= LoadedImages.Count; itemIndex++)
            {
                imageList.Items.Add(new ListViewItem($"{itemIndex}", itemIndex - 1));
            }
        }
        //выбор изображения из ListView
        //private void SelectTheClickedItem(ListView list, int index)
        //{
        //    for (int item = 0; item < list.Items.Count; item++)
        //    {
        //        if (item == index)
        //        {
        //            list.Items[item].Selected = true;
        //        }
        //        else
        //        {
        //            list.Items[item].Selected = false;
        //        }
        //    }
        //}
        //привязка по индексу изображения

        private void imageList_ItemSelectionChanged_1(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (imageList.SelectedIndices.Count > 0)
            {
                try
                {
                    BookForm bookForm = new BookForm();
                    var selectedIndex = imageList.SelectedIndices[0];
                    Image selectedImg = LoadedImages[selectedIndex];
                    bookForm.selectedImage.Image = selectedImg;
                   // bookForm.labelBookForm.Text = selectedImg.ToString();
                    SelectedImageIndex = selectedIndex;
                    bookForm.Show();
                }
                catch
                {
                    MessageBox.Show("  Error!");
                }
            }
        }


      

        private void butAddBook_Click_1(object sender, EventArgs e)
        {
            //BookForm bookForm = new BookForm();
            //openFD.Filter = "*.jpg|*.jpg|*.png|*.png";
            //if (openFD.ShowDialog() == DialogResult.OK)
            //{
            //    bookForm.selectedImage.Image = new Bitmap(openFD.FileName);
            //    var tempImage = Image.FromFile(openFD.FileName);
            //    LoadedImages.Add(tempImage);
                //if (bookForm.selectedImage.Image != null)
                //{
                //    saveFD.Title = "Save as...";
                //    saveFD.OverwritePrompt = true;
                //    saveFD.CheckPathExists = true;
                //    saveFD.Filter = "*.jpg|*.jpg|*.png|*.png";

                //}
                //if (saveFD.ShowDialog() == DialogResult.OK)
                //    bookForm.selectedImage.Image.Save(saveFD.FileName);
                //InitListView();

            //}
        }

        private void butDelBook_Click(object sender, EventArgs e)
        {
            
        }
    }

}
