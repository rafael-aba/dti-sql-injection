using BlazorApp.Data.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class ProductService
    {
        private readonly MAIN_DATABASEContext _context;
        public ProductService(MAIN_DATABASEContext context)
        {
            _context = context;
        }

        public Task<List<Products>> GetNotSafeProductsAsync(string search)
        {
            try
            {
                List<Products> searched = new List<Products>();
                var query = "SELECT p.productName, p.price, p.insertDate FROM products p WHERE p.productName LIKE '%" + search + "%'";
                searched = _context.Products.FromSqlRaw(query).ToList();
                return Task.FromResult(searched);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return Task.FromResult(new List<Products>());
            }
        }

        public Task<List<Products>> GetHardSafeProductsAsync(string search)
        {
            try
            {
                List<Products> searched = new List<Products>();
                var query = "SELECT p.productName, p.price, p.insertDate FROM products p WHERE p.productName LIKE '%" + EscapeCharacters(search) + "%'";
                searched = _context.Products.FromSqlRaw(query).ToList();
                return Task.FromResult(searched);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return Task.FromResult(new List<Products>());
            }
        }

        private string EscapeCharacters(string search)
        {
            return search.Replace("'", "''");
        }

        public Task<List<Products>> GetProductsAsync(string search)
        {
            List<Products> searched = new List<Products>();
            searched = (from products in _context.Products
                        where products.ProductName.Contains(search)
                        select products).ToList();
            return Task.FromResult(searched);
        }
    }
}