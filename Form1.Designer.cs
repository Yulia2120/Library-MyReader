namespace Library_MyReader
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageTitle = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTitle1 = new System.Windows.Forms.Label();
            this.labelTitle2 = new System.Windows.Forms.Label();
            this.tabPageBooks = new System.Windows.Forms.TabPage();
            this.butDelBook = new System.Windows.Forms.Button();
            this.butAddBook = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ListView();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.saveFD = new System.Windows.Forms.SaveFileDialog();
            this.tabControl.SuspendLayout();
            this.tabPageTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPageBooks.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.tabPageTitle);
            this.tabControl.Controls.Add(this.tabPageBooks);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(786, 497);
            this.tabControl.TabIndex = 3;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPageTitle
            // 
            this.tabPageTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(79)))));
            this.tabPageTitle.Controls.Add(this.pictureBox1);
            this.tabPageTitle.Controls.Add(this.labelTitle1);
            this.tabPageTitle.Controls.Add(this.labelTitle2);
            this.tabPageTitle.Location = new System.Drawing.Point(4, 29);
            this.tabPageTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageTitle.Name = "tabPageTitle";
            this.tabPageTitle.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPageTitle.Size = new System.Drawing.Size(778, 464);
            this.tabPageTitle.TabIndex = 0;
            this.tabPageTitle.Text = "Title";
            this.tabPageTitle.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Library_MyReader.Properties.Resources.easy_ebook_viewer_icon;
            this.pictureBox1.Location = new System.Drawing.Point(186, 155);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelTitle1
            // 
            this.labelTitle1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle1.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle1.Font = new System.Drawing.Font("Yu Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(92)))), ((int)(((byte)(169)))));
            this.labelTitle1.Location = new System.Drawing.Point(337, 167);
            this.labelTitle1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle1.Name = "labelTitle1";
            this.labelTitle1.Size = new System.Drawing.Size(96, 31);
            this.labelTitle1.TabIndex = 1;
            this.labelTitle1.Text = "Library";
            // 
            // labelTitle2
            // 
            this.labelTitle2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle2.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(69)))), ((int)(((byte)(126)))));
            this.labelTitle2.Location = new System.Drawing.Point(334, 203);
            this.labelTitle2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle2.Name = "labelTitle2";
            this.labelTitle2.Size = new System.Drawing.Size(259, 45);
            this.labelTitle2.TabIndex = 2;
            this.labelTitle2.Text = "MyEBookReader";
            // 
            // tabPageBooks
            // 
            this.tabPageBooks.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageBooks.Controls.Add(this.butDelBook);
            this.tabPageBooks.Controls.Add(this.butAddBook);
            this.tabPageBooks.Controls.Add(this.imageList);
            this.tabPageBooks.Location = new System.Drawing.Point(4, 29);
            this.tabPageBooks.Name = "tabPageBooks";
            this.tabPageBooks.Size = new System.Drawing.Size(778, 464);
            this.tabPageBooks.TabIndex = 2;
            this.tabPageBooks.Text = "Books";
            // 
            // butDelBook
            // 
            this.butDelBook.Location = new System.Drawing.Point(673, 17);
            this.butDelBook.Name = "butDelBook";
            this.butDelBook.Size = new System.Drawing.Size(75, 23);
            this.butDelBook.TabIndex = 2;
            this.butDelBook.Text = "Delete";
            this.butDelBook.UseVisualStyleBackColor = true;
            this.butDelBook.Click += new System.EventHandler(this.butDelBook_Click);
            // 
            // butAddBook
            // 
            this.butAddBook.Location = new System.Drawing.Point(557, 17);
            this.butAddBook.Name = "butAddBook";
            this.butAddBook.Size = new System.Drawing.Size(75, 23);
            this.butAddBook.TabIndex = 1;
            this.butAddBook.Text = "AddBook";
            this.butAddBook.UseVisualStyleBackColor = true;
            this.butAddBook.Click += new System.EventHandler(this.butAddBook_Click_1);
            // 
            // imageList
            // 
            this.imageList.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.imageList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.imageList.ForeColor = System.Drawing.Color.White;
            this.imageList.FullRowSelect = true;
            this.imageList.HideSelection = false;
            this.imageList.Location = new System.Drawing.Point(0, 53);
            this.imageList.Name = "imageList";
            this.imageList.Size = new System.Drawing.Size(778, 411);
            this.imageList.TabIndex = 0;
            this.imageList.UseCompatibleStateImageBehavior = false;
            this.imageList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.imageList_ItemSelectionChanged_1);
         
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(786, 497);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(92)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library MyEBookReader";
            this.tabControl.ResumeLayout(false);
            this.tabPageTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPageBooks.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Label labelTitle2;
        private System.Windows.Forms.Label labelTitle1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPageTitle;
        private System.Windows.Forms.TabPage tabPageBooks;
        private System.Windows.Forms.Button butDelBook;
        private System.Windows.Forms.Button butAddBook;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.SaveFileDialog saveFD;
        public System.Windows.Forms.ListView imageList;
    }
}

