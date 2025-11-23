using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FurnitureStore_Toshmatov.Pages
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public List<Item> items = new List<Item>();

        public Main()
        {
            InitializeComponent();

            items.Add(new Item("Шкаф", 20000, "background.jpg"));

            LoadItems();
        }

        /// <summary>
        /// Загрузка вещей
        /// </summary>
        public void LoadItems()
        {
            parent.Children.Clear();

            foreach (Item item in items)
            {
                parent.Children.Add(new Elements.Item(item));
            }
        }
    }

    /// <summary>
    /// Класс Item должен быть определен
    /// </summary>
    public class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImagePath { get; set; }

        public Item(string name, decimal price, string imagePath)
        {
            Name = name;
            Price = price;
            ImagePath = imagePath;
        }
    }
}