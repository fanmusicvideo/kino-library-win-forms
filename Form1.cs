using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using System.IO;


namespace kino_library
{
    public partial class Form1 : Form
    {
        string connectionString = @"Server=localhost;Database=kino;Uid=root;Pwd=ilikemyname;";
        int movieID = 0;
        int genreID = 0;
        int ratingID = 0;
        int categoryID = 0;
        int countryID = 0;
        int actorID = 0;
        int directorID = 0;

        public Form1()
        {
            InitializeComponent();
            SqlEditorPanel.Visible = false;
            DataGridSqlEditorPanel.Visible = false;
            LoggingButton.Enabled = false;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GridFill();
            FillComboBoxes();
            Clear();
        }

        private void GridFill()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlDataAdapter command = new MySqlDataAdapter("MovieViewAll", connection);
                command.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable movieDataTable = new DataTable();
                command.Fill(movieDataTable);
                moviesDataGridView.DataSource = movieDataTable;
                moviesDataGridView.Columns[0].Visible = false;
                moviesDataGridView.Columns[4].Visible = false;
                moviesDataGridView.Columns[5].Visible = false;
                moviesDataGridView.Columns[6].Visible = false;
                moviesDataGridView.Columns[7].Visible = false;
                moviesDataGridView.Columns[8].Visible = false;
            }
        }

        private void FillComboBoxes()
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                // category
                connection.Open();
                string categoryQuery = "select * from category";
                MySqlCommand categoryCommand = new MySqlCommand(categoryQuery, connection);
                MySqlDataReader categoryReader;
                categoryReader = categoryCommand.ExecuteReader();
                while (categoryReader.Read())
                {
                    categoryComboBox.Items.Add(categoryReader.GetString("name"));
                }
                connection.Close();

                // country
                connection.Open();
                string countryQuery = "select * from country";
                MySqlCommand countryCommand = new MySqlCommand(countryQuery, connection);
                MySqlDataReader countryReader;
                countryReader = countryCommand.ExecuteReader();
                while (countryReader.Read())
                {
                    countryComboBox.Items.Add(countryReader.GetString("name"));
                }
                connection.Close();

                // genre
                connection.Open();
                string genreQuery = "select * from genre";
                MySqlCommand genreCommand = new MySqlCommand(genreQuery, connection);
                MySqlDataReader genreReader;
                genreReader = genreCommand.ExecuteReader();
                while (genreReader.Read())
                {
                    genreComboBox.Items.Add(genreReader.GetString("name"));
                }
                connection.Close();

                //rating
                connection.Open();
                string ratingQuery = "select * from rating";
                MySqlCommand ratingCommand = new MySqlCommand(ratingQuery, connection);
                MySqlDataReader ratingReader;
                ratingReader = ratingCommand.ExecuteReader();
                while (ratingReader.Read())
                {
                    ratingComboBox.Items.Add(ratingReader.GetString("name"));
                }
                connection.Close();                
            }
        }

        private void moviesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (moviesDataGridView.CurrentRow.Index != -1)
            {
                movieID = Convert.ToInt32(moviesDataGridView.CurrentRow.Cells[0].Value.ToString());
                saveButton.Text = "Update";
                deleteButton.Enabled = Enabled;
                titleTextBox.Text = moviesDataGridView.CurrentRow.Cells[1].Value.ToString();
                yearTextBox.Text = moviesDataGridView.CurrentRow.Cells[3].Value.ToString();
                descriptionTextBox.Text = moviesDataGridView.CurrentRow.Cells[2].Value.ToString();
            }
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string posterQuery = "select poster from movie where movie.id = " + movieID;
                MySqlCommand command = new MySqlCommand(posterQuery, connection);

                MySqlDataAdapter da = new MySqlDataAdapter(command);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (Convert.IsDBNull(ds.Tables[0].Rows[0]["poster"]))
                {
                    posterPictureBox.Image = null;
                    da.Dispose();
                }
                else
                {
                    byte[] poster = (byte[])ds.Tables[0].Rows[0]["poster"];
                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["poster"]);
                    posterPictureBox.Image = Image.FromStream(ms);
                    da.Dispose();
                }
                
                connection.Close();
                connection.Open();
                string countryQuery = "select * from country where country.id = " + moviesDataGridView.CurrentRow.Cells[5].Value.ToString();
                string genreQuery = "select * from genre where genre.id = " + moviesDataGridView.CurrentRow.Cells[6].Value.ToString();
                string categoryQuery = "select * from category where category.id = " + moviesDataGridView.CurrentRow.Cells[7].Value.ToString();
                string ratingQuery = "select * from rating where rating.id = " + moviesDataGridView.CurrentRow.Cells[8].Value.ToString();
                MySqlCommand mscGenre = new MySqlCommand(genreQuery, connection);
                MySqlCommand mscCategory = new MySqlCommand(categoryQuery, connection);
                MySqlCommand mscRating = new MySqlCommand(ratingQuery, connection);
                MySqlCommand mscCountry = new MySqlCommand(countryQuery, connection);
                MySqlDataReader myReaderGenre;
                myReaderGenre = mscGenre.ExecuteReader();
                myReaderGenre.Read();
                genreComboBox.Text = myReaderGenre.GetString("name");
                addGenreTextBox.Text = myReaderGenre.GetString("name");

                connection.Close();
                connection.Open();
                MySqlDataReader myReaderCategory;
                myReaderCategory = mscCategory.ExecuteReader();
                myReaderCategory.Read();
                categoryComboBox.Text = myReaderCategory.GetString("name");
                addCategoryTextBox.Text = myReaderCategory.GetString("name");


                connection.Close();
                connection.Open();
                MySqlDataReader myReaderRating;
                myReaderRating = mscRating.ExecuteReader();
                myReaderRating.Read();
                ratingComboBox.Text = myReaderRating.GetString("name");
                addRatingTextBox.Text = myReaderRating.GetString("name");

                connection.Close();
                connection.Open();
                MySqlDataReader myReaderCountry;
                myReaderCountry = mscCountry.ExecuteReader();
                myReaderCountry.Read();
                countryComboBox.Text = myReaderCountry.GetString("name");
                addCountryTextBox.Text = myReaderCountry.GetString("name");

                connection.Close();
                FillActorsListBox();
                FillDirectorsListBox();
            }
        }

        private void FillActorsListBox()
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string movieActorsQuery = "select actor.name from movie_has_actor inner join actor on movie_has_actor.actor_id = actor.id and movie_has_actor.movie_id = " + movieID;
                MySqlCommand mscMovieActors = new MySqlCommand(movieActorsQuery, connection);
                MySqlDataReader myReaderMovieActors;
                myReaderMovieActors = mscMovieActors.ExecuteReader();
                actorsListBox.Items.Clear();
                while (myReaderMovieActors.Read())
                {
                    actorsListBox.Items.Add(myReaderMovieActors.GetString("name").ToString());
                }
                connection.Close();
            }  
        }

        private void FillDirectorsListBox()
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string movieDirectorsQuery = "select director.name from movie_has_director inner join director on movie_has_director.director_id = director.id and movie_has_director.movie_id = " + movieID;
                MySqlCommand mscMovieDirectors = new MySqlCommand(movieDirectorsQuery, connection);
                MySqlDataReader myReaderMovieDirectors;
                myReaderMovieDirectors = mscMovieDirectors.ExecuteReader();
                directorsListBox.Items.Clear();
                while (myReaderMovieDirectors.Read())
                {
                    directorsListBox.Items.Add(myReaderMovieDirectors.GetString("name").ToString());
                }
                connection.Close();
            }
        }


        private void viewAllButton_MouseClick(object sender, MouseEventArgs e)
        {
            actorsListBox.Items.Clear();
            directorsListBox.Items.Clear();
            using (var mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                string actorQuery = "select * from actor";
                string directorQuery = "select * from director";

                MySqlCommand mscActor = new MySqlCommand(actorQuery, mysqlCon);
                MySqlCommand mscDirector = new MySqlCommand(directorQuery, mysqlCon);

                MySqlDataReader myReaderActor;
                myReaderActor = mscActor.ExecuteReader();
                while (myReaderActor.Read())
                {
                    actorsListBox.Items.Add(myReaderActor.GetString("name"));
                }
                mysqlCon.Close();
                mysqlCon.Open();
                MySqlDataReader myReaderDirector;
                myReaderDirector = mscDirector.ExecuteReader();
                while (myReaderDirector.Read())
                {
                    directorsListBox.Items.Add(myReaderDirector.GetString("name"));
                }
                mysqlCon.Close();

            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (posterPictureBox.Image != null && titleTextBox.Text != "" && descriptionTextBox.Text != "" && yearTextBox.Text != "" && genreComboBox.Text != "" && categoryComboBox.Text != "" && ratingComboBox.Text != "" && countryComboBox.Text != "" && actorsListBox.Items.Count != 0 && directorsListBox.Items.Count != 0)
            {
                using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                {
                    MemoryStream ms = new MemoryStream();
                    posterPictureBox.Image.Save(ms, posterPictureBox.Image.RawFormat);
                    byte[] imgBlob = ms.ToArray();

                    mysqlCon.Open();
                    MySqlCommand mySqlCmd = new MySqlCommand("MovieAddOrEdit", mysqlCon);
                    mySqlCmd.CommandType = CommandType.StoredProcedure;
                    mySqlCmd.Parameters.AddWithValue("_id", movieID);
                    mySqlCmd.Parameters.AddWithValue("_title", titleTextBox.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_description", descriptionTextBox.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_year", yearTextBox.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_genre", genreComboBox.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_category", categoryComboBox.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_rating", ratingComboBox.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_country", countryComboBox.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_img", imgBlob);                    
                    mySqlCmd.ExecuteNonQuery();
                    mysqlCon.Close();


                    mysqlCon.Open();
                    string movieCountQuery = "select GetCountOfMovies() as count";
                    MySqlCommand mscMovieCount = new MySqlCommand(movieCountQuery, mysqlCon);
                    MySqlDataReader myReaderMovieCount;
                    myReaderMovieCount = mscMovieCount.ExecuteReader();
                    myReaderMovieCount.Read();
                    int movieCount = myReaderMovieCount.GetInt32("count");
                    mysqlCon.Close();
                    foreach (object actor in actorsListBox.SelectedItems)
                    {
                        mysqlCon.Open();
                        MySqlCommand command = new MySqlCommand("AddActorToMovie", mysqlCon);
                        command.CommandType = CommandType.StoredProcedure;
                        if (saveButton.Text == "Update")
                        {
                            command.Parameters.AddWithValue("_movie_id", movieID);
                        }
                        else command.Parameters.AddWithValue("_movie_id", movieCount);

                        command.Parameters.AddWithValue("_name", actor);
                        try
                        {
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        
                        mysqlCon.Close();
                    }
                    foreach (object director in directorsListBox.SelectedItems)
                    {
                        mysqlCon.Open();
                        MySqlCommand command = new MySqlCommand("AddDirectorToMovie", mysqlCon);
                        command.CommandType = CommandType.StoredProcedure;
                        if (saveButton.Text == "Update")
                        {
                            command.Parameters.AddWithValue("_movie_id", movieID);
                        }
                        else command.Parameters.AddWithValue("_movie_id", movieCount);

                        command.Parameters.AddWithValue("_name", director);
                        try
                        {
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        mysqlCon.Close();
                        mysqlCon.Close();
                    }
                    if (saveButton.Text == "Update") MessageBox.Show("movie updated");
                    else if (saveButton.Text == "Save") MessageBox.Show("movie saved");
                    Clear();
                    GridFill();
                }
            }
            else if (posterPictureBox.Image == null) MessageBox.Show("poster is empty");
            else if (titleTextBox.Text == "") MessageBox.Show("title field is empty");
            else if (descriptionTextBox.Text == "") MessageBox.Show("description field is empty");
            else if (yearTextBox.Text == "") MessageBox.Show("year field is empty");
            else if (genreComboBox.Text == "") MessageBox.Show("genre field is empty");
            else if (categoryComboBox.Text == "") MessageBox.Show("category field is empty");
            else if (ratingComboBox.Text == "") MessageBox.Show("rating field is empty");
            else if (countryComboBox.Text == "") MessageBox.Show("country field is empty");
            else MessageBox.Show("unrecognized error");
        }

        void Clear()
        {
            actorsListBox.Items.Clear();
            directorsListBox.Items.Clear();
            titleTextBox.Text = yearTextBox.Text = countryComboBox.Text = genreComboBox.Text = categoryComboBox.Text = ratingComboBox.Text = descriptionTextBox.Text = "";
            movieID = 0;
            genreID = 0;
            ratingID = 0;
            categoryID = 0;
            countryID = 0;
            actorID = 0;
            directorID = 0;
            saveButton.Text = "Save";
            deleteButton.Enabled = false;
            posterPictureBox.Image = null;
            addActorBioTextBox.Text = "";
            addActorNameTextBox.Text = "";
            addDirectorBioTextBox.Text = "";
            addDirectorNamTextBox.Text = "";
            addGenreTextBox.Text = "";
            addRatingTextBox.Text = "";
            addCountryTextBox.Text = "";
            addCategoryTextBox.Text = "";

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("DeleteMovieById", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_id", movieID);
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("movie deleted");
                Clear();
                GridFill();
                mysqlCon.Close();
            }
        }

        private void changePosterButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    posterPictureBox.Image = new Bitmap(ofd.FileName);
                }
                catch
                {
                    MessageBox.Show("wrong format");
                }
            }
        }

        // actor CRUD
        private void actorsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (actorsListBox.SelectedItems.Count == 1)
            {
                string selectedActor = actorsListBox.SelectedItem.ToString();
                addActorNameTextBox.Text = selectedActor;
                using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                {
                    mysqlCon.Open();
                    string actorsBioQuery = "select id, bio from actor where actor.name = '" + selectedActor + "'";
                    MySqlCommand mscActorBio = new MySqlCommand(actorsBioQuery, mysqlCon);
                    MySqlDataReader myReaderActorBio;
                    myReaderActorBio = mscActorBio.ExecuteReader();
                    myReaderActorBio.Read();
                    string actorsBio = myReaderActorBio.GetString("bio");
                    addActorBioTextBox.Text = actorsBio;
                    int actor_id = myReaderActorBio.GetInt32("id");
                    actorID = actor_id;
                    mysqlCon.Close();
                }
            }

        }

        private void addActorButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                if (addActorNameTextBox.Text == "")
                {
                    MessageBox.Show("name field is empty");
                }
                else if (addActorBioTextBox.Text == "")
                {
                    MessageBox.Show("bio field is empty");
                }
                else if (actorID != 0)
                {
                    MessageBox.Show("can't add existing actor");
                }
                else if (addActorNameTextBox.Text != "" && addActorBioTextBox.Text != "" && actorID == 0)
                {
                    mysqlCon.Open();
                    MySqlCommand mySqlCmd = new MySqlCommand("ActorAddOrEdit", mysqlCon);
                    mySqlCmd.CommandType = CommandType.StoredProcedure;
                    mySqlCmd.Parameters.AddWithValue("_id", actorID);
                    mySqlCmd.Parameters.AddWithValue("_name", addActorNameTextBox.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_bio", addActorBioTextBox.Text.Trim());
                    mySqlCmd.ExecuteNonQuery();
                    mysqlCon.Close();
                    MessageBox.Show("added actor");
                    actorID = 0;
                    addActorBioTextBox.Text = "";
                    addActorNameTextBox.Text = "";
                    FillActorsListBox();
                }
                else MessageBox.Show("unrecognized error");
                mysqlCon.Close();
            }
        }

        private void deleteActorButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("DeleteActorById", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_id", actorID);
                if (actorID != 0)
                {
                    try
                    {
                        mySqlCmd.ExecuteNonQuery();
                        MessageBox.Show("deleted actor");
                        FillActorsListBox();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    addActorBioTextBox.Text = "";
                    addActorNameTextBox.Text = "";
                    mysqlCon.Close();
                    actorID = 0;
                    FillActorsListBox();
                }
                else if (actorID == 0) MessageBox.Show("can't delete non-existent actor");
                else MessageBox.Show("unrecognized error");
                mysqlCon.Close();
            }
        }

        // director CRUD
        private void directorsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (directorsListBox.SelectedItems.Count == 1)
            {
                string selectedDirector = directorsListBox.SelectedItem.ToString();
                addDirectorNamTextBox.Text = selectedDirector;
                using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                {
                    mysqlCon.Open();
                    string directorsBioQuery = "select id, bio from director where director.name = '" + selectedDirector + "'";
                    MySqlCommand mscDirectorBio = new MySqlCommand(directorsBioQuery, mysqlCon);
                    MySqlDataReader myReaderDirectorBio;
                    myReaderDirectorBio = mscDirectorBio.ExecuteReader();
                    myReaderDirectorBio.Read();
                    string directorBio = myReaderDirectorBio.GetString("bio");
                    addDirectorBioTextBox.Text = directorBio;
                    int director_id = myReaderDirectorBio.GetInt32("id");
                    directorID = director_id;
                    mysqlCon.Close();
                }
            }

        }

        private void addDirectorButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                if (addDirectorNamTextBox.Text == "")
                {
                    MessageBox.Show("name field is empty");
                }
                else if (addDirectorBioTextBox.Text == "")
                {
                    MessageBox.Show("bio field is empty");
                }
                else if (directorID != 0)
                {
                    MessageBox.Show("can't add existing actor");
                }
                else if (addDirectorNamTextBox.Text != "" && addDirectorBioTextBox.Text != "" && directorID == 0)
                {
                    mysqlCon.Open();
                    MySqlCommand mySqlCmd = new MySqlCommand("DirectorAddOrEdit", mysqlCon);
                    mySqlCmd.CommandType = CommandType.StoredProcedure;
                    mySqlCmd.Parameters.AddWithValue("_id", directorID);
                    mySqlCmd.Parameters.AddWithValue("_name", addDirectorNamTextBox.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_bio", addDirectorBioTextBox.Text.Trim());
                    mySqlCmd.ExecuteNonQuery();
                    mysqlCon.Close();
                    MessageBox.Show("added director");
                    directorID = 0;
                    addDirectorBioTextBox.Text = "";
                    addDirectorNamTextBox.Text = "";
                    FillDirectorsListBox();
                }
                else MessageBox.Show("unrecognized error");
                mysqlCon.Close();
            }
        }

        private void deleteDirectorButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("DeleteDirectorById", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_id", directorID);
                if (directorID != 0)
                {
                    try
                    {
                        mySqlCmd.ExecuteNonQuery();
                        MessageBox.Show("deleted director");
                        FillDirectorsListBox();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    addDirectorBioTextBox.Text = "";
                    addDirectorNamTextBox.Text = "";
                    mysqlCon.Close();
                    directorID = 0;
                    FillDirectorsListBox();
                }
                else if (directorID == 0) MessageBox.Show("can't delete non-existent director");
                else MessageBox.Show("unrecognized error");
                mysqlCon.Close();
            }
        }

        // category CRUD
        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = categoryComboBox.SelectedItem.ToString();
            addCategoryTextBox.Text = selectedCategory;
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                string categoryQuery = "select id from category where category.name = '" + selectedCategory + "'";
                MySqlCommand mscCategory = new MySqlCommand(categoryQuery, mysqlCon);
                MySqlDataReader myReaderCategory;
                myReaderCategory = mscCategory.ExecuteReader();
                myReaderCategory.Read();
                int category_id = myReaderCategory.GetInt32("id");
                categoryID = category_id;
                mysqlCon.Close();
            }
        }

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                if (addCategoryTextBox.Text != "")
                {
                    mysqlCon.Open();
                    MySqlCommand mySqlCmd = new MySqlCommand("CategoryAddOrEdit", mysqlCon);
                    mySqlCmd.CommandType = CommandType.StoredProcedure;
                    mySqlCmd.Parameters.AddWithValue("_id", categoryID);
                    mySqlCmd.Parameters.AddWithValue("_name", addCategoryTextBox.Text.Trim());
                    mySqlCmd.ExecuteNonQuery();
                    mysqlCon.Close();
                    MessageBox.Show("category added");
                    categoryComboBox.Text = "";
                    addCategoryTextBox.Text = "";
                    categoryComboBox.Items.Clear();
                    mysqlCon.Open();
                    string categoryQuery = "select * from category";
                    MySqlCommand mscCategory = new MySqlCommand(categoryQuery, mysqlCon);
                    MySqlDataReader myReaderCategory;
                    myReaderCategory = mscCategory.ExecuteReader();
                    while (myReaderCategory.Read())
                    {
                        categoryComboBox.Items.Add(myReaderCategory.GetString("name"));
                    }
                    mysqlCon.Close();
                    categoryID = 0;
                }
                else if (categoryID != 0) MessageBox.Show("can't add existing category");
                else if (addCategoryTextBox.Text == "") MessageBox.Show("name field is empty");
                //else MessageBox.Show("unrecognized error");
                categoryID = 0;
                categoryComboBox.Text = "";
                addCategoryTextBox.Text = "";
                mysqlCon.Close();
            }
        }

        private void deleteCategoryButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("DeleteCategoryById", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_id", categoryID);
                if (categoryID != 0)
                {
                    try
                    {
                        mySqlCmd.ExecuteNonQuery();
                        MessageBox.Show("category deleted");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    addCategoryTextBox.Text = "";
                    mysqlCon.Close();
                    categoryComboBox.Text = "";
                    addCategoryTextBox.Text = "";
                    categoryComboBox.Items.Clear();
                    mysqlCon.Open();
                    string categoryQuery = "select * from category";
                    MySqlCommand mscCategory = new MySqlCommand(categoryQuery, mysqlCon);
                    MySqlDataReader myReaderCategory;
                    myReaderCategory = mscCategory.ExecuteReader();
                    while (myReaderCategory.Read())
                    {
                        categoryComboBox.Items.Add(myReaderCategory.GetString("name"));
                    }
                    mysqlCon.Close();
                    categoryID = 0;
                }
                else if (categoryID == 0) MessageBox.Show("can't delete non-existent category");
                else if (addCategoryTextBox.Text == "") MessageBox.Show("name field is empty");
                else MessageBox.Show("unrecognized error");
                categoryID = 0;
                categoryComboBox.Text = "";
                addCategoryTextBox.Text = "";
                mysqlCon.Close();
            }
        }

        // country CRUD
        private void countryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCountry = countryComboBox.SelectedItem.ToString();
            addCountryTextBox.Text = selectedCountry;
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                string countryQuery = "select id from country where country.name = '" + selectedCountry + "'";
                MySqlCommand mscCountry = new MySqlCommand(countryQuery, mysqlCon);
                MySqlDataReader myReaderCountry;
                myReaderCountry = mscCountry.ExecuteReader();
                myReaderCountry.Read();
                int country_id = myReaderCountry.GetInt32("id");
                countryID = country_id;
                mysqlCon.Close();
            }
        }

        private void addCountryButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                if (addCountryTextBox.Text != "")
                {
                    mysqlCon.Open();
                    MySqlCommand mySqlCmd = new MySqlCommand("CountryAddOrEdit", mysqlCon);
                    mySqlCmd.CommandType = CommandType.StoredProcedure;
                    mySqlCmd.Parameters.AddWithValue("_id", countryID);
                    mySqlCmd.Parameters.AddWithValue("_name", addCountryTextBox.Text.Trim());
                    mySqlCmd.ExecuteNonQuery();
                    mysqlCon.Close();
                    MessageBox.Show("added country");
                    countryComboBox.Text = "";
                    addCountryTextBox.Text = "";
                    countryComboBox.Items.Clear();
                    mysqlCon.Open();
                    string countryQuery = "select * from country";
                    MySqlCommand mscCountry = new MySqlCommand(countryQuery, mysqlCon);
                    MySqlDataReader myReaderCountry;
                    myReaderCountry = mscCountry.ExecuteReader();
                    while (myReaderCountry.Read())
                    {
                        countryComboBox.Items.Add(myReaderCountry.GetString("name"));
                    }
                    mysqlCon.Close();
                    countryID = 0;
                }
                else if (countryID != 0) MessageBox.Show("can't add existing country");
                else if (addCountryTextBox.Text == "") MessageBox.Show("name field is empty");
                //else MessageBox.Show("unrecognized error");
                countryID = 0;
                countryComboBox.Text = "";
                addCountryTextBox.Text = "";
                mysqlCon.Close();
            }
        }

        private void deleteCountryButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("DeleteCountryById", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_id", countryID);
                if (countryID != 0)
                {
                    try
                    {
                        mySqlCmd.ExecuteNonQuery();
                        MessageBox.Show("country deleted");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    addCountryTextBox.Text = "";
                    mysqlCon.Close();
                    countryComboBox.Text = "";
                    addCountryTextBox.Text = "";
                    countryComboBox.Items.Clear();
                    mysqlCon.Open();
                    string countryQuery = "select * from country";
                    MySqlCommand mscCountry = new MySqlCommand(countryQuery, mysqlCon);
                    MySqlDataReader myReaderCountry;
                    myReaderCountry = mscCountry.ExecuteReader();
                    while (myReaderCountry.Read())
                    {
                        countryComboBox.Items.Add(myReaderCountry.GetString("name"));
                    }
                    mysqlCon.Close();
                }
                else if (countryID == 0) MessageBox.Show("can't delete non-existent country");
                else if (addCountryTextBox.Text == "") MessageBox.Show("name field is empty");
                else MessageBox.Show("unrecognized error");
                countryID = 0;
                countryComboBox.Text = "";
                addCountryTextBox.Text = "";
                mysqlCon.Close();
            }
        }

        // genre CRUD
        private void genreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedGenre = genreComboBox.SelectedItem.ToString();
            addGenreTextBox.Text = selectedGenre;
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                string genreBioQuery = "select id from genre where genre.name = '" + selectedGenre + "'";
                MySqlCommand mscGenre = new MySqlCommand(genreBioQuery, mysqlCon);
                MySqlDataReader myReaderGenre;
                myReaderGenre = mscGenre.ExecuteReader();
                myReaderGenre.Read();
                int genre_id = myReaderGenre.GetInt32("id");
                genreID = genre_id;
                mysqlCon.Close();
            }
        }

        private void addGenreButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                if (addGenreTextBox.Text != "")
                {
                    mysqlCon.Open();
                    MySqlCommand mySqlCmd = new MySqlCommand("GenreAddOrEdit", mysqlCon);
                    mySqlCmd.CommandType = CommandType.StoredProcedure;
                    mySqlCmd.Parameters.AddWithValue("_id", genreID);
                    mySqlCmd.Parameters.AddWithValue("_name", addGenreTextBox.Text.Trim());
                    mySqlCmd.ExecuteNonQuery();
                    mysqlCon.Close();
                    MessageBox.Show("added genre");
                    genreComboBox.Text = "";
                    addGenreTextBox.Text = "";
                    genreComboBox.Items.Clear();
                    mysqlCon.Open();
                    string genreQuery = "select * from genre";
                    MySqlCommand mscGenre = new MySqlCommand(genreQuery, mysqlCon);
                    MySqlDataReader myReaderGenre;
                    myReaderGenre = mscGenre.ExecuteReader();
                    while (myReaderGenre.Read())
                    {
                        genreComboBox.Items.Add(myReaderGenre.GetString("name"));
                    }
                    mysqlCon.Close();
                    genreID = 0;
                }
                else if (genreID != 0) MessageBox.Show("can't add existing genre");
                else if (addGenreTextBox.Text == "") MessageBox.Show("name field is empty");
                //else MessageBox.Show("unrecognized error");
                genreID = 0;
                genreComboBox.Text = "";
                addGenreTextBox.Text = "";
                mysqlCon.Close();
            }
        }

        private void deleteGenreButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("DeleteGenreById", connection);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_id", genreID);
                if (genreID != 0)
                {
                    try
                    {
                        mySqlCmd.ExecuteNonQuery();
                        MessageBox.Show("genre deleted");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    connection.Close();
                    genreID = 0;
                    addGenreTextBox.Text = "";
                    genreComboBox.Text = "";
                    genreComboBox.Items.Clear();
                    connection.Open();
                    string genreQuery = "select * from genre";
                    MySqlCommand mscGenre = new MySqlCommand(genreQuery, connection);
                    MySqlDataReader myReaderGenre;
                    myReaderGenre = mscGenre.ExecuteReader();
                    while (myReaderGenre.Read())
                    {
                        genreComboBox.Items.Add(myReaderGenre.GetString("name"));
                    }
                    connection.Close();
                }
                else if (genreID == 0) MessageBox.Show("can't delete non-existent genre");
                else if (addGenreTextBox.Text == "") MessageBox.Show("name field is empty");
                else MessageBox.Show("unrecognized error");
                genreID = 0;
                genreComboBox.Text = "";
                addGenreTextBox.Text = "";
                connection.Close();
            }
        }

        // rating CRUD
        private void ratingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRating = ratingComboBox.SelectedItem.ToString();
            addRatingTextBox.Text = selectedRating;
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                string ratingQuery = "select id from rating where rating.name = '" + selectedRating + "'";
                MySqlCommand mscRating = new MySqlCommand(ratingQuery, mysqlCon);
                MySqlDataReader myReaderRating;
                myReaderRating = mscRating.ExecuteReader();
                myReaderRating.Read();
                int rating_id = myReaderRating.GetInt32("id");
                ratingID = rating_id;
                mysqlCon.Close();
            }
        }

        private void addRatingButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                if (addRatingTextBox.Text != "")
                {
                    mysqlCon.Open();
                    MySqlCommand mySqlCmd = new MySqlCommand("RatingAddOrEdit", mysqlCon);
                    mySqlCmd.CommandType = CommandType.StoredProcedure;
                    mySqlCmd.Parameters.AddWithValue("_id", ratingID);
                    mySqlCmd.Parameters.AddWithValue("_name", addRatingTextBox.Text.Trim());
                    mySqlCmd.ExecuteNonQuery();
                    mysqlCon.Close();
                    MessageBox.Show("added rating");
                    ratingComboBox.Text = "";
                    addRatingTextBox.Text = "";
                    ratingComboBox.Items.Clear();
                    mysqlCon.Open();
                    string ratingQuery = "select * from rating";
                    MySqlCommand mscRating = new MySqlCommand(ratingQuery, mysqlCon);
                    MySqlDataReader myReaderRating;
                    myReaderRating = mscRating.ExecuteReader();
                    while (myReaderRating.Read())
                    {
                        ratingComboBox.Items.Add(myReaderRating.GetString("name"));
                    }
                    mysqlCon.Close();
                    ratingID = 0;
                }
                else if (ratingID != 0) MessageBox.Show("can't add existing rating");
                else if (addRatingTextBox.Text == "") MessageBox.Show("name field is empty");
                //else MessageBox.Show("unrecognized error");
                ratingID = 0;
                ratingComboBox.Text = "";
                addRatingTextBox.Text = "";
                mysqlCon.Close();
            }
        }

        private void deleteRatingButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("DeleteRatingById", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_id", ratingID);
                if (ratingID != 0)
                {
                    try
                    {
                        mySqlCmd.ExecuteNonQuery();
                        MessageBox.Show("rating deleted");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    addRatingTextBox.Text = "";
                    mysqlCon.Close();
                    ratingComboBox.Text = "";
                    addRatingTextBox.Text = "";
                    ratingComboBox.Items.Clear();
                    ratingID = 0;
                    mysqlCon.Open();
                    string ratingQuery = "select * from rating";
                    MySqlCommand mscRating = new MySqlCommand(ratingQuery, mysqlCon);
                    MySqlDataReader myReaderRating;
                    myReaderRating = mscRating.ExecuteReader();
                    while (myReaderRating.Read())
                    {
                        ratingComboBox.Items.Add(myReaderRating.GetString("name"));
                    }
                    mysqlCon.Close();
                }
                else if (ratingID == 0) MessageBox.Show("can't delete non-existent rating");
                else if (addRatingTextBox.Text == "") MessageBox.Show("name field is empty");
                else MessageBox.Show("unrecognized error");
                ratingID = 0;
                ratingComboBox.Text = "";
                addRatingTextBox.Text = "";
                mysqlCon.Close();
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void deleteActorFromMovieButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                if (actorsListBox.SelectedItem != null && actorID != 0)
                {
                    string actor_name = actorsListBox.SelectedItem.ToString();
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("DeleteActorFromMovie", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("_movie_id", movieID);
                    command.Parameters.AddWithValue("_name", actor_name);
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("actor deleted from movie");
                        FillActorsListBox();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (movieID == 0) MessageBox.Show("movie is not selected");
                else if (actorsListBox.SelectedItem == null) MessageBox.Show("actor is not selected");
                else MessageBox.Show("unrecognized error");
                connection.Close();
            }
        }

        private void DeleteDirectorFromMovieButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                if (directorsListBox.SelectedItem != null && movieID != 0)
                {
                    string director_name = directorsListBox.SelectedItem.ToString();
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("DeleteDirectorFromMovie", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("_movie_id", movieID);
                    command.Parameters.AddWithValue("_name", director_name);
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("director deleted from movie");
                        FillDirectorsListBox();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (movieID == 0) MessageBox.Show("movie is not selected");
                else if (directorsListBox.SelectedItem == null) MessageBox.Show("director is not selected");
                else MessageBox.Show("unrecognized error");
                connection.Close();
            }
        }

        private void SqlEditorButton_Click(object sender, EventArgs e)
        {
            if (SqlEditorPanel.Visible == true) SqlEditorPanel.Visible = false;
            else if (SqlEditorPanel.Visible == false) SqlEditorPanel.Visible = true;
            if (DataGridSqlEditorPanel.Visible == true) DataGridSqlEditorPanel.Visible = false;
            else if (DataGridSqlEditorPanel.Visible == false) DataGridSqlEditorPanel.Visible = true;
        }

        private void ClearSqlEditorButton_Click(object sender, EventArgs e)
        {
            SqlEditorTextBox.Clear();
            SqlEditorDataGridView.DataSource = null;
            SqlEditorDataGridView.Rows.Clear();
        }

        private void MakeQueryButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = SqlEditorTextBox.Text;
                    MySqlDataAdapter command = new MySqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    command.Fill(table);
                    SqlEditorDataGridView.DataSource = table;
                }
                catch
                {
                    MessageBox.Show("query error", "syntax error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void DbBackupButton_Click(object sender, EventArgs e)
        {
            string file = "backup.sql";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    MessageBox.Show("backup created", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    /* using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ExportToFile(file);
                        conn.Close();
                        
                    } */
                    conn.Close();
                }
            }
        }

        private void DbRecoveryButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    MessageBox.Show("recovery seccessed", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    /* using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ImportFromFile(file);
                        conn.Close();
                        UpdateTable();
                    } */
                    conn.Close();
                }
            }
        }
    }
}