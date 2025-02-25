using System.ComponentModel;
using System.Runtime.CompilerServices;
using View.Model;

namespace View.ViewModel
{
    /// <summary>
    /// Представляет модель представления (ViewModel) для управления контактными данными.
    /// </summary>
    public class MainVM : INotifyPropertyChanged
    {
        private Contact _contact;

        /// <summary>
        /// Инициализирует новый экземпляр класса MainVM.
        /// </summary>
        public MainVM()
        {
            _contact = new Contact(string.Empty, string.Empty, string.Empty);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Вызывает событие PropertyChanged при изменении свойства.
        /// </summary>
        /// <param name="propertyName">Имя измененного свойства.</param>
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string Name
        {
            get => _contact.Name;
            set
            {
                if (_contact.Name != value)
                {
                    _contact.Name = value;
                    OnPropertyChanged();
                }
            }
        }

        public string PhoneNumber
        {
            get => _contact.PhoneNumber;
            set
            {
                if (_contact.PhoneNumber != value)
                {
                    _contact.PhoneNumber = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Email
        {
            get => _contact.Email;
            set
            {
                if (_contact.Email != value)
                {
                    _contact.Email = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}


