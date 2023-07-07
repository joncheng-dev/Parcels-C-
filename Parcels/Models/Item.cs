using System.Collections.Generic;

namespace Parcels.Models
{
  public class Item
  {
    public double itemWeight { get; set; }
    // Dimensions
    public double itemLength { get; set; }
    public double itemWidth { get; set; }
    public double itemHeight { get; set; }
    // Volume
    public double itemVolume { get; set; }

    private static List<Item> _instances = new List<Item> { };

    public Item(double weight, double length, double width, double height)
    {
      itemWeight = weight;
      itemLength = length;
      itemWidth = width;
      itemHeight = height;
      _instances.Add(this);
    }

    public Item(double weight, double length, double width, double height, double volume)
    {
      itemWeight = weight;
      itemLength = length;
      itemWidth = width;
      itemHeight = height;
      itemVolume = volume;
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
  }
}