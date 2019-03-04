using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace RentACar.Models
{
    public class Car
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Year { get; set; }

        [Required]
        [Range(0, 10, ErrorMessage = "Unexpected engine power!")]
        public float EnginePower { get; set; }

        [Required]
        [Range(0, 1500, ErrorMessage = "Unexpected horse power!")]
        public int HorsePower { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Maximum length 100 characters")]
        public string EngineType { get; set; }

        public int? Mileage { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Maximum length 100 characters")]
        public string Brand { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Maximum length 100 characters")]
        public string Model { get; set; }

        public string Image { get; set; }
    }
}