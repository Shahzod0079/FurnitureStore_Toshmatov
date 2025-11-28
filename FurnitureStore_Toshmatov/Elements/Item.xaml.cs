using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace FurnitureStore_Toshmatov.Elements
{
    public partial class Item : UserControl
    {
        private int count = 0;
        private Classes.Item currentItem;

        public Item(Classes.Item item)
        {
            InitializeComponent();
            currentItem = item;

            if (item != null)
            {
                try
                {
                    string imageUri = $"/Pages/{item.ImageSrc}";
                    image.Source = new BitmapImage(new Uri(imageUri, UriKind.Relative));
                }
                catch
                {
                    try
                    {
                        image.Source = new BitmapImage(new Uri("/Pages/i (1).png", UriKind.Relative));
                    }
                    catch
                    {
                    }
                }

                price.Content = item.Price.ToString("C0");
                name.Content = item.Name;
            }

            UpdateCounter();
        }

        private void IncreaseCount(object sender, RoutedEventArgs e)
        {
            count++;
            UpdateCounter();
        }

        private void DecreaseCount(object sender, RoutedEventArgs e)
        {
            if (count > 0)
            {
                count--;
                UpdateCounter();
            }
        }

        private void UpdateCounter()
        {
            counterText.Text = count.ToString();
        }

        private void AddToCart(object sender, RoutedEventArgs e)
        {
            if (count > 0 && currentItem != null)
            {
                MainWindow.Instance.AddToCart(currentItem, count);
                count = 0;
                UpdateCounter();

                // ОБНОВЛЯЕМ СЧЕТЧИК НА ГЛАВНОЙ СТРАНИЦЕ
                MainWindow.Instance.UpdateCartCounter();
            }
            else
            {
                MessageBox.Show("Укажите количество товара");
            }
        }
    }
}