using Entities.Concrete;
using Entities.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICartService
    {
        void AddToCard(Cart cart, Product product);
        void RemoveFromCard(Cart cart, int productId);
        List<CartLine> List(Cart cart);
    }
}
