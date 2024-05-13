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

    /// <summary>
    /// Представляет элемент управления для разбора дня недели.
    /// </summary>
    public partial class WeekdayParsingControl : UserControl
    {

        /// <summary>
        /// Инициализирует новый экземпляр класса WeekdayParsingControl.
        /// </summary>
        public WeekdayParsingControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик нажатия кнопки для разбора дня недели.
        /// </summary>
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

        /// <summary>
        /// Пытается получить значение перечисления по его имени.
        /// </summary>
        /// <typeparam name="T">Тип перечисления.</typeparam>
        /// <param name="itemName">Имя элемента перечисления.</param>
        /// <param name="value">Возвращаемое значение.</param>
        /// <returns>True, если значение успешно получено, иначе false.</returns>
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
