using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectProgramming.View.Panels
{

    /// <summary>
    /// Представляет элемент управления для выбора сезона.
    /// </summary>
    public partial class SeasonHandleControl : UserControl
    {

        /// <summary>
        /// Событие, возникающее при изменении сезона.
        /// </summary>
        public event EventHandler<SeasonChangedEventArgs> SeasonChanged;

        /// <summary>
        /// Инициализирует новый экземпляр класса SeasonHandleControl.
        /// </summary>
        public SeasonHandleControl()
        {
            InitializeComponent();

            object[] values = Enum.GetValues(typeof(Seasons)).Cast<object>().ToArray();
            ComboBoxSeason.Items.AddRange(values);
        }

        /// <summary>
        /// Обработчик нажатия кнопки для выбора сезона.
        /// </summary>
        private void SeasonButton_Click(object sender, EventArgs e)
        {
            if (ComboBoxSeason.SelectedItem == null)
            {
                MessageBox.Show("Значение не выбрано!");
            }
            ComboBoxSeason.BackColor = System.Drawing.Color.White;
            switch (ComboBoxSeason.SelectedItem)
            {
                case Seasons.Summer:
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case Seasons.Autumn:
                    SeasonChanged.Invoke(this, new SeasonChangedEventArgs(Seasons.Autumn));
                    break;
                case Seasons.Winter:
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case Seasons.Spring:
                    SeasonChanged.Invoke(this, new SeasonChangedEventArgs(Seasons.Spring));
                    break;
            }
        }
    }

    /// <summary>
    /// Представляет аргументы события изменения сезона.
    /// </summary>
    public class SeasonChangedEventArgs : EventArgs
    {
        public Seasons Season { get; }

        public SeasonChangedEventArgs(Seasons season)
        {
            Season = season;
        }
    }
}
