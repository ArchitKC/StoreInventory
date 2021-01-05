using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StoreInventory.Models.Data
{
    public class UserDetailsDTO
    { 
        public string UserName { get; set; } 
        public string Email { get; set; }
        public string CardNumber { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string StreetName { get; set; }
        public string HouseNo { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
    }
}