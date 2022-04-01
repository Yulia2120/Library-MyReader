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
   
    
     
        private string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"images");
       


        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (tabControl.SelectedIndex == 1)
            {
                var di = Directory.GetFiles(path);
                LoadImagesFromFolder(di);
                InitListView();
            }
        }
       

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
            ////инициализация ImageList
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
                    SelectedImageIndex = selectedIndex;
                    // bookForm.labelBookForm.Text = "Current image is " + (selectedIndex+1);
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
            openFD.Filter = "*.jpg|*.jpg|*.png|*.png";
            if (openFD.ShowDialog() == DialogResult.OK)
            {
                var tempImage = Image.FromFile(openFD.FileName);
                LoadedImages.Add(tempImage);
                tempImage.Save(Name);
                InitListView();

            }
        }

        private void butDelBook_Click(object sender, EventArgs e)
        {
            var selectedIndex = imageList.SelectedIndices[0];
            imageList.Items.RemoveAt(selectedIndex);
        }

    }

}
