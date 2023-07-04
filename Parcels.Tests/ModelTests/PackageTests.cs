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
      Package newPackage = new Package(aWeight, aLength);
      Assert.AreEqual(typeof(Package), newPackage.GetType());
    }

    [TestMethod]
    public void GetWeight_ReturnsWeight_Double()
    {
      double aWeight = 1;
      double aLength = 2;
      Package newPackage = new Package(aWeight, aLength);
      Assert.AreEqual(aWeight, newPackage.itemWeight);
    }

    [TestMethod]
    public void SetWeight_SetsValueOfWeight_Double()
    {
      //Arrange
      double aWeight = 1;
      double aLength = 2;
      Package newPackage = new Package(aWeight, aLength);
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
      Package newPackage = new Package(aWeight, aLength);
      Assert.AreEqual(aLength, newPackage.itemLength);
    }

    [TestMethod]
    public void SetLength_SetsValueOfLength_Double()
    {
      double aWeight = 1;
      double aLength = 2;
      Package newPackage = new Package(aWeight, aLength);

      double updatedLength = 4;
      newPackage.itemLength = updatedLength;

      Assert.AreEqual(updatedLength, newPackage.itemLength);
    }
  }
}