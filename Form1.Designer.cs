
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
            this.addGenreButton = new System.Windows.Forms.Button();
            this.changePosterButton = new System.Windows.Forms.Button();
            this.posterPictureBox = new System.Windows.Forms.PictureBox();
            this.viewAllButton = new System.Windows.Forms.Button();
            this.actorsListBox = new System.Windows.Forms.ListBox();
            this.directorsListBox = new System.Windows.Forms.ListBox();
            this.directorsLabel = new System.Windows.Forms.Label();
            this.actorsLabel = new System.Windows.Forms.Label();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.ratingComboBox = new System.Windows.Forms.ComboBox();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.genreLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.moviesDataGridView = new System.Windows.Forms.DataGridView();
            this.addCategoryButton = new System.Windows.Forms.Button();
            this.addCountrybutton = new System.Windows.Forms.Button();
            this.addRatingbutton = new System.Windows.Forms.Button();
            this.addActorButton = new System.Windows.Forms.Button();
            this.addDirectorButton = new System.Windows.Forms.Button();
            this.addActorNameTextBox = new System.Windows.Forms.TextBox();
            this.addDirectorNamTextBox = new System.Windows.Forms.TextBox();
            this.addActorBioTextBox = new System.Windows.Forms.TextBox();
            this.addDirectorBioTextBox = new System.Windows.Forms.TextBox();
            this.deleteRatingButton = new System.Windows.Forms.Button();
            this.deleteCountryButton = new System.Windows.Forms.Button();
            this.deleteCategoryButton = new System.Windows.Forms.Button();
            this.deleteGenreButton = new System.Windows.Forms.Button();
            this.deleteActorButton = new System.Windows.Forms.Button();
            this.deleteDirectorButton = new System.Windows.Forms.Button();
            this.actorsNameLabel = new System.Windows.Forms.Label();
            this.directorsNameLabel = new System.Windows.Forms.Label();
            this.actorsBioLabel = new System.Windows.Forms.Label();
            this.directorsBioLabel = new System.Windows.Forms.Label();
            this.genreNamelabel = new System.Windows.Forms.Label();
            this.addGenreTextBox = new System.Windows.Forms.TextBox();
            this.categoryNameLabel = new System.Windows.Forms.Label();
            this.addCategoryTextBox = new System.Windows.Forms.TextBox();
            this.countryNameLabel = new System.Windows.Forms.Label();
            this.addCountryTextBox = new System.Windows.Forms.TextBox();
            this.ratingNameLabel = new System.Windows.Forms.Label();
            this.addRatingTextBox = new System.Windows.Forms.TextBox();
            this.deleteActorFromMovieButton = new System.Windows.Forms.Button();
            this.DeleteDirectorFromMovieButton = new System.Windows.Forms.Button();
            this.SqlEditorButton = new System.Windows.Forms.Button();
            this.DbBackupButton = new System.Windows.Forms.Button();
            this.DbRecoveryButton = new System.Windows.Forms.Button();
            this.LoggingButton = new System.Windows.Forms.Button();
            this.SqlEditorDataGridView = new System.Windows.Forms.DataGridView();
            this.MakeQueryButton = new System.Windows.Forms.Button();
            this.ClearSqlEditorButton = new System.Windows.Forms.Button();
            this.SqlEditorTextBox = new System.Windows.Forms.TextBox();
            this.SqlEditorPanel = new System.Windows.Forms.Panel();
            this.DataGridSqlEditorPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.posterPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SqlEditorDataGridView)).BeginInit();
            this.SqlEditorPanel.SuspendLayout();
            this.DataGridSqlEditorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addGenreButton
            // 
            this.addGenreButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addGenreButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addGenreButton.FlatAppearance.BorderSize = 0;
            this.addGenreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.addGenreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addGenreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addGenreButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addGenreButton.Location = new System.Drawing.Point(12, 445);
            this.addGenreButton.Name = "addGenreButton";
            this.addGenreButton.Size = new System.Drawing.Size(100, 29);
            this.addGenreButton.TabIndex = 77;
            this.addGenreButton.Text = "+";
            this.addGenreButton.UseVisualStyleBackColor = false;
            this.addGenreButton.Click += new System.EventHandler(this.addGenreButton_Click);
            // 
            // changePosterButton
            // 
            this.changePosterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.changePosterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changePosterButton.FlatAppearance.BorderSize = 0;
            this.changePosterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.changePosterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.changePosterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePosterButton.Location = new System.Drawing.Point(59, 288);
            this.changePosterButton.Name = "changePosterButton";
            this.changePosterButton.Size = new System.Drawing.Size(111, 36);
            this.changePosterButton.TabIndex = 76;
            this.changePosterButton.Text = "Change poster";
            this.changePosterButton.UseVisualStyleBackColor = false;
            this.changePosterButton.Click += new System.EventHandler(this.changePosterButton_Click);
            // 
            // posterPictureBox
            // 
            this.posterPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.posterPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.posterPictureBox.Location = new System.Drawing.Point(12, 12);
            this.posterPictureBox.Name = "posterPictureBox";
            this.posterPictureBox.Size = new System.Drawing.Size(203, 270);
            this.posterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.posterPictureBox.TabIndex = 75;
            this.posterPictureBox.TabStop = false;
            // 
            // viewAllButton
            // 
            this.viewAllButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.viewAllButton.FlatAppearance.BorderSize = 0;
            this.viewAllButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.viewAllButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.viewAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewAllButton.Location = new System.Drawing.Point(439, 32);
            this.viewAllButton.Name = "viewAllButton";
            this.viewAllButton.Size = new System.Drawing.Size(72, 77);
            this.viewAllButton.TabIndex = 74;
            this.viewAllButton.Text = "View all actors and directors";
            this.viewAllButton.UseVisualStyleBackColor = false;
            this.viewAllButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.viewAllButton_MouseClick);
            // 
            // actorsListBox
            // 
            this.actorsListBox.FormattingEnabled = true;
            this.actorsListBox.ItemHeight = 15;
            this.actorsListBox.Location = new System.Drawing.Point(517, 30);
            this.actorsListBox.Name = "actorsListBox";
            this.actorsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.actorsListBox.Size = new System.Drawing.Size(138, 79);
            this.actorsListBox.TabIndex = 73;
            this.actorsListBox.SelectedIndexChanged += new System.EventHandler(this.actorsListBox_SelectedIndexChanged);
            // 
            // directorsListBox
            // 
            this.directorsListBox.FormattingEnabled = true;
            this.directorsListBox.ItemHeight = 15;
            this.directorsListBox.Location = new System.Drawing.Point(674, 30);
            this.directorsListBox.Name = "directorsListBox";
            this.directorsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.directorsListBox.Size = new System.Drawing.Size(138, 79);
            this.directorsListBox.TabIndex = 72;
            this.directorsListBox.SelectedIndexChanged += new System.EventHandler(this.directorsListBox_SelectedIndexChanged);
            // 
            // directorsLabel
            // 
            this.directorsLabel.AutoSize = true;
            this.directorsLabel.Location = new System.Drawing.Point(674, 12);
            this.directorsLabel.Name = "directorsLabel";
            this.directorsLabel.Size = new System.Drawing.Size(57, 15);
            this.directorsLabel.TabIndex = 71;
            this.directorsLabel.Text = "Directors:";
            // 
            // actorsLabel
            // 
            this.actorsLabel.AutoSize = true;
            this.actorsLabel.Location = new System.Drawing.Point(517, 12);
            this.actorsLabel.Name = "actorsLabel";
            this.actorsLabel.Size = new System.Drawing.Size(44, 15);
            this.actorsLabel.TabIndex = 70;
            this.actorsLabel.Text = "Actors:";
            // 
            // countryComboBox
            // 
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Location = new System.Drawing.Point(263, 363);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(100, 23);
            this.countryComboBox.TabIndex = 69;
            this.countryComboBox.SelectedIndexChanged += new System.EventHandler(this.countryComboBox_SelectedIndexChanged);
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(263, 345);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(53, 15);
            this.countryLabel.TabIndex = 68;
            this.countryLabel.Text = "Country:";
            // 
            // ratingComboBox
            // 
            this.ratingComboBox.FormattingEnabled = true;
            this.ratingComboBox.Location = new System.Drawing.Point(387, 363);
            this.ratingComboBox.Name = "ratingComboBox";
            this.ratingComboBox.Size = new System.Drawing.Size(100, 23);
            this.ratingComboBox.TabIndex = 67;
            this.ratingComboBox.SelectedIndexChanged += new System.EventHandler(this.ratingComboBox_SelectedIndexChanged);
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Location = new System.Drawing.Point(387, 345);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(44, 15);
            this.ratingLabel.TabIndex = 66;
            this.ratingLabel.Text = "Rating:";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(138, 363);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(100, 23);
            this.categoryComboBox.TabIndex = 65;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(138, 345);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(58, 15);
            this.categoryLabel.TabIndex = 64;
            this.categoryLabel.Text = "Category:";
            // 
            // genreComboBox
            // 
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Location = new System.Drawing.Point(12, 363);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(100, 23);
            this.genreComboBox.TabIndex = 63;
            this.genreComboBox.SelectedIndexChanged += new System.EventHandler(this.genreComboBox_SelectedIndexChanged);
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(12, 345);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(41, 15);
            this.genreLabel.TabIndex = 62;
            this.genreLabel.Text = "Genre:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.descriptionTextBox.Location = new System.Drawing.Point(223, 118);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(264, 164);
            this.descriptionTextBox.TabIndex = 61;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(223, 100);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(70, 15);
            this.descriptionLabel.TabIndex = 60;
            this.descriptionLabel.Text = "Description:";
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(223, 74);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(100, 23);
            this.yearTextBox.TabIndex = 59;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(223, 56);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(32, 15);
            this.yearLabel.TabIndex = 58;
            this.yearLabel.Text = "Year:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(223, 30);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(100, 23);
            this.titleTextBox.TabIndex = 57;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(223, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(32, 15);
            this.titleLabel.TabIndex = 56;
            this.titleLabel.Text = "Title:";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Red;
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.deleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(610, 458);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(111, 51);
            this.deleteButton.TabIndex = 55;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(714, 458);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(111, 51);
            this.cancelButton.TabIndex = 54;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.saveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Location = new System.Drawing.Point(502, 458);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(111, 51);
            this.saveButton.TabIndex = 53;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // moviesDataGridView
            // 
            this.moviesDataGridView.AllowUserToAddRows = false;
            this.moviesDataGridView.AllowUserToDeleteRows = false;
            this.moviesDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.moviesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.moviesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moviesDataGridView.Cursor = System.Windows.Forms.Cursors.Cross;
            this.moviesDataGridView.Location = new System.Drawing.Point(831, 12);
            this.moviesDataGridView.Name = "moviesDataGridView";
            this.moviesDataGridView.ReadOnly = true;
            this.moviesDataGridView.RowTemplate.Height = 25;
            this.moviesDataGridView.Size = new System.Drawing.Size(436, 497);
            this.moviesDataGridView.TabIndex = 52;
            this.moviesDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.moviesDataGridView_CellDoubleClick);
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addCategoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCategoryButton.FlatAppearance.BorderSize = 0;
            this.addCategoryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.addCategoryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCategoryButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addCategoryButton.Location = new System.Drawing.Point(138, 445);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(100, 29);
            this.addCategoryButton.TabIndex = 81;
            this.addCategoryButton.Text = "+";
            this.addCategoryButton.UseVisualStyleBackColor = false;
            this.addCategoryButton.Click += new System.EventHandler(this.addCategoryButton_Click);
            // 
            // addCountrybutton
            // 
            this.addCountrybutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addCountrybutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCountrybutton.FlatAppearance.BorderSize = 0;
            this.addCountrybutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.addCountrybutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addCountrybutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCountrybutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addCountrybutton.Location = new System.Drawing.Point(263, 445);
            this.addCountrybutton.Name = "addCountrybutton";
            this.addCountrybutton.Size = new System.Drawing.Size(100, 29);
            this.addCountrybutton.TabIndex = 83;
            this.addCountrybutton.Text = "+";
            this.addCountrybutton.UseVisualStyleBackColor = false;
            this.addCountrybutton.Click += new System.EventHandler(this.addCountryButton_Click);
            // 
            // addRatingbutton
            // 
            this.addRatingbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addRatingbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addRatingbutton.FlatAppearance.BorderSize = 0;
            this.addRatingbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.addRatingbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addRatingbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRatingbutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addRatingbutton.Location = new System.Drawing.Point(387, 445);
            this.addRatingbutton.Name = "addRatingbutton";
            this.addRatingbutton.Size = new System.Drawing.Size(100, 29);
            this.addRatingbutton.TabIndex = 88;
            this.addRatingbutton.Text = "+";
            this.addRatingbutton.UseVisualStyleBackColor = false;
            this.addRatingbutton.Click += new System.EventHandler(this.addRatingButton_Click);
            // 
            // addActorButton
            // 
            this.addActorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addActorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addActorButton.FlatAppearance.BorderSize = 0;
            this.addActorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.addActorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addActorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addActorButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addActorButton.Location = new System.Drawing.Point(542, 330);
            this.addActorButton.Name = "addActorButton";
            this.addActorButton.Size = new System.Drawing.Size(100, 29);
            this.addActorButton.TabIndex = 89;
            this.addActorButton.Text = "+";
            this.addActorButton.UseVisualStyleBackColor = false;
            this.addActorButton.Click += new System.EventHandler(this.addActorButton_Click);
            // 
            // addDirectorButton
            // 
            this.addDirectorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addDirectorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addDirectorButton.FlatAppearance.BorderSize = 0;
            this.addDirectorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.addDirectorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addDirectorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDirectorButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addDirectorButton.Location = new System.Drawing.Point(691, 330);
            this.addDirectorButton.Name = "addDirectorButton";
            this.addDirectorButton.Size = new System.Drawing.Size(100, 29);
            this.addDirectorButton.TabIndex = 90;
            this.addDirectorButton.Text = "+";
            this.addDirectorButton.UseVisualStyleBackColor = false;
            this.addDirectorButton.Click += new System.EventHandler(this.addDirectorButton_Click);
            // 
            // addActorNameTextBox
            // 
            this.addActorNameTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.addActorNameTextBox.Location = new System.Drawing.Point(517, 173);
            this.addActorNameTextBox.Name = "addActorNameTextBox";
            this.addActorNameTextBox.Size = new System.Drawing.Size(138, 23);
            this.addActorNameTextBox.TabIndex = 91;
            // 
            // addDirectorNamTextBox
            // 
            this.addDirectorNamTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.addDirectorNamTextBox.Location = new System.Drawing.Point(674, 173);
            this.addDirectorNamTextBox.Name = "addDirectorNamTextBox";
            this.addDirectorNamTextBox.Size = new System.Drawing.Size(138, 23);
            this.addDirectorNamTextBox.TabIndex = 92;
            // 
            // addActorBioTextBox
            // 
            this.addActorBioTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.addActorBioTextBox.Location = new System.Drawing.Point(517, 221);
            this.addActorBioTextBox.Multiline = true;
            this.addActorBioTextBox.Name = "addActorBioTextBox";
            this.addActorBioTextBox.Size = new System.Drawing.Size(138, 103);
            this.addActorBioTextBox.TabIndex = 93;
            // 
            // addDirectorBioTextBox
            // 
            this.addDirectorBioTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.addDirectorBioTextBox.Location = new System.Drawing.Point(674, 221);
            this.addDirectorBioTextBox.Multiline = true;
            this.addDirectorBioTextBox.Name = "addDirectorBioTextBox";
            this.addDirectorBioTextBox.Size = new System.Drawing.Size(138, 103);
            this.addDirectorBioTextBox.TabIndex = 94;
            // 
            // deleteRatingButton
            // 
            this.deleteRatingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.deleteRatingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteRatingButton.FlatAppearance.BorderSize = 0;
            this.deleteRatingButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.deleteRatingButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.deleteRatingButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteRatingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteRatingButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteRatingButton.Location = new System.Drawing.Point(387, 480);
            this.deleteRatingButton.Name = "deleteRatingButton";
            this.deleteRatingButton.Size = new System.Drawing.Size(100, 29);
            this.deleteRatingButton.TabIndex = 95;
            this.deleteRatingButton.Text = "-";
            this.deleteRatingButton.UseVisualStyleBackColor = false;
            this.deleteRatingButton.Click += new System.EventHandler(this.deleteRatingButton_Click);
            // 
            // deleteCountryButton
            // 
            this.deleteCountryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.deleteCountryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteCountryButton.FlatAppearance.BorderSize = 0;
            this.deleteCountryButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.deleteCountryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.deleteCountryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteCountryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteCountryButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteCountryButton.Location = new System.Drawing.Point(263, 480);
            this.deleteCountryButton.Name = "deleteCountryButton";
            this.deleteCountryButton.Size = new System.Drawing.Size(100, 29);
            this.deleteCountryButton.TabIndex = 96;
            this.deleteCountryButton.Text = "-";
            this.deleteCountryButton.UseVisualStyleBackColor = false;
            this.deleteCountryButton.Click += new System.EventHandler(this.deleteCountryButton_Click);
            // 
            // deleteCategoryButton
            // 
            this.deleteCategoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.deleteCategoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteCategoryButton.FlatAppearance.BorderSize = 0;
            this.deleteCategoryButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.deleteCategoryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.deleteCategoryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteCategoryButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteCategoryButton.Location = new System.Drawing.Point(138, 480);
            this.deleteCategoryButton.Name = "deleteCategoryButton";
            this.deleteCategoryButton.Size = new System.Drawing.Size(100, 29);
            this.deleteCategoryButton.TabIndex = 97;
            this.deleteCategoryButton.Text = "-";
            this.deleteCategoryButton.UseVisualStyleBackColor = false;
            this.deleteCategoryButton.Click += new System.EventHandler(this.deleteCategoryButton_Click);
            // 
            // deleteGenreButton
            // 
            this.deleteGenreButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.deleteGenreButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteGenreButton.FlatAppearance.BorderSize = 0;
            this.deleteGenreButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.deleteGenreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.deleteGenreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteGenreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteGenreButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteGenreButton.Location = new System.Drawing.Point(12, 480);
            this.deleteGenreButton.Name = "deleteGenreButton";
            this.deleteGenreButton.Size = new System.Drawing.Size(100, 29);
            this.deleteGenreButton.TabIndex = 98;
            this.deleteGenreButton.Text = "-";
            this.deleteGenreButton.UseVisualStyleBackColor = false;
            this.deleteGenreButton.Click += new System.EventHandler(this.deleteGenreButton_Click);
            // 
            // deleteActorButton
            // 
            this.deleteActorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.deleteActorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteActorButton.FlatAppearance.BorderSize = 0;
            this.deleteActorButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.deleteActorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.deleteActorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteActorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteActorButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteActorButton.Location = new System.Drawing.Point(542, 365);
            this.deleteActorButton.Name = "deleteActorButton";
            this.deleteActorButton.Size = new System.Drawing.Size(100, 29);
            this.deleteActorButton.TabIndex = 99;
            this.deleteActorButton.Text = "-";
            this.deleteActorButton.UseVisualStyleBackColor = false;
            this.deleteActorButton.Click += new System.EventHandler(this.deleteActorButton_Click);
            // 
            // deleteDirectorButton
            // 
            this.deleteDirectorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.deleteDirectorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteDirectorButton.FlatAppearance.BorderSize = 0;
            this.deleteDirectorButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.deleteDirectorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.deleteDirectorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteDirectorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteDirectorButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteDirectorButton.Location = new System.Drawing.Point(691, 365);
            this.deleteDirectorButton.Name = "deleteDirectorButton";
            this.deleteDirectorButton.Size = new System.Drawing.Size(100, 29);
            this.deleteDirectorButton.TabIndex = 100;
            this.deleteDirectorButton.Text = "-";
            this.deleteDirectorButton.UseVisualStyleBackColor = false;
            this.deleteDirectorButton.Click += new System.EventHandler(this.deleteDirectorButton_Click);
            // 
            // actorsNameLabel
            // 
            this.actorsNameLabel.AutoSize = true;
            this.actorsNameLabel.Location = new System.Drawing.Point(517, 155);
            this.actorsNameLabel.Name = "actorsNameLabel";
            this.actorsNameLabel.Size = new System.Drawing.Size(77, 15);
            this.actorsNameLabel.TabIndex = 101;
            this.actorsNameLabel.Text = "Actors name:";
            // 
            // directorsNameLabel
            // 
            this.directorsNameLabel.AutoSize = true;
            this.directorsNameLabel.Location = new System.Drawing.Point(674, 155);
            this.directorsNameLabel.Name = "directorsNameLabel";
            this.directorsNameLabel.Size = new System.Drawing.Size(90, 15);
            this.directorsNameLabel.TabIndex = 102;
            this.directorsNameLabel.Text = "Directors name:";
            // 
            // actorsBioLabel
            // 
            this.actorsBioLabel.AutoSize = true;
            this.actorsBioLabel.Location = new System.Drawing.Point(517, 203);
            this.actorsBioLabel.Name = "actorsBioLabel";
            this.actorsBioLabel.Size = new System.Drawing.Size(64, 15);
            this.actorsBioLabel.TabIndex = 103;
            this.actorsBioLabel.Text = "Actors bio:";
            // 
            // directorsBioLabel
            // 
            this.directorsBioLabel.AutoSize = true;
            this.directorsBioLabel.Location = new System.Drawing.Point(674, 203);
            this.directorsBioLabel.Name = "directorsBioLabel";
            this.directorsBioLabel.Size = new System.Drawing.Size(77, 15);
            this.directorsBioLabel.TabIndex = 104;
            this.directorsBioLabel.Text = "Directors bio:";
            // 
            // genreNamelabel
            // 
            this.genreNamelabel.AutoSize = true;
            this.genreNamelabel.Location = new System.Drawing.Point(12, 398);
            this.genreNamelabel.Name = "genreNamelabel";
            this.genreNamelabel.Size = new System.Drawing.Size(74, 15);
            this.genreNamelabel.TabIndex = 106;
            this.genreNamelabel.Text = "Genre name:";
            // 
            // addGenreTextBox
            // 
            this.addGenreTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.addGenreTextBox.Location = new System.Drawing.Point(12, 416);
            this.addGenreTextBox.Name = "addGenreTextBox";
            this.addGenreTextBox.Size = new System.Drawing.Size(100, 23);
            this.addGenreTextBox.TabIndex = 105;
            // 
            // categoryNameLabel
            // 
            this.categoryNameLabel.AutoSize = true;
            this.categoryNameLabel.Location = new System.Drawing.Point(138, 398);
            this.categoryNameLabel.Name = "categoryNameLabel";
            this.categoryNameLabel.Size = new System.Drawing.Size(91, 15);
            this.categoryNameLabel.TabIndex = 108;
            this.categoryNameLabel.Text = "Category name:";
            // 
            // addCategoryTextBox
            // 
            this.addCategoryTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.addCategoryTextBox.Location = new System.Drawing.Point(138, 416);
            this.addCategoryTextBox.Name = "addCategoryTextBox";
            this.addCategoryTextBox.Size = new System.Drawing.Size(100, 23);
            this.addCategoryTextBox.TabIndex = 107;
            // 
            // countryNameLabel
            // 
            this.countryNameLabel.AutoSize = true;
            this.countryNameLabel.Location = new System.Drawing.Point(263, 398);
            this.countryNameLabel.Name = "countryNameLabel";
            this.countryNameLabel.Size = new System.Drawing.Size(86, 15);
            this.countryNameLabel.TabIndex = 110;
            this.countryNameLabel.Text = "Country name:";
            // 
            // addCountryTextBox
            // 
            this.addCountryTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.addCountryTextBox.Location = new System.Drawing.Point(263, 416);
            this.addCountryTextBox.Name = "addCountryTextBox";
            this.addCountryTextBox.Size = new System.Drawing.Size(100, 23);
            this.addCountryTextBox.TabIndex = 109;
            // 
            // ratingNameLabel
            // 
            this.ratingNameLabel.AutoSize = true;
            this.ratingNameLabel.Location = new System.Drawing.Point(387, 398);
            this.ratingNameLabel.Name = "ratingNameLabel";
            this.ratingNameLabel.Size = new System.Drawing.Size(77, 15);
            this.ratingNameLabel.TabIndex = 112;
            this.ratingNameLabel.Text = "Rating name:";
            // 
            // addRatingTextBox
            // 
            this.addRatingTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.addRatingTextBox.Location = new System.Drawing.Point(387, 416);
            this.addRatingTextBox.Name = "addRatingTextBox";
            this.addRatingTextBox.Size = new System.Drawing.Size(100, 23);
            this.addRatingTextBox.TabIndex = 111;
            // 
            // deleteActorFromMovieButton
            // 
            this.deleteActorFromMovieButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.deleteActorFromMovieButton.FlatAppearance.BorderSize = 0;
            this.deleteActorFromMovieButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.deleteActorFromMovieButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteActorFromMovieButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteActorFromMovieButton.Location = new System.Drawing.Point(517, 114);
            this.deleteActorFromMovieButton.Name = "deleteActorFromMovieButton";
            this.deleteActorFromMovieButton.Size = new System.Drawing.Size(138, 38);
            this.deleteActorFromMovieButton.TabIndex = 113;
            this.deleteActorFromMovieButton.Text = "delete actor from movie";
            this.deleteActorFromMovieButton.UseVisualStyleBackColor = false;
            this.deleteActorFromMovieButton.Click += new System.EventHandler(this.deleteActorFromMovieButton_Click);
            // 
            // DeleteDirectorFromMovieButton
            // 
            this.DeleteDirectorFromMovieButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DeleteDirectorFromMovieButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteDirectorFromMovieButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DeleteDirectorFromMovieButton.FlatAppearance.BorderSize = 0;
            this.DeleteDirectorFromMovieButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.DeleteDirectorFromMovieButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeleteDirectorFromMovieButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteDirectorFromMovieButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteDirectorFromMovieButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DeleteDirectorFromMovieButton.Location = new System.Drawing.Point(674, 114);
            this.DeleteDirectorFromMovieButton.Name = "DeleteDirectorFromMovieButton";
            this.DeleteDirectorFromMovieButton.Size = new System.Drawing.Size(138, 38);
            this.DeleteDirectorFromMovieButton.TabIndex = 114;
            this.DeleteDirectorFromMovieButton.Text = "delete director from movie";
            this.DeleteDirectorFromMovieButton.UseVisualStyleBackColor = false;
            this.DeleteDirectorFromMovieButton.Click += new System.EventHandler(this.DeleteDirectorFromMovieButton_Click);
            // 
            // SqlEditorButton
            // 
            this.SqlEditorButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.SqlEditorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SqlEditorButton.FlatAppearance.BorderSize = 0;
            this.SqlEditorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SqlEditorButton.Location = new System.Drawing.Point(1274, 13);
            this.SqlEditorButton.Name = "SqlEditorButton";
            this.SqlEditorButton.Size = new System.Drawing.Size(95, 251);
            this.SqlEditorButton.TabIndex = 115;
            this.SqlEditorButton.Text = "SQL editor";
            this.SqlEditorButton.UseVisualStyleBackColor = false;
            this.SqlEditorButton.Click += new System.EventHandler(this.SqlEditorButton_Click);
            // 
            // DbBackupButton
            // 
            this.DbBackupButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.DbBackupButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DbBackupButton.FlatAppearance.BorderSize = 0;
            this.DbBackupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DbBackupButton.Location = new System.Drawing.Point(1274, 270);
            this.DbBackupButton.Name = "DbBackupButton";
            this.DbBackupButton.Size = new System.Drawing.Size(95, 75);
            this.DbBackupButton.TabIndex = 118;
            this.DbBackupButton.Text = "DB backup";
            this.DbBackupButton.UseVisualStyleBackColor = false;
            this.DbBackupButton.Click += new System.EventHandler(this.DbBackupButton_Click);
            // 
            // DbRecoveryButton
            // 
            this.DbRecoveryButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.DbRecoveryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DbRecoveryButton.FlatAppearance.BorderSize = 0;
            this.DbRecoveryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DbRecoveryButton.Location = new System.Drawing.Point(1274, 352);
            this.DbRecoveryButton.Name = "DbRecoveryButton";
            this.DbRecoveryButton.Size = new System.Drawing.Size(95, 75);
            this.DbRecoveryButton.TabIndex = 119;
            this.DbRecoveryButton.Text = "DB recovery";
            this.DbRecoveryButton.UseVisualStyleBackColor = false;
            this.DbRecoveryButton.Click += new System.EventHandler(this.DbRecoveryButton_Click);
            // 
            // LoggingButton
            // 
            this.LoggingButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.LoggingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoggingButton.FlatAppearance.BorderSize = 0;
            this.LoggingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoggingButton.Location = new System.Drawing.Point(1274, 433);
            this.LoggingButton.Name = "LoggingButton";
            this.LoggingButton.Size = new System.Drawing.Size(95, 75);
            this.LoggingButton.TabIndex = 120;
            this.LoggingButton.Text = "Logging";
            this.LoggingButton.UseVisualStyleBackColor = false;
            // 
            // SqlEditorDataGridView
            // 
            this.SqlEditorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SqlEditorDataGridView.Location = new System.Drawing.Point(14, 13);
            this.SqlEditorDataGridView.Name = "SqlEditorDataGridView";
            this.SqlEditorDataGridView.RowTemplate.Height = 25;
            this.SqlEditorDataGridView.Size = new System.Drawing.Size(783, 466);
            this.SqlEditorDataGridView.TabIndex = 0;
            // 
            // MakeQueryButton
            // 
            this.MakeQueryButton.Location = new System.Drawing.Point(113, 433);
            this.MakeQueryButton.Name = "MakeQueryButton";
            this.MakeQueryButton.Size = new System.Drawing.Size(105, 51);
            this.MakeQueryButton.TabIndex = 2;
            this.MakeQueryButton.Text = "Make query";
            this.MakeQueryButton.UseVisualStyleBackColor = true;
            this.MakeQueryButton.Click += new System.EventHandler(this.MakeQueryButton_Click);
            // 
            // ClearSqlEditorButton
            // 
            this.ClearSqlEditorButton.Location = new System.Drawing.Point(224, 433);
            this.ClearSqlEditorButton.Name = "ClearSqlEditorButton";
            this.ClearSqlEditorButton.Size = new System.Drawing.Size(105, 51);
            this.ClearSqlEditorButton.TabIndex = 1;
            this.ClearSqlEditorButton.Text = "Clear editor";
            this.ClearSqlEditorButton.UseVisualStyleBackColor = true;
            this.ClearSqlEditorButton.Click += new System.EventHandler(this.ClearSqlEditorButton_Click);
            // 
            // SqlEditorTextBox
            // 
            this.SqlEditorTextBox.Location = new System.Drawing.Point(14, 18);
            this.SqlEditorTextBox.Multiline = true;
            this.SqlEditorTextBox.Name = "SqlEditorTextBox";
            this.SqlEditorTextBox.Size = new System.Drawing.Size(409, 409);
            this.SqlEditorTextBox.TabIndex = 0;
            // 
            // SqlEditorPanel
            // 
            this.SqlEditorPanel.Controls.Add(this.MakeQueryButton);
            this.SqlEditorPanel.Controls.Add(this.ClearSqlEditorButton);
            this.SqlEditorPanel.Controls.Add(this.SqlEditorTextBox);
            this.SqlEditorPanel.Location = new System.Drawing.Point(831, 13);
            this.SqlEditorPanel.Name = "SqlEditorPanel";
            this.SqlEditorPanel.Size = new System.Drawing.Size(436, 497);
            this.SqlEditorPanel.TabIndex = 121;
            // 
            // DataGridSqlEditorPanel
            // 
            this.DataGridSqlEditorPanel.Controls.Add(this.SqlEditorDataGridView);
            this.DataGridSqlEditorPanel.Location = new System.Drawing.Point(12, 13);
            this.DataGridSqlEditorPanel.Name = "DataGridSqlEditorPanel";
            this.DataGridSqlEditorPanel.Size = new System.Drawing.Size(813, 497);
            this.DataGridSqlEditorPanel.TabIndex = 122;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1381, 530);
            this.Controls.Add(this.SqlEditorPanel);
            this.Controls.Add(this.DataGridSqlEditorPanel);
            this.Controls.Add(this.LoggingButton);
            this.Controls.Add(this.DbRecoveryButton);
            this.Controls.Add(this.DbBackupButton);
            this.Controls.Add(this.SqlEditorButton);
            this.Controls.Add(this.DeleteDirectorFromMovieButton);
            this.Controls.Add(this.deleteActorFromMovieButton);
            this.Controls.Add(this.ratingNameLabel);
            this.Controls.Add(this.addRatingTextBox);
            this.Controls.Add(this.countryNameLabel);
            this.Controls.Add(this.addCountryTextBox);
            this.Controls.Add(this.categoryNameLabel);
            this.Controls.Add(this.addCategoryTextBox);
            this.Controls.Add(this.genreNamelabel);
            this.Controls.Add(this.addGenreTextBox);
            this.Controls.Add(this.directorsBioLabel);
            this.Controls.Add(this.actorsBioLabel);
            this.Controls.Add(this.directorsNameLabel);
            this.Controls.Add(this.actorsNameLabel);
            this.Controls.Add(this.deleteDirectorButton);
            this.Controls.Add(this.deleteActorButton);
            this.Controls.Add(this.deleteGenreButton);
            this.Controls.Add(this.deleteCategoryButton);
            this.Controls.Add(this.deleteCountryButton);
            this.Controls.Add(this.deleteRatingButton);
            this.Controls.Add(this.addDirectorBioTextBox);
            this.Controls.Add(this.addActorBioTextBox);
            this.Controls.Add(this.addDirectorNamTextBox);
            this.Controls.Add(this.addActorNameTextBox);
            this.Controls.Add(this.addDirectorButton);
            this.Controls.Add(this.addActorButton);
            this.Controls.Add(this.addRatingbutton);
            this.Controls.Add(this.addCountrybutton);
            this.Controls.Add(this.addCategoryButton);
            this.Controls.Add(this.addGenreButton);
            this.Controls.Add(this.changePosterButton);
            this.Controls.Add(this.posterPictureBox);
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
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kino-library";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.posterPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SqlEditorDataGridView)).EndInit();
            this.SqlEditorPanel.ResumeLayout(false);
            this.SqlEditorPanel.PerformLayout();
            this.DataGridSqlEditorPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addGenreButton;
        private System.Windows.Forms.Button changePosterButton;
        private System.Windows.Forms.PictureBox posterPictureBox;
        private System.Windows.Forms.Button viewAllButton;
        private System.Windows.Forms.ListBox actorsListBox;
        private System.Windows.Forms.ListBox directorsListBox;
        private System.Windows.Forms.Label directorsLabel;
        private System.Windows.Forms.Label actorsLabel;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.ComboBox ratingComboBox;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView moviesDataGridView;
        private System.Windows.Forms.Button addCategoryButton;
        private System.Windows.Forms.Button addCountrybutton;
        private System.Windows.Forms.Button addRatingbutton;
        private System.Windows.Forms.Button addActorButton;
        private System.Windows.Forms.Button addDirectorButton;
        private System.Windows.Forms.TextBox addActorNameTextBox;
        private System.Windows.Forms.TextBox addDirectorNamTextBox;
        private System.Windows.Forms.TextBox addActorBioTextBox;
        private System.Windows.Forms.TextBox addDirectorBioTextBox;
        private System.Windows.Forms.Button deleteRatingButton;
        private System.Windows.Forms.Button deleteCountryButton;
        private System.Windows.Forms.Button deleteCategoryButton;
        private System.Windows.Forms.Button deleteGenreButton;
        private System.Windows.Forms.Button deleteActorButton;
        private System.Windows.Forms.Button deleteDirectorButton;
        private System.Windows.Forms.Label actorsNameLabel;
        private System.Windows.Forms.Label directorsNameLabel;
        private System.Windows.Forms.Label actorsBioLabel;
        private System.Windows.Forms.Label directorsBioLabel;
        private System.Windows.Forms.Label genreNamelabel;
        // private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.TextBox addGenreTextBox;
        private System.Windows.Forms.Label categoryNameLabel;
        private System.Windows.Forms.TextBox addCategoryTextBox;
        private System.Windows.Forms.Label countryNameLabel;
        private System.Windows.Forms.TextBox addCountryTextBox;
        private System.Windows.Forms.Label ratingNameLabel;
        private System.Windows.Forms.TextBox addRatingTextBox;
        private System.Windows.Forms.Button deleteActorFromMovieButton;
        private System.Windows.Forms.Button DeleteDirectorFromMovieButton;
        private System.Windows.Forms.Button SqlEditorButton;
        private System.Windows.Forms.Button DbBackupButton;
        private System.Windows.Forms.Button DbRecoveryButton;
        private System.Windows.Forms.Button LoggingButton;
        private System.Windows.Forms.DataGridView SqlEditorDataGridView;
        private System.Windows.Forms.Button MakeQueryButton;
        private System.Windows.Forms.Button ClearSqlEditorButton;
        private System.Windows.Forms.TextBox SqlEditorTextBox;
        private System.Windows.Forms.Panel SqlEditorPanel;
        private System.Windows.Forms.Panel DataGridSqlEditorPanel;
    }
}

