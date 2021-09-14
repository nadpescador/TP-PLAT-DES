using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            FinalClient finalClient = new FinalClient(01020304);

            Company company1 = new Company(30502067);
            Category category1 = new Category(01, "lasungadeseba");
            List<User> users = new List<User>();
            List<Product> products = new List<Product>();
            List<Purchase> purchases = new List<Purchase>();
            List<Category> categories = new List<Category>();
            
            Market market = new Market(products, users, categories, 10, categories.Count, purchases);

            // Carga estatica de productos
            products.Add(new Product() { id = 1, name = "product 0", price = 10.10, amount = 1, category = category1 });
            products.Add(new Product() { id = 2, name = "product 1", price = 11.11, amount = 4, category = category1 });
            products.Add(new Product() { id = 3, name = "product 2", price = 5.5, amount = 3, category = category1 });
            // Fin Carga estatica de productos

            Panel(market);
        }

        static void MainMessages()
        {
            Console.WriteLine("Bienvenido a betos market");
            Console.WriteLine("------------------");
            Console.WriteLine("Elija una opcion: ");
            Console.WriteLine("\n 1.Administrar");
            Console.WriteLine("\n 2.Comprar");
            Console.WriteLine("\n 3.Salir");
        }
     
        
        static void OptionPanel()
        {
            Console.WriteLine("\n 1.Alta de categoría");
            Console.WriteLine("\n 2.Baja de categoría");
            Console.WriteLine("\n 3.Modificación de categoría");
            Console.WriteLine("\n 4.Mostrar categorías que existen en el sistema");
            Console.WriteLine("\n 5.Alta de usuario");
            Console.WriteLine("\n 6.Baja de usuario");
            Console.WriteLine("\n 7.Modificación de usuario");
            Console.WriteLine("\n 8.Mostrar usuarios que existen en el sistema");
            Console.WriteLine("\n 9.Alta de producto");
            Console.WriteLine("\n 10.Baja de producto");
            Console.WriteLine("\n 11.Modificación de producto");
            Console.WriteLine("\n 12.Mostrar productos que existen en el sistema");
            Console.WriteLine("\n 13.Mostrar productos que existen en el sistema ordenados por precio");
            Console.WriteLine("\n 14.Mostrar productos que existen en el sistema ordenados por categoría");
        }

        static void Panel(Market market)
        {
            Spacer();
            Console.WriteLine("Elija una opcion: ");

            MainMessages();
            String option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    OptionPanel();
                    String option2 = Console.ReadLine();
                    switch (option2)
                    {
                        case "1":
                            Console.WriteLine("Ingrese un id para la categoria: ");
                            String id = Console.ReadLine();
                            int idnumero = Int16.Parse(id);
                            Console.WriteLine("Ingrese un nombre para la categoria: ");
                            String name = Console.ReadLine();
                            Category newCategory = new Category(idnumero, name);
                            market.AddCategory(newCategory);
                            break;
                        case "2":
                            Console.WriteLine("Ingrese un id para la categoria a dar de baja: ");
                            id = Console.ReadLine();
                            idnumero = Int16.Parse(id);
                            market.DeleteCategory(idnumero);
                            break;
                        case "3":
                            break;
                        case "4":
                            market.ShowAllProductsByCategory();
                            break;
                        case "5":
                            break;
                        case "6":
                            break;
                        case "7":
                            break;
                        case "8":
                            break;
                        case "9":
                            Product product = new Product();
                            product.id = Int16.Parse(InputRead("Ingrese un id: \n"));
                            product.name = InputRead("Ingrese un nombre: \n");
                            product.price = Double.Parse(InputRead("Ingrese un precio: \n"));
                            product.amount = Int16.Parse(InputRead("Ingrese la cantidad: \n"));
                            market.AddProduct(product);
                            break;
                        case "10":
                            break;
                        case "11":
                            break;
                        case "12":
                            break;
                        case "13":
                            market.ShowAllProductsByPrice();
                            break;
                        case "14":
                            break;
                    }
                    break;

                case "2":
                    Console.WriteLine("Esta seccion se encuentra aun en construccion, esperar a TP2");
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        
            Panel(market);
        }

        static String InputRead(String text)
        {
            Console.WriteLine(text);
            return Console.ReadLine();
        }

        static void Spacer()
        {
            Console.WriteLine("--------------------------");
        }
    }

}
