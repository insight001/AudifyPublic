using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Audify.Model;
using Audify.Utilities;
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


        public async Task FinalizeDayTransactionsAsync()
        {
            var Trans = _context.Transactions.Where(x => x.TransDay.Date == DateTime.Today);
            string fileName = $"~/wwwroot/Transactions/{Guid.NewGuid().ToString()}";
            using (FileStream fs = System.IO.File.Create(fileName))
            {
                // Add some text to file    
                foreach( var item in Trans)
                {
                    Byte[] title = new UTF8Encoding(true).GetBytes($"Transaction Record for {DateTime.Today}");
                    fs.Write(title, 0, title.Length);
                    byte[] content = new UTF8Encoding(true).GetBytes($"{item.AccountId}\t{item.Amount}\t{item.mode}\t{item.ProductCategoryId}\t{item.ProductId}\t{item.ProviderId}");
                    fs.Write(content, 0, content.Length);
                }
                IPFSHelper h = new IPFSHelper();
               string x = await  h.UploadIPFSAsync(fileName);
                var data = new HashStore
                {
                    Date = DateTime.Now,
                    Id = Guid.NewGuid().ToString(),
                    Hash = x,
                };
                _context.HashStores.Add(data);
                _context.SaveChanges();
            }
        }

    }

}
