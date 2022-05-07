using Core.Enities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DomainModels
{
public class CartLine:IDomainModel
    {
        public Product product { get; set; }
        public int Quantity { get; set; }
    }
}
