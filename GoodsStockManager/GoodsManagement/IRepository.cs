using GoodsStockManager.API.Data.Models.DTO;
using System.Collections.Generic;

namespace GoodsStockManager.API.GoodsManagement
{
    public interface IRepository
    {
        IEnumerable<Good> ListGoods();
        Good GetGood(int goodId);
    }
}
