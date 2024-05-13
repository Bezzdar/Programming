using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Programming2
{
    /// <summary>
    /// Главная форма приложения.
    /// </summary>
    public partial class MainForm : Form
    {

            /// <summary>
            /// Инициализирует новый экземпляр класса MainForm.
            /// </summary>
            public MainForm()
            {
                InitializeComponent();
            }

            /// <summary>
            /// Устанавливает цвет фона элементов управления и формы.
            /// </summary>
            /// <param name="color">Цвет фона.</param>
            private void SetBackColor(System.Drawing.Color color)
            {
                EnumBox.BackColor = color;
                WeekdayBox.BackColor = color;
                SeasonBox.BackColor = color;
                this.BackColor = color;
            }

            /// <summary>
            /// Обработчик события изменения времени года.
            /// </summary>
            /// <param name="sender">Источник события.</param>
            /// <param name="e">Аргументы события.</param>
            private void seasonHandleControl1_SeasonChanged(object sender, ProjectProgramming.View.Panels.SeasonChangedEventArgs e)
            {
                SetBackColor(e.Season == Seasons.Autumn ? AppColors.Autumn : AppColors.Spring);
            }
    }
}
