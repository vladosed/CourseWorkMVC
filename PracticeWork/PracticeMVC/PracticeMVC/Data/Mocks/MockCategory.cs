using System;
using System.Collections.Generic;
using PracticeMVC.Data.Interfaces;
using PracticeMVC.Models;


namespace PracticeMVC.Data.Mocks
{
    public class MockCategory : ITrainsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { CategoryName = "Coupe", description = "Room for 4 passengers" },
                    new Category { CategoryName = "ElectroTrain", description = "Cheaper train with openspace seats" }
                };

            }
        }

    }
}
