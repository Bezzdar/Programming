using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Programming2
{
    public partial class MainForm : Form
    {
        Rectangle[] _rectangles = new Rectangle[5];
        Rectangle _currentRectangle = new Rectangle();
        Movie[] _movies = new Movie[5];
        Movie _currentMovie = new Movie();
        Type[] typeModel = new Type[6] { typeof(Colors), typeof(FormOfEducation), typeof(Genre), typeof(Manufacturers), typeof(Seasons), typeof(Weekday) };

            public MainForm()
            {
                InitializeComponent();
                // 
                // Initialize ComboBoxSeasons
                // 
                object[] values = Enum.GetValues(typeof(Seasons)).Cast<object>().ToArray();
                ComboBoxSeason.Items.AddRange(values);
                Random random = new Random();
                for (int i  = 0; i<5; i++)
                {
                    Rectangle rectangle = new Rectangle(random.Next(6, 51), random.Next(3, 50), Colors.Green);
                    _rectangles[i] = rectangle;
                    ClassesRectanglesListBox.Items.Add(rectangle);
                }
                
                string[] listBoxMoviesItems = new string[5];
                string[] movieTitles = new string[5] { "Гарри Поттер", "Драйв", "Игра престолов", "Шерлок", "Зеленая книга" };
                for (int i = 0; i < 5; i++)
                {
                    int durationMinutes = random.Next(60, 280);
                    int releaseYear = random.Next(1950, DateTime.Now.Year + 1);
                    double rating = Math.Round(random.NextDouble() * 10, 1);
                    Movie movie = new Movie(movieTitles[i], durationMinutes, releaseYear, Genre.Action, rating);
                    _movies[i] = movie;
                    listBoxMoviesItems[i] = ($"Movie {i + 1}");
                }
                ClassiesMovieListBox.Items.AddRange(listBoxMoviesItems);
            }
        
        

        private void EnumListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = EnumListBox.SelectedIndex;
            object[] values = Enum.GetValues(typeModel[selectedIndex]).Cast<object>().ToArray();
            TextBoxValue.Text = "";
            ListBoxValue.Items.Clear();
            ListBoxValue.Items.AddRange(values);


        }

        private void ListBoxValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxValue.SelectedIndex == -1) return;
            TextBoxValue.Text = ListBoxValue.SelectedIndex.ToString();
        }

        private void ButtonParse_Click(object sender, EventArgs e)
        {
            string selectedItemName = TextBoxWeekday.Text;
            if (int.TryParse(selectedItemName, out _))
            {
                MessageBox.Show("Ошибка! Введенные данные не являются текстом");
            }
            else if (TryGetEnumValue<Weekday>(selectedItemName, out Weekday value))
            {
                LabelParse.Text = $"Это день недели ({value} = {(int)value})";
            }
            else
            {
                LabelParse.Text = $"Это не день недели";
            }
        }

        static public bool TryGetEnumValue<T>(string itemName, out T value) where T : struct
        {
            if (Enum.TryParse<T>(itemName, true, out value))
            {
                return true;
            }
            value = default;
            return false;
        }

        private void ButtonGoSeson_Click(object sender, EventArgs e)
        {
            if (ComboBoxSeason.SelectedItem == null)
            {
                ComboBoxSeason.BackColor = System.Drawing.Color.Red;
                return;
            }

            ComboBoxSeason.BackColor = System.Drawing.Color.White;
            switch (ComboBoxSeason.SelectedItem)
            {
                case Seasons.Summer:
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case Seasons.Autumn:
                    BackgroundColor(ColorTranslator.FromHtml("#e29c45"));
                    break;
                case Seasons.Winter:
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case Seasons.Spring:
                    BackgroundColor(ColorTranslator.FromHtml("#559c45"));
                    break;
            }
        }

        private void BackgroundColor(System.Drawing.Color color)
        {
            TabPageEnums.BackColor = color;
            this.BackColor = color;
        }
        private void ClassesRectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ClassesRectanglesListBox.SelectedIndex == -1) return;
            _currentRectangle = _rectangles[ClassesRectanglesListBox.SelectedIndex];
            Rectangle rectangle = (Rectangle)ClassesRectanglesListBox.SelectedItem;
            textBoxLength.Text = rectangle.Length.ToString();
            textBoxWidth.Text = rectangle.Width.ToString();
            textBoxColor.Text = rectangle.Color.ToString();
        }

        private void textBoxLength_TextChanged(object sender, EventArgs e)
        {
            int index = ClassesRectanglesListBox.Items.IndexOf(_currentRectangle);
            ClassesRectanglesListBox.Items.RemoveAt(index);
            ClassesRectanglesListBox.Items.Insert(index, _currentRectangle);
            try
            {
                textBoxLength.BackColor = System.Drawing.Color.White;
                int length = int.Parse(textBoxLength.Text);
                _currentRectangle.Length = length;
            }
            catch (Exception)
            {
                textBoxLength.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void textBoxWidth_TextChanged(object sender, EventArgs e)
        {
            int index = ClassesRectanglesListBox.Items.IndexOf(_currentRectangle);
            ClassesRectanglesListBox.Items.RemoveAt(index);
            ClassesRectanglesListBox.Items.Insert(index, _currentRectangle);
        
            try
            {
                textBoxWidth.BackColor = System.Drawing.Color.White;
                int width = int.Parse(textBoxWidth.Text);
                _currentRectangle.Width = width;
            }
            catch (Exception)
            {
                textBoxWidth.BackColor = System.Drawing.Color.LightPink;
            }
        }
        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            int MaxWidth = rectangles[0].Width;
            int MaxWidthIndex = 0;
            for (int i = 0; i < 5; i++)
            {
                if (rectangles[i].Width > MaxWidth)
                {
                    MaxWidth = rectangles[i].Width;
                    MaxWidthIndex = i;
                }
            }
            return MaxWidthIndex;

        }

        private void FindButtonRectangle_Click(object sender, EventArgs e)
        {
            int RectangleMaxWidthIndex = FindRectangleWithMaxWidth(_rectangles);
            ClassesRectanglesListBox.SelectedIndex = RectangleMaxWidthIndex;
        }

        private void ClassiesMovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ClassiesMovieListBox.SelectedIndex == -1) return;
            _currentMovie = _movies[ClassiesMovieListBox.SelectedIndex];
            textBoxName.Text = _currentMovie.Name.ToString();
            textBoxDuration.Text = _currentMovie.Duration.ToString();
            textBoxRelease.Text = _currentMovie.ReleaseYear.ToString();
            textBoxGenre.Text = _currentMovie.Genre.ToString();
            textBoxRating.Text = _currentMovie.Rating.ToString();   
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxName.BackColor = System.Drawing.Color.White;
                string Name = textBoxName.Text;
                _currentMovie.Name = Name;
            }
            catch (Exception)
            {
                textBoxName.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void textBoxDuration_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxDuration.BackColor = System.Drawing.Color.White;
                int Duration = int.Parse(textBoxDuration.Text);
                _currentMovie.Duration = Duration;
            }
            catch (Exception)
            {
                textBoxDuration.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void textBoxRelease_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxRelease.BackColor = System.Drawing.Color.White;
                int Release = int.Parse(textBoxRelease.Text);
                _currentMovie.ReleaseYear = Release;
            }
            catch (Exception)
            {
                textBoxRelease.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void textBoxGenre_TextChanged(object sender, EventArgs e)
        {
            if (_currentMovie == null) return;
            string genre = textBoxGenre.Text;
            if (TryGetEnumValue<Genre>(genre, out Genre value))
            {
                _currentMovie.Genre = value;
                textBoxGenre.BackColor = System.Drawing.Color.White;
            }
            else
            {
                textBoxGenre.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void textBoxRating_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxRating.BackColor = System.Drawing.Color.White;
                double Rating = double.Parse(textBoxRating.Text);
                _currentMovie.Rating = Rating;
            }
            catch (Exception)
            {
                textBoxRating.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void buttonFindRating_Click(object sender, EventArgs e)
        {
            double MovieMaxRateIndex = FindMovieMaxRate(_movies);
            ClassiesMovieListBox.SelectedIndex = (int)MovieMaxRateIndex;
        }
        private int FindMovieMaxRate(Movie[] _movies)
        {
            double MaxRate = _movies[0].Rating;
            int MaxRateIndex = 0;
            for (int i = 0; i < 5; i++)
            {
                if (_movies[i].Rating > MaxRate)
                {
                    MaxRate = _movies[i].Rating;
                    MaxRateIndex = i;
                }
            }
            return MaxRateIndex;

        }
    }
}
