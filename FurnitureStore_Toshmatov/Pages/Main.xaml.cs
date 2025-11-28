using System.Windows;
using System.Windows.Controls;
using System.Linq;

namespace FurnitureStore_Toshmatov.Pages
{
    public partial class Main : Page
    {
        public System.Collections.Generic.List<Classes.Item> items = new System.Collections.Generic.List<Classes.Item>();

        public Main()
        {
            InitializeComponent();

            items.Add(new Classes.Item("Шкаф классический", 20000, "background.jpg"));
            items.Add(new Classes.Item("Шкаф современный", 30000, "шкаф 1.png"));
            items.Add(new Classes.Item("Шкаф угловой", 35000, "шкаф 2.png"));
            items.Add(new Classes.Item("Шкаф распашной", 15000, "шкаф 3.png"));
            items.Add(new Classes.Item("Шкаф купе", 5000, "шкаф 4.png"));
            items.Add(new Classes.Item("Шкаф гардеробный", 40000, "шкаф 5.png"));

            LoadItems();
            UpdateCartCounter();
        }

        private void OpenCart_Click(object sender, RoutedEventArgs e)
        {
            if (MainWindow.Instance != null)
            {
                MainWindow.Instance.OpenCart();
            }
        }

        public void UpdateCartCounter()
        {
            if (MainWindow.Instance != null && MainWindow.Instance.Cart != null)
            {
                int totalItems = MainWindow.Instance.Cart.Sum(item => item.Quantity);
                btnCart.Content = $"Корзина ({totalItems})"; 
            }
        }

        public void LoadItems()
        {
            parent.Children.Clear();

            foreach (Classes.Item item in items)
            {
                parent.Children.Add(new Elements.Item(item));
            }
        }
    }
}