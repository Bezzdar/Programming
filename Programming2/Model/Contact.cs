using System;
using System.Drawing;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

class Contact
{
    string _name;
    string _email;
    string _phoneNumber;
    string _adress;


    public string Name
    {
        get { return _name; }
        set
        {
            if (value.Length < 0)
            {
                throw new ArgumentException("Name is empty");
            }
            _name = value;
        }
    }
    public string Email
    {
        get { return _email; }
        set
        {
            if (!string.IsNullOrWhiteSpace(_email) && _email.Contains("@"))
                throw new ArgumentException("Invalid email format!");
            _email = value;
        }
    }

    public string PhoneNumber
    {
        get { return _phoneNumber; }
        set
        {
            if (!IsValidPhoneNumber(value))
            {
                throw new ArgumentException("Invalid phone number format.");
            }
            _phoneNumber = value;
        }
    }
        private bool IsValidPhoneNumber(string phoneNumber)
        {
        // Шаблон регулярного выражения для проверки телефонного номера
        string pattern = @"^\+(?:[0-9] ?){6,14}[0-9]$";

        // Проверка соответствия телефонного номера шаблону
        return Regex.IsMatch(phoneNumber, pattern);
        }


    public string Adress { get; set; }


    public Contact()
    {
        Name = "Глеб";
        Email = "glebkatrenko67@gmail.com";
        PhoneNumber = "+79234103553";
        Adress = "Krasnoyarsk";
    }

    public Contact(string name, string email, string phonenumber, string adress)
    {
       Name=name;   
       Email=email;
       PhoneNumber=phonenumber;
       Adress=adress;

    }
}