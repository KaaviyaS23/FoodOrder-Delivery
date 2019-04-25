using System;
namespace FoodOrder
{
    class OrderNow
    {
        //Main function
        static void Main(string[] args)
        {
            // Declaring an object of type User
            User order = new User();
            // Declaring an object of type Resturant
            Resturant restaurant = new Resturant();
            //set some values on the order object
            order.Name = "Kaaviya";
            order.OrderLocation = "TidelPark";
            order.ContactNumber = "9023456720";
            restaurant.MenuItems[0].ItemName.ToString();
            restaurant.MenuItems[0].ItemPrice.ToString();
            restaurant.MenuItems[0].Name.ToString();
            restaurant.MenuItems[0].Location.ToString();
            restaurant.MenuItems[0].Location.ToString();
            // Print out the Name,Location and Number with the order
            Console.WriteLine("Order Details\n  {0}\n {1}\n {2}\n ", order.Name, order.OrderLocation, order.ContactNumber);
            //Var is used for collect the item from MenuItems
            foreach (var itm in restaurant.MenuItems)
            {
                 Console.WriteLine("Resturant Details\n  {0}\n {1}\n {2}\n {3}\n {4}\n ",itm.Name,itm.Location,itm.Contact,itm.ItemName, itm.ItemPrice);
            }
                Console.ReadLine();
        }
    }
}
