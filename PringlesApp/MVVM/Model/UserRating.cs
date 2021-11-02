using System.Collections.Generic;
using System.Windows.Documents;
using PringlesDatabase.Models;

namespace PringlesApp.MVVM.Model
{
    public class UserRating
    {
        public int Flavor { get; set; }
        public double Score { get; set; }
        public string Description { get; set; }
        
    }
}