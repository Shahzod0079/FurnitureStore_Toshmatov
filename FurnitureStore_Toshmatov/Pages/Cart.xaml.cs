using System.Windows;
using System.Windows.Controls;
using System.Linq;

namespace FurnitureStore_Toshmatov.Pages
{
    public partial class Cart : Page
    {
        public Cart()
        {
            InitializeComponent();
            LoadCart();
        }

        private void LoadCart()
        {
            lvCart.Items.Clear();

            foreach (var cartItem in MainWindow.Instance.Cart)
            {
                lvCart.Items.Add(cartItem);
            }

            CalculateTotal();
        }

        private void CalculateTotal()
        {
            int total = MainWindow.Instance.Cart.Sum(item => item.TotalPrice);
            lblTotal.Content = $"Итого: {total:C0}";
        }
        private void Checkout_Click(object sender, RoutedEventArgs e)
        {
            if (MainWindow.Instance.Cart.Count > 0)
            {
                int total = MainWindow.Instance.Cart.Sum(item => item.TotalPrice);
                MessageBox.Show($"Заказ оформлен!\nОбщая стоимость: {total:C0}\nСпасибо за покупку!", "Заказ оформлен");
                MainWindow.Instance.Cart.Clear();
                LoadCart();
            }
            else
            {
                MessageBox.Show("Корзина пуста!", "Внимание");
            }
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.OpenPage(new Main());
        }
    }
}
 