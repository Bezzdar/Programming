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


            public MainForm()
            {
                InitializeComponent();
            }


            private void SetBackColor(System.Drawing.Color color)
            {
                EnumBox.BackColor = color;
                WeekdayBox.BackColor = color;
                SeasonBox.BackColor = color;
                this.BackColor = color;
            }

            private void seasonHandleControl1_SeasonChanged(object sender, ProjectProgramming.View.Panels.SeasonChangedEventArgs e)
            {
                SetBackColor(e.Season == Seasons.Autumn ? AppColors.Autumn : AppColors.Spring);
            }
    }
}
