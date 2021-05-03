
namespace kino_library
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.moviesDataGridView = new System.Windows.Forms.DataGridView();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.ratingComboBox = new System.Windows.Forms.ComboBox();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.actorsLabel = new System.Windows.Forms.Label();
            this.directorsLabel = new System.Windows.Forms.Label();
            this.directorsListBox = new System.Windows.Forms.ListBox();
            this.actorsListBox = new System.Windows.Forms.ListBox();
            this.viewAllButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // moviesDataGridView
            // 
            this.moviesDataGridView.AllowUserToAddRows = false;
            this.moviesDataGridView.AllowUserToDeleteRows = false;
            this.moviesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moviesDataGridView.Location = new System.Drawing.Point(457, 12);
            this.moviesDataGridView.Name = "moviesDataGridView";
            this.moviesDataGridView.ReadOnly = true;
            this.moviesDataGridView.RowTemplate.Height = 25;
            this.moviesDataGridView.Size = new System.Drawing.Size(486, 426);
            this.moviesDataGridView.TabIndex = 0;
            this.moviesDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.moviesDataGridView_CellDoubleClick);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(51, 387);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(111, 51);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(285, 387);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(111, 51);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(168, 387);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(111, 51);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(29, 15);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Title";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(74, 9);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(100, 23);
            this.titleTextBox.TabIndex = 5;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(74, 38);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(100, 23);
            this.yearTextBox.TabIndex = 7;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(12, 38);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(29, 15);
            this.yearLabel.TabIndex = 6;
            this.yearLabel.Text = "Year";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(12, 270);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(439, 111);
            this.descriptionTextBox.TabIndex = 9;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(12, 252);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(67, 15);
            this.descriptionLabel.TabIndex = 8;
            this.descriptionLabel.Text = "Description";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(249, 9);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(38, 15);
            this.genreLabel.TabIndex = 10;
            this.genreLabel.Text = "Genre";
            // 
            // genreComboBox
            // 
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Location = new System.Drawing.Point(312, 6);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(100, 23);
            this.genreComboBox.TabIndex = 11;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(312, 38);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(100, 23);
            this.categoryComboBox.TabIndex = 13;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(249, 41);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(55, 15);
            this.categoryLabel.TabIndex = 12;
            this.categoryLabel.Text = "Category";
            // 
            // ratingComboBox
            // 
            this.ratingComboBox.FormattingEnabled = true;
            this.ratingComboBox.Location = new System.Drawing.Point(312, 67);
            this.ratingComboBox.Name = "ratingComboBox";
            this.ratingComboBox.Size = new System.Drawing.Size(100, 23);
            this.ratingComboBox.TabIndex = 15;
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Location = new System.Drawing.Point(249, 70);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(41, 15);
            this.ratingLabel.TabIndex = 14;
            this.ratingLabel.Text = "Rating";
            // 
            // countryComboBox
            // 
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Location = new System.Drawing.Point(74, 70);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(100, 23);
            this.countryComboBox.TabIndex = 17;
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(12, 73);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(50, 15);
            this.countryLabel.TabIndex = 16;
            this.countryLabel.Text = "Country";
            // 
            // actorsLabel
            // 
            this.actorsLabel.AutoSize = true;
            this.actorsLabel.Location = new System.Drawing.Point(12, 118);
            this.actorsLabel.Name = "actorsLabel";
            this.actorsLabel.Size = new System.Drawing.Size(41, 15);
            this.actorsLabel.TabIndex = 19;
            this.actorsLabel.Text = "Actors";
            // 
            // directorsLabel
            // 
            this.directorsLabel.AutoSize = true;
            this.directorsLabel.Location = new System.Drawing.Point(225, 118);
            this.directorsLabel.Name = "directorsLabel";
            this.directorsLabel.Size = new System.Drawing.Size(54, 15);
            this.directorsLabel.TabIndex = 21;
            this.directorsLabel.Text = "Directors";
            // 
            // directorsListBox
            // 
            this.directorsListBox.FormattingEnabled = true;
            this.directorsListBox.ItemHeight = 15;
            this.directorsListBox.Location = new System.Drawing.Point(285, 118);
            this.directorsListBox.Name = "directorsListBox";
            this.directorsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.directorsListBox.Size = new System.Drawing.Size(138, 109);
            this.directorsListBox.TabIndex = 22;
            // 
            // actorsListBox
            // 
            this.actorsListBox.FormattingEnabled = true;
            this.actorsListBox.ItemHeight = 15;
            this.actorsListBox.Location = new System.Drawing.Point(59, 118);
            this.actorsListBox.Name = "actorsListBox";
            this.actorsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.actorsListBox.Size = new System.Drawing.Size(138, 109);
            this.actorsListBox.TabIndex = 23;
            // 
            // viewAllButton
            // 
            this.viewAllButton.Location = new System.Drawing.Point(203, 168);
            this.viewAllButton.Name = "viewAllButton";
            this.viewAllButton.Size = new System.Drawing.Size(75, 23);
            this.viewAllButton.TabIndex = 24;
            this.viewAllButton.Text = "View All";
            this.viewAllButton.UseVisualStyleBackColor = true;
            this.viewAllButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.viewAllButton_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 450);
            this.Controls.Add(this.viewAllButton);
            this.Controls.Add(this.actorsListBox);
            this.Controls.Add(this.directorsListBox);
            this.Controls.Add(this.directorsLabel);
            this.Controls.Add(this.actorsLabel);
            this.Controls.Add(this.countryComboBox);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.ratingComboBox);
            this.Controls.Add(this.ratingLabel);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.genreComboBox);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.moviesDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moviesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView moviesDataGridView;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.ComboBox ratingComboBox;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label actorsLabel;
        private System.Windows.Forms.Label directorsLabel;
        private System.Windows.Forms.ListBox directorsListBox;
        private System.Windows.Forms.ListBox actorsListBox;
        private System.Windows.Forms.Button viewAllButton;
    }
}

