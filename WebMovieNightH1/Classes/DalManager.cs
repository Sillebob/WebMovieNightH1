using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace WebMovieNightH1
{   // Making the class public static ie there can be only 1 instance of this class DalManager.
    public static class DalManager
    {
        // Declaring and assigning an attribut to contain the connectionString.
        private static string cs = @"Data Source=ZBC-E-SKP2438\SQLH1;Initial Catalog=MovieNightH1; Integrated Security=SSPI";

        // Methods.
        #region Method GetFilms.
        // Method to return a list of all the movies.
        public static List<Film> GetFilms()
        {
            // Initialising the list to be returned containing the movies.
            List<Film> films = new List<Film>();

            // Making the database ready and connecting.
            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();

                // Query to the database.
                SqlCommand cmd = new SqlCommand("select film_id, title, released_year, descript, genre from film join film_genre on filmId = film_id join genre on genre_id = genreId", connection);

                // Catches the result of the SQL command.
                SqlDataReader rdr = cmd.ExecuteReader();

                // Making a loop to continue adding films until there isn't any more left in the SQL table.
                while(rdr.Read())
                {
                    // Getting data from the reader and casting it to the correct datatype.
                    int filmId = (int)rdr["film_id"];
                    string title = (string)rdr["title"];
                    int year = (int)rdr["released_year"];
                    string genreType = (string)rdr["genre"];
                    string descript = (string)rdr["descript"];

                    // New movie object.
                    Film f = new Film(filmId, title, year, genreType, descript);

                    // Adding movies to the list films.
                    films.Add(f);
                }                
            }
            return films;
        }
        #endregion Method GetFilm

        #region Method GetFilmsNoGenre.
        // Method to return a list of all the movies - without genre.
        public static List<Film> GetFilmsNoGenre()
        {
            // Initialising the list to be returned containing the movies.
            List<Film> films = new List<Film>();

            // Making the database ready and connecting.
            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();

                // Query to the database.
                SqlCommand cmd = new SqlCommand("select film_id, title, released_year, descript from film", connection);

                // Catches the result of the SQL command.
                SqlDataReader rdr = cmd.ExecuteReader();

                // Making a loop to continue adding films until there isn't any more left in the SQL table.
                while (rdr.Read())
                {
                    // Getting data from the reader and casting it to the correct datatype.
                    int filmId = (int)rdr["film_id"];
                    string title = (string)rdr["title"];
                    int year = (int)rdr["released_year"];
                    string descript = (string)rdr["descript"];

                    // New movie object.
                    Film f = new Film(filmId, title, year, descript);

                    // Adding movies to the list films.
                    films.Add(f);
                }
            }
            return films;
        }
        #endregion Method GetFilmsNoGenre

        #region Method GetActor.
        // Method to return a list of all the actors.
        public static List<Actor> GetActors()
        {
            // Initialising the list to be returned containing the actors.
            List<Actor> actors = new List<Actor>();

            // Making the database ready and connecting.
            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();
                // Query to the database
                SqlCommand cmd = new SqlCommand("select actor_id, first_name, last_name from actor", connection);

                // Catches the result of the SQL command
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    // Getting data from the reader and casting it to the correct datatype.
                    int actorId = (int)rdr["actor_id"];
                    string firstName = (string)rdr["first_name"];
                    string lastName = (string)rdr["last_name"];

                    // New actor object.
                    Actor a = new Actor(actorId, firstName, lastName);

                    // Adding actors to the list films.
                    actors.Add(a);
                }
                return actors;
            }
        }
        #endregion Method GetActor

        #region Method SearchFilm.
        // Method to return a list of all the movies that starts with a specifik letter fx A.
        public static List<Film> SearchFilm(string letter)
        {
            // Making initialising the list to be returned containing the movies.
            List<Film> films = new List<Film>();

            // Making the database ready and connecting.
            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();

                // Query to the database.
                SqlCommand cmd = new SqlCommand("select film_id, title, released_year, descript from film where title like @search", connection);

                // Object to contain parameter.
                SqlParameter sp = new SqlParameter();

                // Parametername.
                sp.ParameterName = "@search";

                // Assigning a value
                sp.Value = letter + "%";

                // Adding the parameter to command.
                cmd.Parameters.Add(sp);
                
                // Catches the result of the SQL command
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    // Getting data from the reader and casting it to the correct datatype.
                    int filmId = (int)rdr["film_id"];
                    string title = (string)rdr["title"];
                    int year = (int)rdr["released_year"];
                    string descript = (string)rdr["descript"];

                    // New movie object.
                    Film f = new Film(filmId, title, year, descript);

                    // Adding movies to the list films.
                    films.Add(f);
                }
                return films;
            }
        }
        #endregion Method SearchFilm.

        #region Method SearchActor.
        // Method to return a list of all the actors.
        public static List<Actor> SearchActor(string letter)
        {
            // Making initialising the list to be returned containing the actors.
            List<Actor> actors = new List<Actor>();

            // Making the database ready and connecting.
            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();
                // Query to the database.
                SqlCommand cmd = new SqlCommand("select actor_id, first_name, last_name from actor where first_name like @search", connection);

                // Object to contain parameter.
                SqlParameter sp = new SqlParameter();

                // Parametername.
                sp.ParameterName = "@search";

                // Assigning a value
                sp.Value = "%" + letter + "%";

                // Adding the parameter to command.
                cmd.Parameters.Add(sp);

                // Catches the result of the SQL command
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    // Getting data from the reader and casting it to the correct datatype.
                    int actorId = (int)rdr["actor_id"];
                    string firstName = (string)rdr["first_name"];
                    string lastName = (string)rdr["last_name"];

                    // New movie object.
                    Actor a = new Actor(actorId, firstName, lastName);

                    // Adding movies to the list films.
                    actors.Add(a);
                }
                return actors;
            }
        }
        #endregion SearchActor.

        #region Method SearchGenre.
        // Method to return a list of all the movies with a specifik genre.
        public static List<Film> SearchGenre(string genre)
        {
            // Making initialising the list to be returned containing the movies.
            List<Film> films = new List<Film>();

            // Making the database ready and connecting.
            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();

                // Query to the database.
                SqlCommand cmd = new SqlCommand("select film_id, title, released_year, descript, genre from film join film_genre on filmId = film_id join genre on genre_id = genreId where genre = @search", connection);

                // Object to contain parameter.
                SqlParameter sp = new SqlParameter();

                // Parametername.
                sp.ParameterName = "@search";

                // Assigning a value
                sp.Value = genre;
                
                // Adding the parameter to command.
                cmd.Parameters.Add(sp);

                // Catches the result of the SQL command
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    // Getting data from the reader and casting it to the correct datatype.
                    int filmId = (int)rdr["film_id"];
                    string title = (string)rdr["title"];
                    int year = (int)rdr["released_year"];
                    string genreType = (string)rdr["genre"];
                    string descript = (string)rdr["descript"];

                    // New movie object.
                    Film f = new Film(filmId, title, year, genreType, descript);

                    // Adding movies to the list films.
                    films.Add(f);
                }
                return films;
            }
        }
        #endregion Method SearchGenre.
    }
}
