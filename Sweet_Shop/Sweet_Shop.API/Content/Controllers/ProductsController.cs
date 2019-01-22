using Sweet_Shop.BuisnesLogic.Services;
using Sweet_Shop.Models.Datamodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sweet_Shop.API.Controllers
{
    public class ProductsController : ApiController
    {
        private readonly IProductsServices _productsService;

        public ProductsController()
        {
            _productsService = new ProductServices();
        }

        [HttpGet]

        public IHttpActionResult GetAll()
        {
            var products = _productsService.GetList();

            return Ok(products);
        }

        [HttpPost]

        public IHttpActionResult Add([FromBody] Product group)
        {
            if (!ModelState.IsValid)
                return (BadRequest(ModelState));

            //if (string.IsNullOrEmpty(group.Name))
            //    return BadRequest("Oops");
            return Ok();
        }


    }
}
