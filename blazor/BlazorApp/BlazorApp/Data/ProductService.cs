using BlazorApp.Data.Database;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class ProductService
    {
        public IConfiguration Configuration { get; }
        private readonly MAIN_DATABASEContext _context;
        public ProductService(MAIN_DATABASEContext context)
        {
            _context = context;
        }

        public Task<List<Products>> NotSafe_EntityFramework(string search)
        {
            try
            {
                List<Products> searched = new List<Products>();
                var query = "SELECT p.productName, p.price, p.insertDate FROM products p WHERE p.productName LIKE '%" + search + "%' AND p.sold = 0";
                searched = _context.Products.FromSqlRaw(query).ToList();
                return Task.FromResult(searched);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return Task.FromResult(new List<Products>());
            }
        }

        public Task<List<Products>> HardSafe_EntityFramework(string search)
        {
            try
            {
                List<Products> searched = new List<Products>();
                var query = "SELECT p.productName, p.price, p.insertDate FROM products p WHERE p.productName LIKE '%" + EscapeCharacters(search) + "%' AND p.sold = 0";
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

        public Task<List<Products>> SafeEntityFramework(string search)
        {
            try { 
                List<Products> searched = new List<Products>();
                searched = (from products in _context.Products
                            where products.ProductName.Contains(search) 
                            select products).ToList();
                return Task.FromResult(searched);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return Task.FromResult(new List<Products>());
            }
}

        public Task<List<Products>> NotSafeDapper(string search)
        {
            try
            {
                List<Products> searched = new List<Products>();
                using (var connection = new SqlConnection("Data Source=192.168.99.100,9000;Initial Catalog=MAIN_DATABASE;User ID=sa;Password=@Dtidigital123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                {
                    connection.Open();

                    searched = connection.Query<Products>(
                                            @"SELECT p.productName, p.price, p.insertDate FROM products p WHERE p.productName LIKE '%" + search + "%' AND p.sold = 0"
                    ).ToList();

                    connection.Close();
                }
                return Task.FromResult(searched);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return Task.FromResult(new List<Products>());
            }
        }

        public Task<List<Products>> HardSafeDapper(string search)
        {
            try
            {
                List<Products> searched = new List<Products>();
                using (var connection = new SqlConnection("Data Source=192.168.99.100,9000;Initial Catalog=MAIN_DATABASE;User ID=sa;Password=@Dtidigital123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                {
                    connection.Open();

                    searched = connection.Query<Products>(
                                            @"SELECT p.productName, p.price, p.insertDate FROM products p WHERE p.productName LIKE '%" + EscapeCharacters(search) + "%' AND p.sold = 0"
                    ).ToList();

                    connection.Close();
                }
                return Task.FromResult(searched);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return Task.FromResult(new List<Products>());
            }
        }

        public Task<List<Products>> SafeDapper(string search)
        {
            try
            {
                List<Products> searched = new List<Products>();
                using (var connection = new SqlConnection("Data Source=192.168.99.100,9000;Initial Catalog=MAIN_DATABASE;User ID=sa;Password=@Dtidigital123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                {
                    connection.Open();

                    searched = connection.Query<Products>(
                                            @"SELECT p.productName, p.price, p.insertDate FROM products p WHERE p.productName LIKE @Search",
                                            new {Search = "%" + search + "%"}
                    ).ToList();

                    connection.Close();

                    return Task.FromResult(searched);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return Task.FromResult(new List<Products>());
            }
        }
    }
}