using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;

namespace PringlesDatabase.Models
{
    public class Pringles
    {
        public int Id { get; set; }
        public string Flavor { get; set; }
        public string Description { get; set; }

        public ICollection<Rating> Ratings { get; set; }
    }
}