using System;

namespace RestaurantMenu
{
    public class MenuItem
    {
        public string Name { get; set; }

        public string Category { get; set; }
        public string Description { get; set; }

        public int Price { get; set; }

        public bool IsNew { get; set; }

        public MenuItem(string name, string category, string description, int price, bool isNew) // constructor
        {
            Name = name;
            Category = category;
            Description = description;
            Price = price;
            IsNew = isNew;
        }
    }
}

