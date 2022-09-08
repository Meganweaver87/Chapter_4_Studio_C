// See https://aka.ms/new-console-template for more information

using RestaurantMenu;
using System;
using System.Security.Cryptography.X509Certificates;

namespace RestaurantMenu
{
    class Program
    {

        static void Main()
        {
            const string accomodationStatement = "Can be prepared without meat, gluten, or dairy upon request.";

            Menu ButtonRoadCafe = new Menu();

            ButtonRoadCafe.LastUpdate = DateTime.Now;

            MenuItem PotatoNachos = new MenuItem("Potato Nachos", "Appetizer", "Fried potato wedges topped with fresh tomatoes, roasted garlic, and cheesy sauce.", 8, false);
            ButtonRoadCafe.addMenuItems(PotatoNachos);
            MenuItem CheeseCurds = new MenuItem("Cheese Curds", "Appetizer", "Battered and fried cheese curds served with a lime cream.", 8, true);
            ButtonRoadCafe.addMenuItems(CheeseCurds);
            MenuItem ShanghaiLumpia = new MenuItem("Shanghai Lumpia", "Appetizer", "Thin, crunchy fried rolls filled with meat and vegetables.", 8, false);
            ButtonRoadCafe.addMenuItems(ShanghaiLumpia);

            MenuItem SalmonPokeBowl = new MenuItem("Salmon Poke Bowl", "Main Course", "Marinated sashimi-grade salmon served with rice. Topped with masago, gomasio, and panko crumbs.", 12, false);
            ButtonRoadCafe.addMenuItems(SalmonPokeBowl);
            MenuItem GarlicParmWings = new MenuItem("Garlic Parm Wings", "Main Course", "Battered and fried boneless wings coated with roasted garlic and freshly-grated parmesan.", 12, true);
            ButtonRoadCafe.addMenuItems(GarlicParmWings);
            MenuItem ChickenFricassee = new MenuItem("Chicken Fricassee", "Main Course", "A hearty cream-based stew including chicken, smoked sausage, and potatoes.", 12, false);
            ButtonRoadCafe.addMenuItems(ChickenFricassee);

            MenuItem MiniDonuts = new MenuItem("Mini Donuts", "Dessert", "Fried mini donuts dusted with powdered sugar. Served with a cinnamon cream cheese dip.", 10, true);
            ButtonRoadCafe.addMenuItems(MiniDonuts);
            MenuItem Profiteroles = new MenuItem("Profiteroles", "Dessert", "Light choux buns filled with banana cream and topped with chocolate ganache.", 10, false);
            ButtonRoadCafe.addMenuItems(Profiteroles);
            MenuItem StrawberryShortcakeBites = new MenuItem("Strawberry Shortcake Bites", "Dessert", "Strawberries and whipped cream sandwiched between mini short biscuits.", 10, false);
            ButtonRoadCafe.addMenuItems(StrawberryShortcakeBites);

            bool viewMenu;
            Console.WriteLine("Would you like to see the entire menu?");
            string userResponse = Console.ReadLine();
            if (userResponse.Substring(0, 1).ToLower() == "y" || userResponse.ToLower() == "sure")
            {
                printAll(ButtonRoadCafe.MenuItems);
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine(accomodationStatement);
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("Last updated: " + ButtonRoadCafe.LastUpdate);

            }
            else if (userResponse.ToLower() == "no" || userResponse.ToLower() == "absolutely not")
            {
                Console.WriteLine("Would you like to see an individual menu item?");
                userResponse = Console.ReadLine();
                if (userResponse.Substring(0, 1).ToLower() == "y")
                {
                    Console.WriteLine("Please select an item.");
                    foreach (MenuItem menuItem in ButtonRoadCafe.MenuItems)
                    {
                        Console.WriteLine(menuItem.Name);
                    }
                    userResponse = Console.ReadLine();

                    foreach (MenuItem menuItem in ButtonRoadCafe.MenuItems)
                    {
                        while (userResponse.ToLower() != menuItem.Name.ToLower())
                        {
                            Console.WriteLine("Oops! Please try again.");
                        }
                        if (userResponse.ToLower() == menuItem.Name.ToLower())
                        {
                            printOne(menuItem);
                            break;
                        }
                 
                    } // close foreach
                } // close if
                else
                {
                    Console.WriteLine("Thank you for stopping by! Have a nice day.");
                }

            void printAll(Menu printMenu)
            {
                foreach (MenuItem item in printMenu.MenuItems)
                {
                    printOne(item);
                }
            }

            void printOne(MenuItem item)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Category);
                Console.WriteLine(item.Description);
                Console.WriteLine("$" + item.Price.ToString());
                if (item.IsNew)
                {
                    Console.WriteLine("new Item!");
                }
            }
        
        } // close main

        bool menuItemsEqual(MenuItem item1, MenuItem item2)
        {
            return item1.Name == item2.Name;
        }


    } // close class program
} // close namespace


