namespace Proba.Data.Models
{
    /// <summary>
    /// класс описывающий машину
    /// </summary>
    public class Car
    {
        //public Car( string name, string shortDesc, string longDesc, string img, ushort price, bool isFavourite, bool available, int categoryId)
        //{
        //   // Id = id;
        //    Name = name;
        //    ShortDesc = shortDesc;
        //    LongDesc = longDesc;
        //    Img = img;
        //    Price = price;
        //    IsFavourite = isFavourite;
        //    Available = available;
        //    CategoryId = categoryId;
        //   // Category = category;
        //}

        public int Id { get; set; }
        public string Name {  get; set; }
        public string ShortDesc {  get; set; }
        public string LongDesc {  get; set; }
        public string Img {  get; set; }
        public ushort Price { get; set; }
        public bool IsFavourite { get; set; }
        public bool Available {  get; set; }
        public int CategoryId {  get; set; }
        public virtual Category Category {  get; set; }

    }
}
