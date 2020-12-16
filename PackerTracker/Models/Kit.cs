using System.Collections.Generic;


namespace PackerTracker.Models
{
    public class Kit
    {
        public string Name { get; set; }
        public int Price { get; set; } 
        public int Weight { get; set; }
        public bool Purchased { get; set; }
        public bool Packed { get; set; }
        public int Id { get; set; }
        private static List<Kit> _instances = new List<Kit> {};
        public Kit (string name, int price, int weight, bool purchased, bool packed)
        {
          Name = name;
          Price = price;
          Weight = weight;
          Purchased = purchased;
          Packed = packed;
          _instances.Add(this);
          Id = _instances.Count;
        }

        
    }
}