using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using ECommerceAPI.Domain.Entities;

namespace ECommerceAPI.Application.Abstractions
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}
