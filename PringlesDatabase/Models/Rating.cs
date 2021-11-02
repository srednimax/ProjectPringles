using System;

namespace PringlesDatabase.Models
{
    public class Rating
    {
        public int Id { get; set; }
        public double Score { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Description { get; set; }

        public User User { get; set; }

        public Pringles Pringles { get; set; }
    }
}