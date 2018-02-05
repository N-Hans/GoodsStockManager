using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoodsStockManager.API.Data;
using GoodsStockManager.API.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace GoodsStockManager.Controllers
{
    [Route("api/[controller]")]
    public class GoodsController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<GoodsItem> Get()
        {
            using (var goodsContext = new GoodsContext())
            {
                return goodsContext.Set<GoodsItem>();
            }
        }
    }
}
