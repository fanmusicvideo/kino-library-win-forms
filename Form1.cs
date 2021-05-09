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
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GridFill();
            FillComboBoxes();
            Clear();
            // FillListBoxes();
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
            }
        }

        private void FillComboBoxes()
        {
            using (var mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                string genreQuery = "select * from genre";
                string categoryQuery = "select * from category";
                string ratingQuery = "select * from rating";
                string countryQuery = "select * from country";
                MySqlCommand mscGenre = new MySqlCommand(genreQuery, mysqlCon);
                MySqlCommand mscCategory = new MySqlCommand(categoryQuery, mysqlCon);
                MySqlCommand mscRating = new MySqlCommand(ratingQuery, mysqlCon);
                MySqlCommand mscCountry = new MySqlCommand(countryQuery, mysqlCon);
                MySqlDataReader myReaderGenre;
                myReaderGenre = mscGenre.ExecuteReader();
                while (myReaderGenre.Read())
                    {
                        genreComboBox.Items.Add(myReaderGenre.GetString("name"));
                    }
                mysqlCon.Close();
                mysqlCon.Open();
                MySqlDataReader myReaderCategory;
                myReaderCategory = mscCategory.ExecuteReader();
                while (myReaderCategory.Read())
                    {
                        categoryComboBox.Items.Add(myReaderCategory.GetString("name"));
                    }
                mysqlCon.Close();
                mysqlCon.Open();
                MySqlDataReader myReaderRating;
                myReaderRating = mscRating.ExecuteReader();
                while (myReaderRating.Read())
                    {
                        ratingComboBox.Items.Add(myReaderRating.GetString("name"));
                    }
                mysqlCon.Close();
                mysqlCon.Open();
                MySqlDataReader myReaderCountry;
                myReaderCountry = mscCountry.ExecuteReader();
                while (myReaderCountry.Read())
                    {
                        countryComboBox.Items.Add(myReaderCountry.GetString("name"));
                    }
            }
        }

        /* private void FillListBoxes()
        {
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

        } */

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
                string genreQuery = "select * from genre where genre.id = " + moviesDataGridView.CurrentRow.Cells[6].Value.ToString();
                string categoryQuery = "select * from category where category.id = " + moviesDataGridView.CurrentRow.Cells[7].Value.ToString();
                string ratingQuery = "select * from rating where rating.id = " + moviesDataGridView.CurrentRow.Cells[8].Value.ToString();
                string countryQuery = "select * from country where country.id = " + moviesDataGridView.CurrentRow.Cells[5].Value.ToString();
                MySqlCommand mscGenre = new MySqlCommand(genreQuery, connection);
                MySqlCommand mscCategory = new MySqlCommand(categoryQuery, connection);
                MySqlCommand mscRating = new MySqlCommand(ratingQuery, connection);
                MySqlCommand mscCountry = new MySqlCommand(countryQuery, connection);
                MySqlDataReader myReaderGenre;
                myReaderGenre = mscGenre.ExecuteReader();
                myReaderGenre.Read();
                genreComboBox.Text = myReaderGenre.GetString("name");

                connection.Close();
                connection.Open();
                MySqlDataReader myReaderCategory;
                myReaderCategory = mscCategory.ExecuteReader();
                myReaderCategory.Read();
                categoryComboBox.Text = myReaderCategory.GetString("name");

                connection.Close();
                connection.Open();
                MySqlDataReader myReaderRating;
                myReaderRating = mscRating.ExecuteReader();
                myReaderRating.Read();
                ratingComboBox.Text = myReaderRating.GetString("name");

                connection.Close();
                connection.Open();
                MySqlDataReader myReaderCountry;
                myReaderCountry = mscCountry.ExecuteReader();
                myReaderCountry.Read();
                countryComboBox.Text = myReaderCountry.GetString("name");

                connection.Close();
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
        {   if (titleTextBox.Text != "" && descriptionTextBox.Text != "" && yearTextBox.Text != "" && genreComboBox.Text != "" && categoryComboBox.Text != "" && ratingComboBox.Text != "" && countryComboBox.Text != "" && actorsListBox.Items.Count != 0 && directorsListBox.Items.Count != 0)
            {
                using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                {
                    mysqlCon.Open();

                    MemoryStream ms = new MemoryStream();
                    posterPictureBox.Image.Save(ms, posterPictureBox.Image.RawFormat);
                    byte[] imgBlob = ms.ToArray();

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
                        command.Parameters.AddWithValue("_movie_id", movieCount);
                        command.Parameters.AddWithValue("_name", actor);
                        command.ExecuteNonQuery();
                        mysqlCon.Close();
                    }
                    MessageBox.Show("Submitted Successfully");
                    Clear();
                    GridFill();

                }
            }
            else
            {
                MessageBox.Show("Some fields are empty");
            }
            
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
                MessageBox.Show("Deleted Successfully");
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
                    MessageBox.Show("Error");
                }
            }
        }

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
                }

            }

        }

        private void addActorButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                if (addActorNameTextBox.Text != "" && addActorBioTextBox.Text != "")
                {
                    mysqlCon.Open();
                    MySqlCommand mySqlCmd = new MySqlCommand("ActorAddOrEdit", mysqlCon);
                    mySqlCmd.CommandType = CommandType.StoredProcedure;
                    mySqlCmd.Parameters.AddWithValue("_id", actorID);
                    mySqlCmd.Parameters.AddWithValue("_name", addActorNameTextBox.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_bio", addActorBioTextBox.Text.Trim());
                    mySqlCmd.ExecuteNonQuery();
                    mysqlCon.Close();
                    MessageBox.Show("Submitted Successfully");
                    actorsListBox.Items.Clear();
                }
                else
                {
                    MessageBox.Show("Some fields are empty");
                }
                addActorBioTextBox.Text = "";
                addActorNameTextBox.Text = ""; 
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
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");
                addActorBioTextBox.Text = "";
                addActorNameTextBox.Text = "";
                mysqlCon.Close();
                actorsListBox.Items.Clear();
            }
        }

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
                    string directorsBio = myReaderDirectorBio.GetString("bio");
                    addDirectorBioTextBox.Text = directorsBio;
                    int director_id = myReaderDirectorBio.GetInt32("id");
                    directorID = director_id;
                }
            }
        }

        private void addDirectorButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                if (addDirectorNamTextBox.Text != "" && addDirectorBioTextBox.Text != "")
                {
                    mysqlCon.Open();
                    MySqlCommand mySqlCmd = new MySqlCommand("DirectorAddOrEdit", mysqlCon);
                    mySqlCmd.CommandType = CommandType.StoredProcedure;
                    mySqlCmd.Parameters.AddWithValue("_id", directorID);
                    mySqlCmd.Parameters.AddWithValue("_name", addDirectorNamTextBox.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_bio", addDirectorBioTextBox.Text.Trim());
                    mySqlCmd.ExecuteNonQuery();
                    mysqlCon.Close();
                    MessageBox.Show("Submitted Successfully");
                    directorsListBox.Items.Clear();
                }
                else
                {
                    MessageBox.Show("Some fields are empty");
                }
                addDirectorBioTextBox.Text = "";
                addDirectorNamTextBox.Text = "";
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
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");
                addDirectorBioTextBox.Text = "";
                addDirectorNamTextBox.Text = "";
                mysqlCon.Close();
                directorsListBox.Items.Clear();
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
                    MessageBox.Show("Submitted Successfully");
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
                }
                else
                {
                    MessageBox.Show("Some fields are empty");
                }
                addGenreTextBox.Text = "";
            }
        }

        private void deleteGenreButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("DeleteGenreById", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_id", genreID);
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");
                addGenreTextBox.Text = "";
                mysqlCon.Close();
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
            }
        }

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
            }
        }
    }
}