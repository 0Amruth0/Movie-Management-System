using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieManagementSystem.DataAccess;
using MovieManagementSystem.BusinessLogic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MovieManagementSystem
{
    public partial class MovieManager : Form
    {
        public MovieManager()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private int currIndex = 0;

        private void clear() {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }

        private void addMovie(object sender, EventArgs e)
        {
            int movieID;
            string movieTitle = textBox2.Text;
            string movieDirector = textBox3.Text;
            DateTime releaseDate = dateTimePicker1.Value;
            MovieGenre movieGenre;

            int errCount = 0;

            if (string.IsNullOrWhiteSpace(movieTitle) || string.IsNullOrWhiteSpace(movieDirector))
            {
                MessageBox.Show("Please fill in all the fields.");
                errCount++;
            }

            if (!int.TryParse(textBox1.Text, out movieID))
            {
                MessageBox.Show("Invalid Movie ID.");
                errCount++;
            }

            if (!Enum.TryParse(comboBox1.SelectedItem.ToString(), out movieGenre))
            {
                MessageBox.Show("Invalid Movie Genre.");
                errCount++;
            }

            if (MovieService.movieDictionary.ContainsKey(movieID))
            {
                MessageBox.Show("Movie ID already exists.");
                errCount++;
            }


            Movie newMovie;
            if (errCount == 0)
            {
                newMovie = new Movie(movieID, movieTitle, movieGenre, movieDirector, releaseDate);
            }
            else
            {
                newMovie = new Movie(-1, movieTitle, movieGenre, movieDirector, releaseDate);
            }

            bool result = new MovieService().AddMovie(newMovie);
            if (result)
            {
                MessageBox.Show("Movie added successfully :).");
            }
            else
            {
                MessageBox.Show("Movie add unsuccessfull :(.");
            }

            var movieDetails = $"Movie ID: {newMovie.movieID},Title: {newMovie.movieTitle}, Genre: {newMovie.movieGenre}, Year: {newMovie.releaseYear}";
            listBox1.Items.Add(movieDetails);

            this.clear();

        }

        private void updateMovie(object sender, EventArgs e)
        {
            int movieID;
            string movieTitle = textBox2.Text;
            string movieDirector = textBox3.Text;
            DateTime releaseDate = dateTimePicker1.Value;
            MovieGenre movieGenre;


            if (string.IsNullOrWhiteSpace(movieTitle) || string.IsNullOrWhiteSpace(movieDirector))
            {
                MessageBox.Show("Please fill in all the fields.");
            }

            if (!int.TryParse(textBox1.Text, out movieID))
            {
                MessageBox.Show("Invalid Movie ID.");
            }

            if (!Enum.TryParse(comboBox1.SelectedItem.ToString(), out movieGenre))
            {
                MessageBox.Show("Invalid Movie Genre.");
            }

            Movie updatedMovie = new Movie(movieID, movieTitle, movieGenre, movieDirector, releaseDate);

            bool result = new MovieService().UpdateMovie(movieID, updatedMovie);
            if (result)
            {
                MessageBox.Show("Movie Updated successfully :).");
            }
            else
            {
                MessageBox.Show("Movie Update unsuccessfull :(.");
            }

            listBox1.Items.Clear();
            var movieDetails = $"Movie ID: {updatedMovie.movieID},Title: {updatedMovie.movieTitle}, Genre: {updatedMovie.movieGenre}, Year: {updatedMovie.releaseYear}";
            listBox1.Items.Add(movieDetails);

            this.clear();
        }

        private void deleteMovie(object sender, EventArgs e)
        {

            int movieID;
            if (!int.TryParse(textBox1.Text, out movieID))
            {
                MessageBox.Show("Invalid Movie ID.");
            }
            bool result = new MovieService().DeleteMovie(movieID);
            if (result)
            {
                MessageBox.Show("Deleted Movie Successfully :).");
                var movies = new MovieService().GetAllMoviesSorted();
                JsonHelper.SaveToFile("movies.json", movies);

                listBox1.Items.Clear();
                foreach (var movie in movies) {
                    var movieDetails = $"Movie ID: {movie.movieID},Title: {movie.movieTitle}, Genre: {movie.movieGenre}, Year: {movie.releaseYear}";
                    listBox1.Items.Add(movieDetails);
                }
            }
            else
            {
                MessageBox.Show("Delete Movie Unsuccessful :(.");
            }


        }

        private void viewAllMovies(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // Clear previous items

            MovieService ms = new MovieService();
            if (ms == null)
            {
                listBox1.Items.Add("No Movies");
            }
            else
            {
                var movies = ms.GetAllMoviesSorted();
                foreach (var movie in movies)
                {
                    var movieDetails = $"Movie ID: {movie.movieID},Title: {movie.movieTitle}, Genre: {movie.movieGenre}, Year: {movie.releaseYear}";
                    listBox1.Items.Add(movieDetails);
                }
                if (movies.Count == 0)
                {
                    MessageBox.Show("No movies to display.");
                }
            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label_movieID(object sender, EventArgs e)
        {

        }

        private void label_movieTitle(object sender, EventArgs e)
        {

        }

        private void label_movieGenre(object sender, EventArgs e)
        {

        }

        private void label_movieReleaseYear(object sender, EventArgs e)
        {

        }

        private void textbox_movieID(object sender, EventArgs e)
        {

        }

        private void textbox_movieTitle(object sender, EventArgs e)
        {

        }

        private void combobox_movieGenre(object sender, EventArgs e)
        {
            //var selectedItem = (MovieGenre)comboBox1.SelectedItem;


        }

        private void textbox_movieReleaseYear(object sender, EventArgs e)
        {

        }

        private void picker_movieReleaseYear(object sender, EventArgs e)
        {

        }

        private void textbox_Heading(object sender, EventArgs e)
        {

        }

        private void label_movieDirector(object sender, EventArgs e)
        {

        }

        private void textbox_movieDirector(object sender, EventArgs e)
        {

        }

        private void first(object sender, EventArgs e)
        {
            if (MovieService.movieDictionary.Count == 0)
            {
                MessageBox.Show("Invalid Current Index to perform the Operation ! ");
            }
            else
            {
                listBox1.Items.Clear();
                MovieService ms = new MovieService();
                currIndex = 0;
                var temp = MovieService.movieDictionary.First();
                Movie movie = ms.GetMovie(temp.Key);

                var movieDetails = $"Movie ID: {movie.movieID},Title: {movie.movieTitle}, Genre: {movie.movieGenre}, Year: {movie.releaseYear}";
                listBox1.Items.Add(movieDetails);
            }
        }

        private void previous(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            currIndex -= 1;
            MovieService ms = new MovieService();
            if (currIndex >= 0 && currIndex < MovieService.movieDictionary.Count -1)
            {
                int key = MovieService.movieDictionary.ElementAt(currIndex).Key;
                Movie movie = ms.GetMovie(key);
                var movieDetails = $"Movie ID: {movie.movieID},Title: {movie.movieTitle}, Genre: {movie.movieGenre}, Year: {movie.releaseYear}";
                listBox1.Items.Add(movieDetails);
            }
            else
            {
                MessageBox.Show("Invalid Current Index to perform the Operation ! ");
            }
        }
        private void next(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            currIndex += 1;
            MovieService ms = new MovieService();
            if (currIndex >= 0 && currIndex <= MovieService.movieDictionary.Count-1)
            {
                int key = MovieService.movieDictionary.ElementAt(currIndex).Key;
                Movie movie = ms.GetMovie(key);
                var movieDetails = $"Movie ID: {movie.movieID},Title: {movie.movieTitle}, Genre: {movie.movieGenre}, Year: {movie.releaseYear}";
                listBox1.Items.Add(movieDetails);
            }
            else
            {
                MessageBox.Show("Invalid Current Index to perform the Operation ! ");
            }
        }

        private void last(object sender, EventArgs e)
        {
            if (MovieService.movieDictionary.Count == 0)
            {
                MessageBox.Show("Invalid Current Index to perform the Operation ! ");
            }
            else
            {
                listBox1.Items.Clear();
                MovieService ms = new MovieService();
                currIndex = MovieService.movieDictionary.Count - 1; ;
                var temp = MovieService.movieDictionary.Last();
                Movie movie = ms.GetMovie(temp.Key);

                var movieDetails = $"Movie ID: {movie.movieID},Title: {movie.movieTitle}, Genre: {movie.movieGenre}, Year: {movie.releaseYear}";
                listBox1.Items.Add(movieDetails);
            }

        }

        private void save(object sender, EventArgs e)
        {

            // Define the file path
            string filePath = "movies.json";

            // Read existing data from the JSON file
            var existingMovies = JsonHelper.LoadFromFile<List<Movie>>(filePath) ?? new List<Movie>();

            // Get the current movies from the service
            var currentMovies = new MovieService().GetAllMoviesSorted();

            // Merge the existing movies with the current movies
            foreach (var currentMovie in currentMovies)
            {
                if (!existingMovies.Any(m => m.movieID == currentMovie.movieID))
                {
                    existingMovies.Add(currentMovie);
                }
            }

            // Save the merged list back to the JSON file
            JsonHelper.SaveToFile(filePath, existingMovies);
            MessageBox.Show("Movies saved successfullt");

        }

        private void load(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                openFileDialog.Title = "Open JSON File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    // Deserialize the movie data from the selected JSON file
                    var movies = JsonHelper.LoadFromFile<List<Movie>>(filePath);
                    if (movies != null)
                    {
                        // Load movies into the movie service
                        new MovieService().LoadMovies(movies);
                        MessageBox.Show("Movies loaded successfully.");

                        // Update the listbox to reflect loaded movies
                        listBox1.Items.Clear();
                        foreach (var movie in movies)
                        {
                            var movieDetails = $"Movie ID: {movie.movieID},Title: {movie.movieTitle}, Genre: {movie.movieGenre}, Year: {movie.releaseYear}";

                            listBox1.Items.Add(movieDetails);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to load movies. Please ensure the file exists and is in the correct format.");
                    }


                }
            }
        }
    }
}
