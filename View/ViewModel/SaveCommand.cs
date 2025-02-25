
using System.IO;
using System.Windows.Input;
using View.Model;

namespace View.ViewModel
{
    /// <summary>
    /// Команда для сохранения данных контакта в файл.
    /// </summary>
    public class SaveCommand : ICommand
    {
        /// <summary>
        /// Событие, которое вызывается при изменении состояния выполнения команды.
        /// </summary>
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Определяет, может ли команда выполняться.
        /// </summary>
        /// <param name="parameter">Параметр команды (контакт).</param>
        /// <returns>Всегда возвращает true.</returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// Выполняет команду сохранения данных контакта в файл.
        /// </summary>
        /// <param name="parameter">Контакт, данные которого сохраняются.</param>
        public void Execute(object parameter)
        {
            if (parameter is Contact contact)
            {
                string filePath = "contact_save.txt";
                try
                {
                    File.WriteAllText(filePath, $"{contact.Name}\n{contact.PhoneNumber}\n{contact.Email}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка сохранения: {ex.Message}");
                }
            }
        }
    }
}

