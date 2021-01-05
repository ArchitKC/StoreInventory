using StoreInventory.Models.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StoreInventory.Models.ViewModel
{
    public class UserDetailsViewModel
    {
        public UserDetailsViewModel()
        {

        }
        public UserDetailsViewModel(UserDetailsDTO userDetailsDTO)
        {
            UserName = userDetailsDTO.UserName;
            Email = userDetailsDTO.Email;
            CardNumber = userDetailsDTO.CardNumber;
            ExpiryDate = userDetailsDTO.ExpiryDate;
            StreetName = userDetailsDTO.StreetName;
            HouseNo = userDetailsDTO.HouseNo;
            City = userDetailsDTO.City;
            ZipCode = userDetailsDTO.ZipCode;
        }
        [Required]
        [StringLength(30, MinimumLength = 5)]
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        [StringLength(16, ErrorMessage ="Card number should be of 16 digit")]
        public string CardNumber { get; set; }
        public DateTime? ExpiryDate { get; set; }

        [Required]
        public string StreetName { get; set; }
        
        [Required]
        public string HouseNo { get; set; }
         
        [Required]
        [MinLength(5)]
        public string City { get; set; }
        [Required(ErrorMessage ="Zip Code should be of length 5")] 
        public int ZipCode { get; set; }

    }
}