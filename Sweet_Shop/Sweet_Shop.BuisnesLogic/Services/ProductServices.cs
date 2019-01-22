using Sweet_Shop.Models.Datamodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweet_Shop.BuisnesLogic.Services
{
    public interface IProductsServices
    {
        List<Product> GetList();
    }

    public class ProductServices : IProductsServices
    {
        public List<Product> GetList()
        {
            var products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    groupId = "1",
                    Name = "Banana",
                    Price ="55.5"
                },
                new Product
                {
                     Id = 2,
                    groupId = "2",
                    Name = "Kiwi",
                    Price ="75.5"
                }

            };

            return products;
        }
    }
}
