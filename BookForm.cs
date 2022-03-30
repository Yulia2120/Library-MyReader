using System;
using System.Collections.Generic;
using System.IO;

using System.Windows.Forms;

namespace Library_MyReader
{

    public partial class BookForm : Form
    {
      
        //private List<string> texts { get; set; }
        //private string pathText = @"C:\Users\Admin\source\repos\Library MyReader\bin\Debug\text";
        //private int SelectedImageIndex = 0;
        //private int index = 0;

        public BookForm()
        {
            InitializeComponent();
           
        }


        private void selectedImage_Click(object sender, EventArgs e)
        {
           // Form1 form = new Form1();
           // if (form.imageList.SelectedIndices == texts[index])
            {
                TextForm textBox = new TextForm();
                textBox.Show();
                textBox.TextFromFolder();

            }
        }
       
    }
}
