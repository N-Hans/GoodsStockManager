using GoodsStockManager.API.Data.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoodsStockManager.API.Data.Models.DTO
{
    public class Good
    {
        [Required]
        [MaxLength(25)]
        public string Code { get; set; }

        [Required]
        [MaxLength(300)]
        public string Description { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [MaxLength(300)]
        public string ForeignDescription { get; set; }

        [Required]
        public bool IsSalesItem { get; set; }

        [Required]
        public bool IsStockItem { get; set; }

        [Required]
        public bool IsPurchasedItem { get; set; }

        [Required]
        [MaxLength(100)]
        public string Barcode { get; set; }

        [Required]
        public GoodsItemManagementTypes ManageItemBy { get; set; }

        [Required]
        public decimal MinimumInventory { get; set; }

        [Required]
        public decimal MaximumInventory { get; set; }

        public string Remarks { get; set; }

        [Required]
        public string Image { get; set; }
    }
}
