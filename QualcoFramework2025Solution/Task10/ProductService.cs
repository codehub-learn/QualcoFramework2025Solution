

using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace QualcoLab2025.Task10
{

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class ProductService
    {
        private static readonly HttpClient httpClient = new HttpClient();

        public async Task<Product> FetchProductAsync(int id)
        { 
            return null;  
        }
    }
}

