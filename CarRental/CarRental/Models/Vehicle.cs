using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public string Notes { get; set; }
        [ForeignKey("ClientId")]
        public Client Client { get; set; }
        public int? ClientId { get; set; }
        public int DailyPrice { get; set; }
        public int RentedDays { get; set; }
        public string ImageFileUrl { get; set; }
    }

}
