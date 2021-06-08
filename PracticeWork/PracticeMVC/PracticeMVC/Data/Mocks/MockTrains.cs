using System;
using System.Collections.Generic;
using System.Linq;
using PracticeMVC.Data.Interfaces;
using PracticeMVC.Models;

namespace PracticeMVC.Data.Mocks
{
    public class MockTrains : IAllTrains
    {
        private readonly ITrainsCategory _categoryTrains = new MockCategory();

        public IEnumerable<Train> Trains
        {
            get
            {
                return new List<Train>
                {
                    new Train
                    {   name = "Hyundai",
                        shortDescription = "Soft and Comfortable",
                        longDescription = "Fast and cool",
                        img = "http://www.hyundaicorp.com/wp-content/uploads/2013/03/img_b_rs3.jpg",
                        avaliavle = true,
                        price = 10000,
                        isFavorite = true,
                        Category = _categoryTrains.AllCategories.First()
                    }
                };
            }
        }
        public IEnumerable<Train> getFavTrains { get; set; }
        public Train getObjectTrain(int trainId)
        {
            throw new NotImplementedException();
        }
    }
}
