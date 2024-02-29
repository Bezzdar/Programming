using System;

namespace ProjectProgramming2.Model
{
    public class Contact
    {
        private string _name;
        private string _phoneNumber;
        private string _email;

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Name cannot be null or empty.");
                _name = value;
            }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Phone number cannot be null or empty.");
                _phoneNumber = value;
            }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }


        public Contact(string name, string phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}
