using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model
{
    class Contact
    {
        public string Name { get; set; } = string.Empty;
        private string phoneNumber = string.Empty;
        private string email = string.Empty;


        public string PhoneNumber
        {
            get => phoneNumber;
            set
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(value, @"^\+?[1-9]\d{1,14}$"))
                {
                    throw new ArgumentException("Invalid phone number format.");
                }
                phoneNumber = value;
            }
        }

        public string Email
        {
            get => email;
            set
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(value);
                    email = addr.Address;
                }
                catch
                {
                    throw new ArgumentException("Invalid email format.");
                }
            }
        }

        public Contact(string name, string phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}
