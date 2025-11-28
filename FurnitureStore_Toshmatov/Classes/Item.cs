namespace FurnitureStore_Toshmatov.Classes
{
    public class Item
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string ImageSrc { get; set; }

        public Item(string name, int price, string imageSrc)
        {
            Name = name;
            Price = price;
            ImageSrc = imageSrc;
        }
    }
}