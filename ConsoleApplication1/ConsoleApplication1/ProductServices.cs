using System.Collections.Generic;
using System.Linq;

// Developed by :
// Alexandre DO-O ALMEIDA
// Louis BEAUMONT
// 16/01/2017

namespace ConsoleApplication1
{
    class ProductServices
    {
        private ProductDataContext dataContext;
        private IEnumerable<Products> productQuery;

        // Constructeur ProductServices
        public ProductServices() {
            dataContext = new ProductDataContext();
        }

        // Retourne l’ensemble des produits
        public IEnumerable<Products> GetAll() {
            return productQuery = from product in dataContext.Products select product;
        }

        // Retourne le produit dont l’identifiant est passé en paramètre
        public IEnumerable<Products> GetProductById(int id) {
            return productQuery = from product in dataContext.Products where product.ProductID == id select product;
        }

        // Retourne tous les produits du fournisseur dont l’identifiant est passé en paramètre (ProviderId)
        public IEnumerable<Products> GetProductsByProvider(int id) {
            return productQuery = from product in dataContext.Products where product.SupplierID == id select product;
        }

        //Retourne tous les produits du fournisseur ayant l’identifiant idProvider et relevant de la catégorie d’identifiant idCategory
        public IEnumerable<Products> GetProductsByProviderAndCategory(int idProvider, int idCategory) {
            return productQuery = from product in dataContext.Products where product.SupplierID == idProvider && product.CategoryID == idCategory select product;
        }
    }
}
