using System;
using System.ComponentModel.DataAnnotations;

namespace LatestMobiles.Models
{
    public class Mobiles
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Company { get; set; }
        public decimal Price { get; set; }
    }
}