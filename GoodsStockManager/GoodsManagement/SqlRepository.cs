using System;
using System.Collections.Generic;
using System.Linq;
using GoodsStockManager.API.Data;
using GoodsStockManager.API.Data.Enumerations;
using GoodsStockManager.API.Data.Models;
using GoodsStockManager.API.Data.Models.DTO;
using GoodsStockManager.API.Extensions;

namespace GoodsStockManager.API.GoodsManagement
{
    public class SqlRepository : IRepository
    {
        private GoodsContext _dbContext;

        public SqlRepository(GoodsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Good GetGood(int goodId)
        {
            using (_dbContext)
            {
                return _dbContext.Goods.Find(goodId).ToGood();
            }
        }

        public IEnumerable<Good> ListGoods()
        {
            return _dbContext.Goods.Select(goodsItem => goodsItem.ToGood());
        }
    }
}
