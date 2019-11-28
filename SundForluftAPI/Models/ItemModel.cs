using System;
using System.ComponentModel.DataAnnotations;

namespace SundForluftAPI.Models
{
    public class ItemModel
    {
        
        [Key]
        public DateTime DateTime { get; set; }
        
        public double Ppm { get; set; }
        
        public int DeviceId { get; set; }
        
        public int LocationId { get; set; }
        
        
    }
}