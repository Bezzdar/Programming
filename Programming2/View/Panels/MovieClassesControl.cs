using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming2.View.Panels
{

    /// <summary>
    /// Представляет элемент управления для работы с фильмами.
    /// </summary>
    public partial class MovieClassesControl : UserControl
    {
        Movie[] _movies = new Movie[5];
        Movie _currentMovie = new Movie();

        /// <summary>
        /// Инициализирует новый экземпляр класса MovieClassesControl.
        /// </summary>
        public MovieClassesControl()
        {
            InitializeComponent();

            Random random = new Random();


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

        /// <summary>
        /// Обработчик события изменения выбранного элемента в списке фильмов.
        /// </summary>
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

        /// <summary>
        /// Находит индекс фильма с максимальным рейтингом.
        /// </summary>
        /// <param name="_movies">Массив фильмов.</param>
        /// <returns>Индекс фильма с максимальным рейтингом.</returns>
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

        /// <summary>
        /// Обработчик события ввода текста в текстовое поле.
        /// Запрещает ввод текста.
        /// </summary>
        private void TextBoxDisable(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Пытается получить значение перечисления по строковому представлению.
        /// </summary>
        /// <typeparam name="T">Тип перечисления.</typeparam>
        /// <param name="itemName">Строковое представление элемента перечисления.</param>
        /// <param name="value">Значение элемента перечисления.</param>
        /// <returns>Значение true, если удалось получить значение перечисления, иначе - false.</returns>
        static public bool TryGetEnumValue<T>(string itemName, out T value) where T : struct
        {
            if (Enum.TryParse<T>(itemName, true, out value))
            {
                return true;
            }
            value = default;
            return false;
        }


    }
}
