using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InventoryService.Models;
using InventoryService.Services;
using InventoryService.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InventoryService.Controllers
{
    [Route("v1/")]
    [ApiController]
    public class InventoryController : Controller
    {
        private readonly IInventoryItemRepository _inventoryItemRespository;

        public InventoryController(IInventoryItemRepository inventoryItemRespository)
        {
            _inventoryItemRespository = inventoryItemRespository;
        }

        [HttpPost]
        [Route("AddInventoryItem")]
        public void AddInventoryItems([FromBody]InventoryItemParam item)
        {
            var itemToAdd = new InventoryItem
            {
                Id = item.Id,
                ItemName = item.ItemName,
                Price = item.Price,
            };

            _inventoryItemRespository.AddInventoryItem(itemToAdd);
        }
    }
}
