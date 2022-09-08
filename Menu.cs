using System;


namespace RestaurantMenu
{
    public class Menu
    {
        public DateTime LastUpdate { get; set; }
        public List<MenuItem> MenuItems = new List<MenuItem>();
        public Menu() // constructor
        {
        }

        public void addMenuItems(MenuItem item)
        {
            MenuItems.Add(item);
        }

        public void removeMenuItems(MenuItem item)
        {
            MenuItems.Remove(item);
        }


    } // close class


} // close namespace

