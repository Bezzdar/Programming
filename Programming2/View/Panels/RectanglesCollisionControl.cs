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
    public partial class RectanglesCollisionControl : UserControl
    {
        bool _isProgrammaticChange = false;
        List<Rectangle> _intersecting = new List<Rectangle>();
        Rectangle _currentRectangle;
        List<Panel> _rectanglePanels;
        List<Rectangle> _rectangles;

        public RectanglesCollisionControl()
        {
            InitializeComponent();
            CustomMethods.TextBoxRectangles = new TextBox[5] {  TextBoxID,
                                                                    TextBoxRectanglesWidth,
                                                                    TextBoxHeight,
                                                                    TextBoxX,
                                                                    TextBoxY };
            _rectangles = new List<Rectangle>();
            _rectanglePanels = new List<Panel>();
        }

        private void TextBoxDisable(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        void TextBoxRectanglesX_TextChanged(object sender, EventArgs e)
        {
            TextBoxSizeCoordinatesChange(TextBoxX, "x");
        }
        void TextBoxRectanglesY_TextChanged(object sender, EventArgs e)
        {
            TextBoxSizeCoordinatesChange(TextBoxY, "y");
        }
        void TextBoxRectanglesWidth_TextChanged(object sender, EventArgs e)
        {
            TextBoxSizeRectangleChange(TextBoxRectanglesWidth, "width");
        }
        void TextBoxRectanglesHeight_TextChanged(object sender, EventArgs e)
        {
            TextBoxSizeRectangleChange(TextBoxHeight, "length");
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

        /// <summary>
        /// Resizing a rectangle
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="dimensionType">"width" or "length"</param>
        void TextBoxSizeRectangleChange(TextBox textBox, string dimensionType)
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
        void TextBoxSizeCoordinatesChange(TextBox textBox, string coordinateType)
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
    }
}
