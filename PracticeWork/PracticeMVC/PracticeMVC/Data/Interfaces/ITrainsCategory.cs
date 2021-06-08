using System;
using PracticeMVC.Models;
using System.Collections.Generic;

namespace PracticeMVC.Data.Interfaces
{
    public interface ITrainsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
