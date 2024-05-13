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
    public partial class WeekdayParsingControl : UserControl
    {
        public WeekdayParsingControl()
        {
            InitializeComponent();
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
    }
}
