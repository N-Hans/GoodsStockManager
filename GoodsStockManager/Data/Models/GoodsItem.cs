using GoodsStockManager.API.Data.Enumerations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoodsStockManager.API.Data.Models
{
    public class GoodsItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Code {get; set;}

        public string Description { get; set; }

        public bool IsActive { get; set; }

        public string ForeignDescription { get; set; }

        public bool IsSalesItem { get; set; }

        public bool IsStockItem { get; set; }

        public bool IsPurchasedItem { get; set; }

        public string Barcode { get; set; }

        public GoodsItemManagementType ManageItemBy { get; set; }

        public decimal MinimumInventory { get; set; }

        public decimal MaximumInventory { get; set; }

        public string Remarks { get; set; }

        public string ImagePath { get; set; }
    }
}
