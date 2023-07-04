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
      double someNumber = 1;
      Package newPackage = new Package(someNumber);
      Assert.AreEqual(typeof(Package), newPackage.GetType());
    }

    [TestMethod]
    public void GetWeight_ReturnsWeight_Double()
    {
      double aNumber = 1;
      Package newPackage = new Package(aNumber);
      Assert.AreEqual(aNumber, newPackage.Weight);
    }

    [TestMethod]
    public void SetWeight_SetsValueOfWeight_Double()
    {
      //Arrange
      double aNumber = 1;
      Package newPackage = new Package(aNumber);
      //Act
      double anotherNumber = 2;
      newPackage.Weight = anotherNumber;
      //Assert
      Assert.AreEqual(anotherNumber, newPackage.Weight);
    }
  }
}