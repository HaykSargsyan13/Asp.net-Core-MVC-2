using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ViewResult> Index()
        {
            #region product
            // List<string> results = new List<string>();
            #region first
            //  foreach (Product p in Product.GetProducts())
            //  {
            //    string name = p?.Name ?? "<No Name>";
            //    decimal? price = p?.Price ?? 0.00m;
            //    string relatedName = p?.Related?.Name ?? "<None>";
            //    results.Add(string.Format("Name: {0}, Price: {1:C2}, Related: {2}",
            //     name, price, relatedName));
            //}
            //return View(results);
            // }
            ///////// second
            //Dictionary<string, Product> products = new Dictionary<string, Product>
            //{
            //    ["Kayak"] = new Product { Name = "Kayak", Price = 275M },
            //    ["Lifejacket"] = new Product { Name = "Lifejacket", Price = 48.95M }
            //};
            //return View("Index", products.Keys);
            #endregion

            #region using keyword is
            object[] data = new object[] { 275M, 29.95M,
"apple", "orange", 100, 10 };
            decimal total = 0;
            /////////// using keyword is

            //            for (int i = 0; i < data.Length; i++)
            //            {
            //                if (data[i] is decimal d)
            //                {
            //                    total += d;
            //                }
            //            }
            //            return View("Index", new string[] { $"Total: {total:C2}" });
            #endregion

            #region using switch when
            //for (int i = 0; i < data.Length; i++)
            //{
            //    switch (data[i])
            //    {
            //        case decimal decimalValue:
            //            total += decimalValue;
            //            break;
            //        case int intValue when intValue > 50:
            //            total += intValue;
            //            break;
            //    }
            //}
            //return View("Index", new string[] { $"Total: {total:C2}" });
            #endregion

            #region using Extencion
            //            ShoppingCart cart
            //= new ShoppingCart { Products = Product.GetProducts() };
            //            decimal cartTotal = cart.TotalPrices();
            //            return View("Index", new string[] { $"Total: {cartTotal:C2}" });
            //        }
            #endregion

            #region using extencion for Interface

            //ShoppingCart cart
            //= new ShoppingCart { Products = Product.GetProducts() };
            //Product[] productArray = {
            //new Product {Name = "Kayak", Price = 275M},
            //new Product {Name = "Lifejacket", Price = 48.95M}
            //  };
            //decimal cartTotal = cart.TotalPrices();
            //decimal arrayTotal = productArray.TotalPrices();
            //return View("Index", new string[] {
            //   $"Cart Total: {cartTotal:C2}", $"Array Total: {arrayTotal:C2}" });

            #endregion

            #region using extencion for interface by filter
            //Product[] productArray = {
            //     new Product {Name = "Kayak", Price = 275M},
            //     new Product {Name = "Lifejacket", Price = 48.95M},
            //     new Product {Name = "Soccer ball", Price = 19.50M},
            //     new Product {Name = "Corner flag", Price = 34.95M}
            //};
            //decimal arrayTotal = productArray.FilterByPrice(20).TotalPrices();
            //return View("Index", new string[] { $"Array Total: {arrayTotal:C2}" });
            #endregion

            #region using extencion and lyamda expression

            //           Product[] productArray = {
            //               new Product {Name = "Kayak", Price = 275M},
            //               new Product {Name = "Lifejacket", Price = 48.95M},
            //               new Product {Name = "Soccer ball", Price = 19.50M},
            //               new Product {Name = "Corner flag", Price = 34.95M}
            //               };
            //           Func<Product, bool> nameFilter = delegate (Product prod) {
            //               return prod?.Name?[0] == 'S';
            //           };
            //           decimal priceFilterTotal = productArray
            //           .Filter(p => (p?.Price ?? 0) >= 20)
            //           .TotalPrices();
            //           decimal nameFilterTotal = productArray
            //           .Filter(p => p?.Name?[0] == 'S')
            //           .TotalPrices();
            //           return View("Index", new string[] {
            //$"Price Total: {priceFilterTotal:C2}",
            //$"Name Total: {nameFilterTotal:C2}" });
            //       }
            //       bool FilterByPrice(Product p)
            //       {
            //           return (p?.Price ?? 0) >= 20;
            //       }
            #endregion

            #region using anonymus type
            //           var products = new[] {
            //new { Name = "Kayak", Price = 275M },
            //new { Name = "Lifejacket", Price = 48.95M },
            //new { Name = "Soccer ball", Price = 19.50M },
            //new { Name = "Corner flag", Price = 34.95M }
            //};
            //           return View(products.Select(p => p.GetType().Name));
            #endregion

            #endregion

            long? length =await MyAsyncMethods.GetPageLength();
            return View(new string[] { $"Length: {length}" });
        }
    }
}