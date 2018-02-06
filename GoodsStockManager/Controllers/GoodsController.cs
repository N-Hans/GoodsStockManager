using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoodsStockManager.API.Data;
using GoodsStockManager.API.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace GoodsStockManager.Controllers
{

    public class GoodsController : Controller
    {

        private GoodsContext _dbContext;

        public GoodsController(GoodsContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET api/values
        [HttpGet]
        [Route("api/goods")]
        public IActionResult Get()
        {
            var goods = _dbContext.Goods.ToList();
            return Ok(goods);
        }
    }
}
