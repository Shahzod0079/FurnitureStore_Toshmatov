using System;
using System.IO;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace FurnitureStore_Toshmatov.Elements
{
    public partial class Item : UserControl
    {
        public Item(Classes.Item item)
        {
            InitializeComponent();

            if (item != null)
            {
                string imagePath = $"Images/Items/{item.ImageSrc}";

                string placeholderPath = "Images/i (1).png";

                if (File.Exists(imagePath))
                {
                    image.Source = new BitmapImage(new Uri(imagePath, UriKind.Relative));
                }
                else if (File.Exists(placeholderPath))
                {
                    image.Source = new BitmapImage(new Uri(placeholderPath, UriKind.Relative));
                }

                price.Content = item.Price.ToString("C0");
                name.Content = item.Name;
            }
        }
    }
}