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
        // ИЗМЕНИТЕ: List<Item> на List<Classes.Item>
        public List<Classes.Item> items = new List<Classes.Item>();

        public Main()
        {
            InitializeComponent();

            // ИЗМЕНИТЕ: new Item() на new Classes.Item()
            items.Add(new Classes.Item("Шкаф", 20000, "background.jpg"));

            LoadItems();
        }

        /// <summary>
        /// Загрузка вещей
        /// </summary>
        public void LoadItems()
        {
            parent.Children.Clear();

            // ИЗМЕНИТЕ: Item на Classes.Item
            foreach (Classes.Item item in items)
            {
                parent.Children.Add(new Elements.Item(item));
            }
        }
    }
}