using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace solution
{
    public partial class Form1 : Form
    {
        private BindingList<Song> products;
        public Form1()
        {
            InitializeComponent();
            products = new BindingList<Song>();
            SongListBox.DataSource = products;
            GenreComboBox.DataSource = Enum.GetValues(typeof(Genre));
        }

        //private void DisplaySongList()
        //{
        //    SongListBox.Items.Clear();
        //    foreach (Song song in products)
        //    {
        //        SongListBox.Items.Add($"{song.Singer} - {song.Name}");
        //    }
        //}

        private void EditButton_click(object sender, EventArgs e)
        {
            if (SongListBox.SelectedItem != null && ValidateInputs())
            {
                Song selectedProduct = (Song)SongListBox.SelectedItem;
                selectedProduct.Name = NameBox.Text;
                selectedProduct.Singer = SingerBox.Text;
                selectedProduct.Genre = (Genre)GenreComboBox.SelectedItem;
                selectedProduct.Duration = (int)TimeUpDown.Value;
                SortProducts();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                Song newProduct = new Song
                {
                    Name = NameBox.Text,
                    Singer = SingerBox.Text,
                    Genre = (Genre)GenreComboBox.SelectedItem,
                    Duration = (int)TimeUpDown.Value
                };
                products.Add(newProduct);
                SortProducts();
                ClearInputs();
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (SongListBox.SelectedItem != null)
            {
                products.Remove((Song)SongListBox.SelectedItem);
            }
        }

        private void SongListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SongListBox.SelectedItem != null)
            {
                Song selectedProduct = (Song)SongListBox.SelectedItem;
                NameBox.Text = selectedProduct.Name;
                SingerBox.Text = selectedProduct.Singer;
                GenreComboBox.SelectedItem = selectedProduct.Genre;
                TimeUpDown.Value = selectedProduct.Duration;
            }
        }

        private void SortProducts()
        {
            var sorted = products.OrderBy(p => p.Singer).
                ThenBy(p => p.Name).
                ToList();
            products.Clear();
            foreach (var product in sorted)
            {
                products.Add(product);
            }
        }

        private bool ValidateInputs()
        {
            bool isValid = true;
            errorProvider.Clear();

            if (!Validator.ValidateName(NameBox.Text, out string nameError))
            {
                errorProvider.SetError(NameBox, nameError);
                isValid = false;
            }

            if (!Validator.ValidateSinger(SingerBox.Text, out string manufacturerError))
            {
                errorProvider.SetError(SingerBox, manufacturerError);
                isValid = false;
            }

            return isValid;
        }

        private void ClearInputs()
        {
            NameBox.Clear();
            SingerBox.Clear();
            GenreComboBox.SelectedIndex = 0;
            TimeUpDown.Value = 0;
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveProductsToFile();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadProductsFromFile();
        }



        private void SaveProductsToFile()
        {
            var json = JsonSerializer.Serialize(products.ToList());
            File.WriteAllText("products.json", json);
        }

        private void LoadProductsFromFile()
        {
            if (File.Exists("products.json"))
            {
                var json = File.ReadAllText("products.json");
                var loadedProducts = JsonSerializer.Deserialize<List<Song>>(json);
                foreach (var product in loadedProducts)
                {
                    products.Add(product);
                }
            }
        }
    }
}

