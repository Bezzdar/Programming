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
            // 
            // Initialize ComboBoxSeasons
            // 
            object[] values = Enum.GetValues(typeof(Seasons)).Cast<object>().ToArray();
            ComboBoxSeason.Items.AddRange(values);
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
            EnumBox.BackColor = color;
            WeekdayBox.BackColor = color;
            SeasonBox.BackColor = color;
            this.BackColor = color;
        }
    }
}
