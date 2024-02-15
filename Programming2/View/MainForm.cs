using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming2
{
    public partial class MainForm : Form
    {
        Type[] typeModel = new Type[6] { typeof(Colors), typeof(FormOfEducation), typeof(Genre), typeof(Manufacturers), typeof(Seasons), typeof(Weekday) };

        public MainForm()
        {
            InitializeComponent();
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
    }
}
