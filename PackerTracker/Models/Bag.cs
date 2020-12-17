using System.Collections.Generic;


namespace PackerTracker.Models
{
  public class Bag
  {
    public string BagType { get; set; }
    public int WeightCapacity { get; set; }
    public int Id { get; }
    public List<Kit> Kits { get; set; }
    public List<Bag> _instances = new List<Bag> {}; 


    public Bag (int weightCapacity)
    {
      BagType = "";
      _instances.Add(this);
      Id = _instances.Count;
      WeightCapacity = weightCapacity;
      Kits = new List<Kit>{};
    }
    public void AddKit(Kit kit)
    {
      Kits.Add(kit);
    }

    public int GetWeight()
    {
      int outWeight = 0;
      foreach(Kit kit in Kits)
      {
        outWeight += kit.Weight;
      }
      return outWeight;
    }
    
  }
}


// namespace PackerTracker.Models
// {
//   public class Bag
//   {
//     public static List<Bag> _instances = new List<Bag> {};
//     public List<Kit> Kits { get; set; }
//     public int WeightCapacity { get; set; }

//     public Bag(int weight)
//     {
//       WeightCapacity = weight;
//       Kits = new List<Kit> {}; 
//      }
 //    
//   public string ExperienceCalculator(int WeightCapacity)
//    {
//       if (WeightCapacity < 50)
//       {
//         return "This pack is perfect for a beginning backpacker.";
//       }
//       else if (WeightCapacity < 80)
//       {
//         return "You should be fairly experienced to carry this pack.";
//       }
//       else
//       {
//         return "You're a glutton for punishment, I hope you're a Marine carrying that kind of weight!";
//       }
//     }
//   }
// }