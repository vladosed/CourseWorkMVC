using System;
using System.Collections.Generic;
using PracticeMVC.Models;

namespace PracticeMVC.Data.Interfaces
{
    public interface IAllTrains
    {
       IEnumerable<Train> Trains { get; }
       IEnumerable<Train> getFavTrains { get; set; }
       Train getObjectTrain(int trainId);
    }
}
