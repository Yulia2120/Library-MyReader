﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_MyReader
{
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
        }

        private void butTextFormRead_Click(object sender, EventArgs e)
        {
            TextForm textBox = new TextForm();
            textBox.Text = butTextFormRead.Text;
            textBox.Show();
            //if(selectedImage.Name == )
        }
    }
}
