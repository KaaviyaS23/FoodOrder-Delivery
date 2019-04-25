using System;
using System.Collections.Generic;
namespace FoodOrder
{
    class Resturant
    {
        //Declare a Name Property of type String
        public String Name { get; set; } 
        //Declare a Location Property of type String
        public String Location { get; set; } 
        //Declare a Contact Property of type String
        public String Contact { get; set; }  
        //Creating a List of Item
        public List<Item> MenuItems = new List<Item>();  

        public Resturant() 
        {
            //Adding elements in MenuItems
            MenuItems.Add(new Item() { Name = "Bavan", Location = "Guindy", Contact = "9876543210", ItemName = "Pongal", ItemPrice = "20" });
            MenuItems.Add(new Item() { Name = "Buhari", Location = "Velacherry", Contact = "9876543210", ItemName = "Idly", ItemPrice = "30" });
            MenuItems.Add(new Item() { Name = "Sangeetha", Location = "Little Mount", Contact = "9876543210", ItemName = "Poori", ItemPrice = "40" });
            MenuItems.Add(new Item() {Name = "Saravana", Location = "Srp", Contact = "9876543210", ItemName = "Dosa", ItemPrice = "60" });
            MenuItems.Add(new Item() {Name = "Zaitoon", Location = "Tidel Park", Contact = "9876543210", ItemName = "Chappathi", ItemPrice = "20" });
        }
    }
}
    

