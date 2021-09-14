using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class User  
    {   
        public int id { get; set; }
        public int dni { get; set; }
        public String name { get; set; }
        public String lastName { get; set; }
        public String email { get; set; }
        public String password { get; set; }
        public Cart cart { get; set;}



        public User(int id, int dni, String name, String lastName, String email, String password, Cart cart) {
            this.id = id;
            this.dni = dni;
            this.name = name;
            this.lastName = lastName;
            this.email = email;
            this.password = password;
            this.cart = cart;
        }


        public override string ToString()
        {
            return "\nUser: " +
                "\nId:" + id + " - " +
                "DNI:" + dni + " - " +
                "Name:" + name + " - " +
                "LastName:" + lastName + " - " +
                "Email:" + email + " - " +
                "Password:" + password + " - " +
                "Cart:" + cart;

        }


        //Fuente toString: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-override-the-tostring-method
    }

}
