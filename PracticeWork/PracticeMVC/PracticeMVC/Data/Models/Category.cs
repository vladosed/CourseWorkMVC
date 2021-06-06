using System;
using System.Collections.Generic;

namespace PracticeMVC.Models
{
    public class Category
    {
        public object id { get; set; }

        public string CategoryName { get; set; }

        public string description { get; set; }

        public List<Train> trains { get; set; }

    }
}
