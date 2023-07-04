using System.Collections.Generic;

namespace Parcels.Models
{
  public class Package
  {
    public double Weight { get; set; }

    public Package(double packageWeight)
    {
      Weight = packageWeight;
    }
  }
}