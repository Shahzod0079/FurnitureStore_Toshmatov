using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureStore_Toshmatov.Classes
{
    public class Item
    {
        /// <summary>Наименование товара</summary>
        public string Name { get; set; }

        /// <summary>Цена товара</summary>
        public int Price { get; set; }

        /// <summary>Ссылка на изображение</summary>
        public string ImageSrc { get; set; }

        /// <summary>
        /// Создает новый экземпляр товара
        /// </summary>
        /// <param name="name">Наименование товара</param>
        /// <param name="price">Цена товара</param>
        /// <param name="imageSrc">Ссылка на изображение</param>
        public Item(string name, int price, string imageSrc)
        {
            Name = name;
            Price = price;
            ImageSrc = imageSrc;
        }
    }
}