using System.Collections.Generic;

namespace Parcels.Models
{
  public class Package
  {
    public double itemWeight { get; set; }
    // Dimensions
    public double itemLength { get; set; }
    public double itemWidth { get; set; }

    public Package(double weight, double length, double width)
    {
      itemWeight = weight;
      itemLength = length;
      itemWidth = width;
    }
  }
}