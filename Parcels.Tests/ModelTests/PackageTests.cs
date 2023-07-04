using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Parcels.Models;
using System;

namespace Parcels.Tests
{
  [TestClass]
  public class PackageTests
  {
    [TestMethod]
    public void PackageConstructor_CreatesInstanceOfPackage_Package()
    {
      double aWeight = 1;
      double aLength = 2;
      double aWidth = 3;
      double aHeight = 4;
      Package newPackage = new Package(aWeight, aLength, aWidth, aHeight);
      Assert.AreEqual(typeof(Package), newPackage.GetType());
    }

    [TestMethod]
    public void GetWeight_ReturnsWeight_Double()
    {
      double aWeight = 1;
      double aLength = 2;
      double aWidth = 3;
      double aHeight = 4;
      Package newPackage = new Package(aWeight, aLength, aWidth, aHeight);
      Assert.AreEqual(aWeight, newPackage.itemWeight);
    }

    [TestMethod]
    public void SetWeight_SetsValueOfWeight_Double()
    {
      //Arrange
      double aWeight = 1;
      double aLength = 2;
      double aWidth = 3;
      double aHeight = 4;
      Package newPackage = new Package(aWeight, aLength, aWidth, aHeight);
      //Act
      double updatedWeight = 2;
      newPackage.itemWeight = updatedWeight;
      //Assert
      Assert.AreEqual(updatedWeight, newPackage.itemWeight);
    }

    [TestMethod]
    public void GetLength_ReturnsLength_Double()
    {
      double aWeight = 1;
      double aLength = 2;
      double aWidth = 3;
      double aHeight = 4;
      Package newPackage = new Package(aWeight, aLength, aWidth, aHeight);
      Assert.AreEqual(aLength, newPackage.itemLength);
    }

    [TestMethod]
    public void SetLength_SetsValueOfLength_Double()
    {
      double aWeight = 1;
      double aLength = 2;
      double aWidth = 3;
      double aHeight = 4;
      Package newPackage = new Package(aWeight, aLength, aWidth, aHeight);

      double updatedLength = 4;
      newPackage.itemLength = updatedLength;

      Assert.AreEqual(updatedLength, newPackage.itemLength);
    }

    [TestMethod]
    public void GetWidth_ReturnsWidth_Double()
    {
      double aWeight = 1;
      double aLength = 2;
      double aWidth = 3;
      double aHeight = 4;
      Package newPackage = new Package(aWeight, aLength, aWidth, aHeight);
      Assert.AreEqual(aWidth, newPackage.itemWidth);
    }

    [TestMethod]
    public void SetWidth_SetsValueOfWidth_Double()
    {
      double aWeight = 1;
      double aLength = 2;
      double aWidth = 3;
      double aHeight = 4;
      Package newPackage = new Package(aWeight, aLength, aWidth, aHeight);

      double updatedWidth = 40;
      newPackage.itemWidth = updatedWidth;

      Assert.AreEqual(updatedWidth, newPackage.itemWidth);
    }

    [TestMethod]
    public void GetHeight_ReturnsHeight_Double()
    {
      double aWeight = 1;
      double aLength = 2;
      double aWidth = 3;
      double aHeight = 4;
      Package newPackage = new Package(aWeight, aLength, aWidth, aHeight);

      Assert.AreEqual(aHeight, newPackage.itemHeight);
    }

    [TestMethod]
    public void SetHeight_SetsValueOfHeight_Double()
    {
      double aWeight = 1;
      double aLength = 2;
      double aWidth = 3;
      double aHeight = 4;
      Package newPackage = new Package(aWeight, aLength, aWidth, aHeight);

      double updatedHeight = 40;
      newPackage.itemHeight = updatedHeight;

      Assert.AreEqual(updatedHeight, newPackage.itemHeight);
    }
  }
}