using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoodsStockManager.API.Data;
using GoodsStockManager.API.Data.Enumerations;
using GoodsStockManager.API.Data.Models;
using GoodsStockManager.API.Extensions;
using GoodsStockManager.API.GoodsManagement;
using GoodsStockManager.API.Utils;
using Microsoft.AspNetCore.Mvc;

namespace GoodsStockManager.GoodsManagement
{

    public class GoodsController : Controller
    {

        private IRepository _repository;

        public GoodsController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("api/goods")]
        public IActionResult ListGoods()
        {
            var goods = _repository.ListGoods();
            return Ok(goods);
        }

        [HttpGet]
        [Route("api/goods/management-types")]
        public IActionResult GoodsManagementTypes()
        {
            var managementTypes = Utils.GetEnumMembersDescription(typeof(GoodsItemManagementTypes));
            return Ok(managementTypes);
        }

        [HttpGet]
        [Route("api/goods/{goodId}")]
        public IActionResult GetGood(int goodId)
        {
            var good = _repository.GetGood(goodId);
            return Ok(good);
        }
    }
}
