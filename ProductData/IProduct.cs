using ProductData.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductData
{
    public interface IProduct
    {
        Task<List<Item>> GetItems();
    }
}