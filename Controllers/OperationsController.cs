using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Audify.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Audify.Controllers
{
  
    public class OperationsController : ControllerBase
    {
        private readonly DataContext _context;
        public OperationsController(DataContext context)
        {
            _context = context;
        }
       
      
        [HttpPost]
        [Route("api/v1/Audify/product/Add")]
        public IActionResult AddProduct(Product product)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            product.Id = Guid.NewGuid().ToString();
            product.UserId = User.FindFirstValue("Id");
            _context.Products.Add(product);
            _context.SaveChanges();
            return Ok(product);
        }
        [Route("api/v1/Audify/Category/Add")]
        [HttpPost]
      public IActionResult ProductCategory(ProductCategory productCategory)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            productCategory.Id = Guid.NewGuid().ToString();
            productCategory.UserId = User.FindFirstValue("Id");
            _context.Categories.Add(productCategory);
            _context.SaveChanges();
            return Ok(productCategory);
        }

        [HttpPost]
        [Route("api/v1/Audify/product/Transactions")]
        public IActionResult Transaction(Transactions trans)
        {
            if (ModelState.IsValid)
                return BadRequest();
            var Id = User.FindFirstValue("Id");
            trans.Id = Guid.NewGuid().ToString();
            trans.AccountId = Id;
            _context.Transactions.Add(trans);
            _context.SaveChanges();
            return Ok(trans);
        }
    }

}
