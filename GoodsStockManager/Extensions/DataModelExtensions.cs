using GoodsStockManager.API.Data.Models;
using GoodsStockManager.API.Data.Models.DTO;
using System;
using System.IO;

namespace GoodsStockManager.API.Extensions
{
    public static class DataModelExtensions
    {
        public static Good ToGood(this GoodsItem goodsItem)
        {
            var imageBytes = File.ReadAllBytes(Directory.GetCurrentDirectory() + goodsItem.ImagePath);
            var imageString = Convert.ToBase64String(imageBytes);

            return new Good
            {
                Code               = goodsItem.Code,
                Description        = goodsItem.Description,
                ForeignDescription = goodsItem.ForeignDescription,
                Barcode            = goodsItem.Barcode,
                IsActive           = goodsItem.IsActive,
                IsPurchasedItem    = goodsItem.IsPurchasedItem,
                IsSalesItem        = goodsItem.IsSalesItem,
                IsStockItem        = goodsItem.IsStockItem,
                ManageItemBy       = goodsItem.ManageItemBy,
                MaximumInventory   = goodsItem.MaximumInventory,
                MinimumInventory   = goodsItem.MinimumInventory,
                Remarks            = goodsItem.Remarks,
                Image              = imageString
            };
        }
    }
}
