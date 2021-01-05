using StoreInventory.Models.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StoreInventory.Models.ViewModel
{
    public class ProductDetailsViewModel
    {
        public ProductDetailsViewModel()
        {

        }

        public ProductDetailsViewModel(ProductStoreDTO productStoreDTO)
        {
            Id = productStoreDTO.Id;
            Product = productStoreDTO.Product;
            Quantity = productStoreDTO.Quantity;
            Amount = productStoreDTO.Amount;
        }
        public int Id { get; set; }
        [Required]
        public string Product { get; set; }
        public int Quantity { get; set; }

        public decimal Amount { get; set; }

        public static implicit operator List<object>(ProductDetailsViewModel v)
        {
            throw new NotImplementedException();
        }
    }
}