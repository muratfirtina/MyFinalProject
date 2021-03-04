using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal:IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            //bu liste herhangi bir veritabanından geliyormuş gibi simüle etmek için yazıldı.
            _products = new List<Product>
            {
                new Product{ProductId =1, CategoryId = 1, ProductName = "Bardak", UnitPrice = 15, UnitsInStock = 15},
                new Product{ProductId =2, CategoryId = 1, ProductName = "Kamera", UnitPrice = 500, UnitsInStock = 3},
                new Product{ProductId =3, CategoryId = 2, ProductName = "Telefon", UnitPrice = 1500, UnitsInStock = 2},
                new Product{ProductId =4, CategoryId = 2, ProductName = "Klavye", UnitPrice = 150, UnitsInStock = 65},
                new Product{ProductId =5, CategoryId = 2, ProductName = "Mouse", UnitPrice = 85, UnitsInStock = 1},
            };
        }
        public List<Product> GetAll()
        {
            return _products;
        }

        public void add(Product product)
        {
            _products.Add(product);
        }

        public void Update(Product product)
        {
            //gönderdiğim ürün idsine sahip olan listedeki ürünü bul.
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            _products.Remove(productToDelete);

            //linq olmasaydı alttaki gibi yazılırdı.
            //Product productToDelete = null;
            // foreach (var p in _products)
            // 
            //    if (product.ProductId == p.ProductId)
            //   {
            //       productToDelete = p;
            //  }
            // }
            //_products.Remove(productToDelete);
            //SingleOrDefault tekbir eleman bulmaya yarar. Products ı tek tek dolaşmaya yarar.


        }

        public List<Product> GetAllByCategory(int categoryId)
        {
           return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }
    }      //where koşulu içindeki şarta uyan bütün elemanları yeni bir liste haline getirir ve onu döndürür.
}
