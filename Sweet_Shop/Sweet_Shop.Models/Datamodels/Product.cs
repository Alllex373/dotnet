using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweet_Shop.Models.Datamodels
{
    public class Product
    {
        public int Id { get; set; }

        public string groupId { get; set; }

        public string Name { get; set; }

        public string Price { get; set; }
    }
}
