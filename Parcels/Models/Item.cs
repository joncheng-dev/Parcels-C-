using System.Collections.Generic;

namespace Parcels.Models
{
  public class Item
  {
    public double ItemWeight { get; set; }
    // Dimensions
    public double ItemLength { get; set; }
    public double ItemWidth { get; set; }
    public double ItemHeight { get; set; }
    // Volume
    public double ItemVolume { get; set; }
    // Cost to Ship
    public double ItemCost { get; set; }

    private static List<Item> _instances = new List<Item> { };

    public Item(double weight, double length, double width, double height)
    {
      ItemWeight = weight;
      ItemLength = length;
      ItemWidth = width;
      ItemHeight = height;
      _instances.Add(this);
    }

    public Item(double weight, double length, double width, double height, double volume)
    {
      ItemWeight = weight;
      ItemLength = length;
      ItemWidth = width;
      ItemHeight = height;
      ItemVolume = volume;
      _instances.Add(this);
    }

    public Item(double weight, double length, double width, double height, double volume, double cost)
    {
      ItemWeight = weight;
      ItemLength = length;
      ItemWidth = width;
      ItemHeight = height;
      ItemVolume = volume;
      ItemCost = cost;
      _instances.Add(this);
    }

    public static List<Item> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public void CalculateVolume()
    {
      ItemVolume = ItemLength * ItemWidth * ItemHeight;
    }

    public void CalculateCost()
    {
      ItemCost = ItemVolume * 0.5 * ItemWeight;
    }
  }
}