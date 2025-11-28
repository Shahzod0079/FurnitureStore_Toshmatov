using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Linq;
using FurnitureStore_Toshmatov.Classes;

namespace FurnitureStore_Toshmatov
{
    public partial class MainWindow : Window
    {
        public static MainWindow Instance;
        public List<CartItem> Cart = new List<CartItem>();

        public MainWindow()
        {
            InitializeComponent();
            Instance = this;

            OpenPage(new Pages.Main());
        }

        public void OpenPage(Page page)
        {
            frame.Navigate(page);
        }

        public void AddToCart(Item item, int quantity)
        {
            if (Cart == null) Cart = new List<CartItem>();

            var existingItem = Cart.FirstOrDefault(ci => ci.Product.Name == item.Name);

            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                Cart.Add(new CartItem(item, quantity));
            }

            MessageBox.Show($"Добавлено в корзину: {item.Name} x {quantity} шт.");
            UpdateCartCounter();
        }
        public void OpenCart()
        {
            OpenPage(new Pages.Cart());
        }

        public void UpdateCartCounter()
        {
            if (frame.Content is Pages.Main mainPage)
            {
                mainPage.UpdateCartCounter();
            }
        }
    }
}