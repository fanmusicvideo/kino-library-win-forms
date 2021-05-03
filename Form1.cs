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


namespace kino_library
{
    public partial class Form1 : Form
    {
        string connectionString = @"Server=localhost;Database=kino;Uid=root;Pwd=ilikemyname;";
        int movieID = 0;
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
            
        }

        void Clear()
        {
            actorsListBox.Items.Clear();
            directorsListBox.Items.Clear();
            titleTextBox.Text = yearTextBox.Text = countryComboBox.Text = genreComboBox.Text = categoryComboBox.Text = ratingComboBox.Text = descriptionTextBox.Text = "";
            movieID = 0;
            saveButton.Text = "Save";
            deleteButton.Enabled = false;
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
    }
}