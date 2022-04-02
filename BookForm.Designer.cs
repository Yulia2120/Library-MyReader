namespace Library_MyReader
{
    partial class BookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectedImage = new System.Windows.Forms.PictureBox();
            this.labelBookForm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.selectedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // selectedImage
            // 
            this.selectedImage.BackColor = System.Drawing.SystemColors.Control;
            this.selectedImage.Location = new System.Drawing.Point(250, 31);
            this.selectedImage.Name = "selectedImage";
            this.selectedImage.Size = new System.Drawing.Size(273, 375);
            this.selectedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.selectedImage.TabIndex = 0;
            this.selectedImage.TabStop = false;
            this.selectedImage.Click += new System.EventHandler(this.selectedImage_Click);
            // 
            // labelBookForm
            // 
            this.labelBookForm.AutoSize = true;
            this.labelBookForm.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBookForm.Location = new System.Drawing.Point(265, 418);
            this.labelBookForm.Name = "labelBookForm";
            this.labelBookForm.Size = new System.Drawing.Size(0, 15);
            this.labelBookForm.TabIndex = 2;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 497);
            this.Controls.Add(this.labelBookForm);
            this.Controls.Add(this.selectedImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookForm";
            this.TopMost = true;
        
            ((System.ComponentModel.ISupportInitialize)(this.selectedImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox selectedImage;
        public System.Windows.Forms.Label labelBookForm;
    }
}