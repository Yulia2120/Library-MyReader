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
            this.labelTitle2 = new System.Windows.Forms.Label();
            this.labelTitle1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPageLibrary = new System.Windows.Forms.TabPage();
            this.butBooksDetailes = new System.Windows.Forms.Button();
            this.butBooksList = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabPageAddBook = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tabPageTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPageLibrary.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.tabPageTitle);
            this.tabControl.Controls.Add(this.tabPageLibrary);
            this.tabControl.Controls.Add(this.tabPageAddBook);
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
            // tabPageLibrary
            // 
            this.tabPageLibrary.Controls.Add(this.butBooksDetailes);
            this.tabPageLibrary.Controls.Add(this.butBooksList);
            this.tabPageLibrary.Controls.Add(this.listView1);
            this.tabPageLibrary.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageLibrary.Location = new System.Drawing.Point(4, 29);
            this.tabPageLibrary.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageLibrary.Name = "tabPageLibrary";
            this.tabPageLibrary.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageLibrary.Size = new System.Drawing.Size(778, 464);
            this.tabPageLibrary.TabIndex = 1;
            this.tabPageLibrary.Text = "Library";
            this.tabPageLibrary.UseVisualStyleBackColor = true;
            // 
            // butBooksDetailes
            // 
            this.butBooksDetailes.Location = new System.Drawing.Point(695, 3);
            this.butBooksDetailes.Name = "butBooksDetailes";
            this.butBooksDetailes.Size = new System.Drawing.Size(75, 23);
            this.butBooksDetailes.TabIndex = 2;
            this.butBooksDetailes.Text = "Info";
            this.butBooksDetailes.UseVisualStyleBackColor = true;
            this.butBooksDetailes.Click += new System.EventHandler(this.butBooksDetailes_Click);
            // 
            // butBooksList
            // 
            this.butBooksList.Location = new System.Drawing.Point(578, 3);
            this.butBooksList.Name = "butBooksList";
            this.butBooksList.Size = new System.Drawing.Size(75, 23);
            this.butBooksList.TabIndex = 1;
            this.butBooksList.Text = "Books";
            this.butBooksList.UseVisualStyleBackColor = true;
            this.butBooksList.Click += new System.EventHandler(this.butBooksList_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listView1.Location = new System.Drawing.Point(4, 55);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(770, 406);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tabPageAddBook
            // 
            this.tabPageAddBook.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageAddBook.Location = new System.Drawing.Point(4, 29);
            this.tabPageAddBook.Name = "tabPageAddBook";
            this.tabPageAddBook.Size = new System.Drawing.Size(778, 464);
            this.tabPageAddBook.TabIndex = 2;
            this.tabPageAddBook.Text = "AddBook";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
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
            this.tabPageLibrary.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Label labelTitle2;
        private System.Windows.Forms.Label labelTitle1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPageLibrary;
        private System.Windows.Forms.TabPage tabPageTitle;
        private System.Windows.Forms.TabPage tabPageAddBook;
        private System.Windows.Forms.Button butBooksDetailes;
        private System.Windows.Forms.Button butBooksList;
        private System.Windows.Forms.ListView listView1;
    }
}

