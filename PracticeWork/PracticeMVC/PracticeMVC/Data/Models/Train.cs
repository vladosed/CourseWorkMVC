using System;
namespace PracticeMVC.Models
{
    public class Train
    {
        public int id { get; set; }

        public string name { get; set; }

        public string shortDescription { get; set; }

        public string longDescription { get; set; }

        public string img { get; set; }

        public ushort price { get; set; }

        public bool isFavorite { get; set; }

        public int avaliavle { get; set; }

        public int categoryID { get; set; }

        public virtual Category Category { get; set; }
    }
}
