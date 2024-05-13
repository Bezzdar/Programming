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
    

    public partial class RectanglesClassesControl : UserControl
    {

        public RectanglesClassesControl()
        {
            InitializeComponent();

        }

    //    private void ClassesRectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
    //    {
    //        if (ClassesRectanglesListBox.SelectedIndex == -1) return;
    //        _currentRectangle = _rectangles[ClassesRectanglesListBox.SelectedIndex];
    //        Rectangle rectangle = (Rectangle)ClassesRectanglesListBox.SelectedItem;
    //        LengthTextBox.Text = rectangle.Height.ToString();
    //        WidthTextBox.Text = rectangle.Width.ToString();
    //        ColorTextBoxColor.Text = rectangle.Color.ToString();
    //        MidXTextBox.Text = rectangle.Center.X.ToString();
    //        MidYTextBox.Text = rectangle.Center.Y.ToString();
    //        IdTextBox.Text = rectangle.Id.ToString();
    //    }

    //    private void textBoxLength_TextChanged(object sender, EventArgs e)
    //    {
    //        int index = ClassesRectanglesListBox.Items.IndexOf(_currentRectangle);
    //        ClassesRectanglesListBox.Items.RemoveAt(index);
    //        ClassesRectanglesListBox.Items.Insert(index, _currentRectangle);
    //        try
    //        {
    //            LengthTextBox.BackColor = System.Drawing.Color.White;
    //            int length = int.Parse(LengthTextBox.Text);
    //            _currentRectangle.Height = length;
    //        }
    //        catch (Exception)
    //        {
    //            LengthTextBox.BackColor = System.Drawing.Color.LightPink;
    //        }
    //    }

    //    private void textBoxWidth_TextChanged(object sender, EventArgs e)
    //    {
    //        int index = ClassesRectanglesListBox.Items.IndexOf(_currentRectangle);
    //        ClassesRectanglesListBox.Items.RemoveAt(index);
    //        ClassesRectanglesListBox.Items.Insert(index, _currentRectangle);

    //        try
    //        {
    //            WidthTextBox.BackColor = System.Drawing.Color.White;
    //            int width = int.Parse(WidthTextBox.Text);
    //            _currentRectangle.Width = width;
    //        }
    //        catch (Exception)
    //        {
    //            WidthTextBox.BackColor = System.Drawing.Color.LightPink;
    //        }
    //    }
    //    private int FindRectangleWithMaxWidth(List<Rectangle> rectangles)
    //    {
    //        int MaxWidth = rectangles[0].Width;
    //        int MaxWidthIndex = 0;
    //        for (int i = 0; i < 5; i++)
    //        {
    //            if (rectangles[i].Width > MaxWidth)
    //            {
    //                MaxWidth = rectangles[i].Width;
    //                MaxWidthIndex = i;
    //            }
    //        }
    //        return MaxWidthIndex;

    //    }

    //    private void FindButtonRectangle_Click(object sender, EventArgs e)
    //    {
    //        int RectangleMaxWidthIndex = FindRectangleWithMaxWidth(_rectangles);
    //        ClassesRectanglesListBox.SelectedIndex = RectangleMaxWidthIndex;
    //    }

    //    private void TextBoxDisable(object sender, KeyPressEventArgs e)
    //    {
    //        e.Handled = true;
    //    }
    }
}
