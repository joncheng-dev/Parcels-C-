using System.Collections.Generic;

namespace Parcels.Models
{
  public class Package
  {
    public double itemWeight { get; set; }
    // Dimensions
    public double itemLength { get; set; }
    public double itemWidth { get; set; }
    public double itemHeight { get; set; }

    public Package(double weight, double length, double width, double height)
    {
      itemWeight = weight;
      itemLength = length;
      itemWidth = width;
      itemHeight = height;
    }
  }
}