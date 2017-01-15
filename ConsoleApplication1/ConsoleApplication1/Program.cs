using System;
using System.Collections.Generic;
using System.Linq;

// Developed by :
// Alexandre DO-O ALMEIDA
// Louis BEAUMONT
// 16/01/2017

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductServices productServices = new ProductServices();

            // Liste de tous les produits
            IEnumerable<Products> productQuery = productServices.GetAll();

            // Exercice 1 
            // ProductName des 3 produits les plus chers
            IEnumerable<Products> exerciceUn = productQuery.OrderBy(p => p.UnitPrice).Take(3);

            Console.WriteLine("ProductName des 3 produits les plus chers : \n");
            foreach (var Products in exerciceUn) {
                Console.WriteLine(Products.ProductName);
            }

            // Exercice 2
            // ProductName triés par ordre alphabétique croissant des produits en rupture de stock (discontinued)
            IEnumerable<Products> exerciceDeux = productQuery.OrderBy(p => p.ProductName).Where(p => p.Discontinued);

            Console.WriteLine("\nProductName triés par ordre alphabétique croissant des produits en rupture de stock (discontinued) : \n");
            foreach (var Products in exerciceDeux) {
                Console.WriteLine(Products.ProductName);
            }

            // Exercice 3
            // Nombre de produits en stocks relevant du fournisseur 1 et de la catégorie 1
            Console.WriteLine("\nNombre de produits en stocks relevant du fournisseur 1 et de la catégorie 1 :\n" + productServices.GetProductsByProviderAndCategory(1, 1).Count());

            // Exercice 4
            // Prix moyen des articles relevant de la catégorie 2
            Console.WriteLine("\nPrix moyen des articles relevant de la catégorie 2 :\n" + productQuery.Where(p => p.CategoryID == 2).Average(p => p.UnitPrice));

            Console.ReadLine();
        }
    }
}
