using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Programming2
{
    public partial class MainForm : Form
    {
        bool _isProgrammaticChange = false;
        List<Rectangle> _intersecting = new List<Rectangle>();
        Rectangle _currentRectangle;
        List<Panel> _rectanglePanels;
        List<Rectangle> _rectangles;
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
                //for (int i  = 0; i<5; i++)
                //{
                //    _rectangles[i] = new Rectangle(random.Next(6, 51), random.Next(3, 50), Colors.Green);
                //}
                //ClassesRectanglesListBox.Items.AddRange(_rectangles);
                //for (int i = 0; i < 5; i++)
                //{
                //    _rectangles.Add(new Rectangle(random.Next(6, 51), random.Next(3, 50), Colors.White, new Point2D(random.Next(3, 50), random.Next(3, 50))));
                //}
                //RectanglesListBox.Items.AddRange(_rectangles.ToArray());

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

                CustomMethods.TextBoxRectangles = new TextBox[5] {  TextBoxID,
                                                                    TextBoxRectanglesWidth,
                                                                    TextBoxHeight,
                                                                    TextBoxX,
                                                                    TextBoxY };
                _rectangles = new List<Rectangle>();
                _rectanglePanels = new List<Panel>();
            }

            void TextBoxRectanglesX_TextChanged(object sender, EventArgs e)
            {
                TextBoxCoordinatesHandler(TextBoxX, "x");
            }
            void TextBoxRectanglesY_TextChanged(object sender, EventArgs e)
            {
                TextBoxCoordinatesHandler(TextBoxY, "y");
            }
            void TextBoxRectanglesWidth_TextChanged(object sender, EventArgs e)
            {
                TextBoxSizeRectangleHandler(TextBoxRectanglesWidth, "width");
            }
            void TextBoxRectanglesHeight_TextChanged(object sender, EventArgs e)
            {
                TextBoxSizeRectangleHandler(TextBoxHeight, "length");
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
            LengthTextBox.Text = rectangle.Height.ToString();
            WidthTextBox.Text = rectangle.Width.ToString();
            ColorTextBoxColor.Text = rectangle.Color.ToString();
            MidXTextBox.Text = rectangle.Center.X.ToString();
            MidYTextBox.Text = rectangle.Center.Y.ToString();
            IdTextBox.Text = rectangle.Id.ToString();
        }

        private void textBoxLength_TextChanged(object sender, EventArgs e)
        {
            int index = ClassesRectanglesListBox.Items.IndexOf(_currentRectangle);
            ClassesRectanglesListBox.Items.RemoveAt(index);
            ClassesRectanglesListBox.Items.Insert(index, _currentRectangle);
            try
            {
                LengthTextBox.BackColor = System.Drawing.Color.White;
                int length = int.Parse(LengthTextBox.Text);
                _currentRectangle.Height = length;
            }
            catch (Exception)
            {
                LengthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void textBoxWidth_TextChanged(object sender, EventArgs e)
        {
            int index = ClassesRectanglesListBox.Items.IndexOf(_currentRectangle);
            ClassesRectanglesListBox.Items.RemoveAt(index);
            ClassesRectanglesListBox.Items.Insert(index, _currentRectangle);
        
            try
            {
                WidthTextBox.BackColor = System.Drawing.Color.White;
                int width = int.Parse(WidthTextBox.Text);
                _currentRectangle.Width = width;
            }
            catch (Exception)
            {
                WidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }
        private int FindRectangleWithMaxWidth(List<Rectangle> rectangles)
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

        private void TextBoxDisable(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (RectanglesListBox.SelectedIndex == -1) return;
            //_currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];
            //Rectangle rectangle = (Rectangle)RectanglesListBox.SelectedItem;
            //TextBoxHeight.Text = rectangle.Height.ToString();
            //TextBoxRectanglesWidth.Text = rectangle.Width.ToString();
            //TextBoxX.Text = rectangle.Center.X.ToString();
            //TextBoxY.Text = rectangle.Center.Y.ToString();
            //TextBoxID.Text = rectangle.Id.ToString();
            if (RectanglesListBox.SelectedItem == null) return;
            _currentRectangle = (Rectangle)RectanglesListBox.SelectedItem;
            UpdateRectangleInfo(_currentRectangle, RectanglesListBox.SelectedIndex);
        }
        private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            Rectangle rectangle = RectangleFactory.Randomize(RectanglesPanel, 150, 150);
            _rectangles.Add(rectangle);
            RectanglesListBox.Items.Add(rectangle);
            Panel panel = InitialPanel(rectangle);
            panel.BackColor = AppColors.Success;
            _rectanglePanels.Add(panel);
            RectanglesPanel.Controls.Add(panel);
            FindCollisions(rectangle);
        }

        private void DeleteRectangleButton_Click(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedItem == null && RectanglesListBox.SelectedIndex == -1) return;
            Rectangle rectangle = (Rectangle)RectanglesListBox.SelectedItem;
            int selectedIndex = RectanglesListBox.SelectedIndex;
            _rectangles.Remove(rectangle);
            RectanglesListBox.Items.Remove(rectangle);
            ClearRectangleInfo();
            _rectanglePanels.RemoveAt(selectedIndex);
            RectanglesPanel.Controls.RemoveAt(selectedIndex);
            FindCollisions(rectangle);
        }

        /// <summary>
        /// Resizing a rectangle
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="dimensionType">"width" or "length"</param>
        void TextBoxSizeRectangleHandler(TextBox textBox, string dimensionType)
        {
            if (_currentRectangle == null || _isProgrammaticChange) return;
            try
            {
                int value = int.Parse(textBox.Text);
                switch (dimensionType)
                {
                    case "width":
                        _currentRectangle.Width = value;
                        break;
                    case "length":
                        _currentRectangle.Height = value;
                        break;
                    default: throw new ArgumentException("Non-existent argument value.");
                }
                ListBoxSelectedRectangleUpdate();

                textBox.BackColor = AppColors.Default;
            }
            catch (Exception)
            {
                textBox.BackColor = AppColors.Invalid;
            }
        }
        /// <summary>
        /// Moving a rectangle
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="coordinateType">"x" or "y"</param>
        void TextBoxCoordinatesHandler(TextBox textBox, string coordinateType)
        {
            if (_currentRectangle == null || _isProgrammaticChange) return;
            try
            {
                int coordinate = int.Parse(textBox.Text);
                switch (coordinateType)
                {
                    case "x":
                        _currentRectangle.Coordinates = new Point2D(coordinate, _currentRectangle.Coordinates.Y);
                        break;
                    case "y":
                        _currentRectangle.Coordinates = new Point2D(_currentRectangle.Coordinates.X, coordinate);
                        break;
                    default: throw new ArgumentException("Non-existent argument value.");
                }
                ListBoxSelectedRectangleUpdate();
                textBox.BackColor = AppColors.Default;
            }
            catch (Exception)
            {
                textBox.BackColor = AppColors.Invalid;
            }
        }
        void ListBoxSelectedRectangleUpdate()
        {
            int indexRectangles = RectanglesListBox.Items.IndexOf(_currentRectangle);
            RectanglesListBox.Items.RemoveAt(indexRectangles);
            RectanglesListBox.Items.Insert(indexRectangles, _currentRectangle);
            RectanglesListBox.SelectedIndex = indexRectangles;
            Panel panel = InitialPanel(_currentRectangle);
            panel.BackColor = AppColors.Success;
            _rectanglePanels[indexRectangles] = panel;
            RectanglesPanel.Controls.Clear();
            RectanglesPanel.Controls.AddRange(_rectanglePanels.ToArray());
            FindCollisions(_currentRectangle);
        }

        void FindCollisions(Rectangle rectangle)
        {
            // Создаём копию списка, чтобы из-за изменения во время выполнения цикла, не появлялась ошибка
            List<Rectangle> intersecting = new List<Rectangle>(_intersecting);
            // Перебираем ранее пересекающиеся прямоугольники со всеми прямоугольниками,
            // если он ни с чем не пересекается, делаем его зелёным
            foreach (Rectangle e in intersecting)
            {
                if (RectanglesListBox.Items.IndexOf(e) == -1) continue;
                bool isRemove = true;
                foreach (Rectangle r in _rectangles)
                {
                    if (e != r && CollisionManager.IsCollision(e, r))
                    {
                        isRemove = false;
                        break;
                    }
                }
                if (isRemove)
                {
                    _intersecting.Remove(e);
                    _rectanglePanels[RectanglesListBox.Items.IndexOf(e)].BackColor = AppColors.Success;
                }
            }
            // Удаляем из списка пересекающих изменённый прямоугольник
            if (_intersecting.Contains(rectangle)) _intersecting.Remove(rectangle);
            // Если прямоугольник был удалён, завершаем выполнение метода
            if (!_rectangles.Contains(rectangle)) return;

            bool flag = false;
            foreach (Rectangle r in _rectangles)
            {
                if (rectangle != r && CollisionManager.IsCollision(rectangle, r))
                {
                    if (!_intersecting.Contains(r)) _intersecting.Add(r);
                    _rectanglePanels[RectanglesListBox.Items.IndexOf(r)].BackColor = AppColors.Danger;
                    flag = true;
                }
            }
            if (flag)
            {
                _intersecting.Add(rectangle);
                _rectanglePanels[RectanglesListBox.Items.IndexOf(rectangle)].BackColor = AppColors.Danger;
            }
        }

        void UpdateRectangleInfo(Rectangle rectangle, int selectedIndex)
        {
            _isProgrammaticChange = true;
            TextBoxID.Text = rectangle.Id.ToString();
            TextBoxX.Text = rectangle.Coordinates.X.ToString();
            TextBoxY.Text = rectangle.Coordinates.Y.ToString();
            TextBoxRectanglesWidth.Text = rectangle.Width.ToString();
            TextBoxHeight.Text = rectangle.Height.ToString();
            RectanglesListBox.SelectedIndex = selectedIndex;
            _isProgrammaticChange = false;
        }

        Panel InitialPanel(Rectangle rectangle)
        {
            Panel panel = new Panel();
            panel.Location = new Point((int)rectangle.Coordinates.X, (int)rectangle.Coordinates.Y);
            panel.Width = rectangle.Width;
            panel.Height = rectangle.Height;
            return panel;
        }

        void ClearRectangleInfo()
        {
            foreach (TextBox tb in CustomMethods.TextBoxRectangles)
            {
                tb.Clear();
                tb.BackColor = AppColors.Default;
            }
        }

        private void TextBoxHeight_TextChanged(object sender, EventArgs e)
        {

        }

        //private void TextBoxRectanglesWidth_TextChanged(object sender, EventArgs e)
        //{
        //    int index = RectanglesListBox.Items.IndexOf(_currentRectangle);
        //    RectanglesListBox.Items.RemoveAt(index);
        //    RectanglesListBox.Items.Insert(index, _currentRectangle);

        //    try
        //    {
        //        WidthTextBox.BackColor = System.Drawing.Color.White;
        //        int width = int.Parse(TextBoxRectanglesWidth.Text);
        //        _currentRectangle.Width = width;
        //    }
        //    catch (Exception)
        //    {
        //        TextBoxRectanglesWidth.BackColor = System.Drawing.Color.LightPink;
        //    }
        //}
    }
}
