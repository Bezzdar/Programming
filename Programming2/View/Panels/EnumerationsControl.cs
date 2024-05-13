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
    public partial class EnumerationsControl : UserControl
    {
        Type[] typeModel = new Type[6] { typeof(Colors), typeof(FormOfEducation), typeof(Genre), typeof(Manufacturers), typeof(Seasons), typeof(Weekday) };

        public EnumerationsControl()
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
    }
}
