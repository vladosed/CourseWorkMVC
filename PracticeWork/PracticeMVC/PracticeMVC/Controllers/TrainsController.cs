using System;
using Microsoft.AspNetCore.Mvc;
using PracticeMVC.Data.Interfaces;

namespace PracticeMVC.Controllers
{
    public class TrainsController : Controller
    {
        private readonly IAllTrains _allTrains;
        private readonly ITrainsCategory _allCategoties;

        public TrainsController(IAllTrains iAllTrains, ITrainsCategory iTrainsCategory)
        {
            _allTrains = iAllTrains;
            _allCategoties = iTrainsCategory;

        }
        public ViewResult List()
        {
            var trains = _allTrains.Trains;
            return View();
        }
    }
}
