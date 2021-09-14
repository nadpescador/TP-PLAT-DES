using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Market
    {
        public List<Product> products { get; set; }
        public List<User> users { get; set; }
        public List<Category> categories { get; set; }
        public int maxCategories { get; set; }
        public int cantCategories { get; set; }
        public List<Purchase> purchases { get; set; }

        public Market(List<Product> products, List<User> users, List<Category> categories, int maxCategories, int cantCategories, List<Purchase> shopping)
        {
            this.products = products;
            this.users = users;
            this.categories = categories;
            this.maxCategories = maxCategories;
            this.cantCategories = cantCategories;
            this.purchases = shopping;
        }


        public bool AddProduct(Product product)
        {
            try
            {
                products.Add(product);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool ModifyProduct(int id, String nombre, double precio, int cantidad, int idCategoria) 
        {
        return true;
        }
        public bool DeleteProduct(int productId) 
        {
            try
            {
                //buscamos dentro de la lista el obj que contenga el mismo id 
                Product matchingProduct = products.Where(product => product.id == productId).First();
                products.Remove(matchingProduct);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            
        }
        public void SearchProducts(String query) { }
        public bool AddUser(User user) 
        {
            users.Add(user);
            return true;
        }
        public void ModifyUser(int userId) { }
        public bool DeleteUser(int userId)
        {
            try
            {
                //buscamos dentro de la lista el obj que contenga el mismo id 
                User matchingUser = users.Where(user => user.id == userId).First();
                users.Remove(matchingUser);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            
        }
        public bool AddCategory(Category category)
        {
            if (!categories.Contains(category))
            {
                categories.Add(category);
                return true;
            } else
            {
                return false;
            }
            
        }
        public void ModifyCategory(int categoryId) { }
        public bool DeleteCategory(int categoryId)
        {
            
            try
            {
                //buscamos dentro de la lista el obj que contenga el mismo id 
                Category matchingCategory = categories.Where(categorie => categorie.id == categoryId).First();
                categories.Remove(matchingCategory);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool AddToCart(int productId, int amount, int userId)
        {
            return true;
        }

        public void RemoveFromCart(int productId) {
            Product matchingProduct = products.Where(product => product.id == productId).First();
            products.Remove(matchingProduct);
        }

        public void EmptyCart() {
            purchases = new List<Purchase>();
        }

        public void Purchase(Purchase purchase)
        {
            purchases.Add(purchase);
        }

        public void ModifyPurchase(int purchaseId){}

        
        public bool DeletePurchase(int purchaseId)
        {
            try
            {
                //buscamos dentro de la lista el obj que contenga el mismo id 
                Purchase matchingPurchase = purchases.Where(purchase => purchase.id == purchaseId).First();
                purchases.Remove(matchingPurchase);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public void ShowAllProductsByPrice() {
            products = products.OrderBy(product => product.price).ToList();


            for(int i=0; i < products.Count; i++)
            {
                Console.WriteLine(i+1 + " - " + products[i]);
            }
        }

        public void ShowAllProductsByCategory() { }
        
    }   
}
