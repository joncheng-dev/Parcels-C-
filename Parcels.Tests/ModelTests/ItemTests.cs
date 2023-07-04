using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Parcels.Models;
using System;

namespace Parcels.Tests
{
  [TestClass]
  public class ItemTests
  {
    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      double aWeight = 1;
      double aLength = 2;
      double aWidth = 3;
      double aHeight = 4;
      Item newItem = new Item(aWeight, aLength, aWidth, aHeight);
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }

    [TestMethod]
    public void GetWeight_ReturnsWeight_Double()
    {
      double aWeight = 1;
      double aLength = 2;
      double aWidth = 3;
      double aHeight = 4;
      Item newItem = new Item(aWeight, aLength, aWidth, aHeight);
      Assert.AreEqual(aWeight, newItem.itemWeight);
    }

    [TestMethod]
    public void SetWeight_SetsValueOfWeight_Double()
    {
      //Arrange
      double aWeight = 1;
      double aLength = 2;
      double aWidth = 3;
      double aHeight = 4;
      Item newItem = new Item(aWeight, aLength, aWidth, aHeight);
      //Act
      double updatedWeight = 2;
      newItem.itemWeight = updatedWeight;
      //Assert
      Assert.AreEqual(updatedWeight, newItem.itemWeight);
    }

    [TestMethod]
    public void GetLength_ReturnsLength_Double()
    {
      double aWeight = 1;
      double aLength = 2;
      double aWidth = 3;
      double aHeight = 4;
      Item newItem = new Item(aWeight, aLength, aWidth, aHeight);
      Assert.AreEqual(aLength, newItem.itemLength);
    }

    [TestMethod]
    public void SetLength_SetsValueOfLength_Double()
    {
      double aWeight = 1;
      double aLength = 2;
      double aWidth = 3;
      double aHeight = 4;
      Item newItem = new Item(aWeight, aLength, aWidth, aHeight);

      double updatedLength = 4;
      newItem.itemLength = updatedLength;

      Assert.AreEqual(updatedLength, newItem.itemLength);
    }

    [TestMethod]
    public void GetWidth_ReturnsWidth_Double()
    {
      double aWeight = 1;
      double aLength = 2;
      double aWidth = 3;
      double aHeight = 4;
      Item newItem = new Item(aWeight, aLength, aWidth, aHeight);
      Assert.AreEqual(aWidth, newItem.itemWidth);
    }

    [TestMethod]
    public void SetWidth_SetsValueOfWidth_Double()
    {
      double aWeight = 1;
      double aLength = 2;
      double aWidth = 3;
      double aHeight = 4;
      Item newItem = new Item(aWeight, aLength, aWidth, aHeight);

      double updatedWidth = 40;
      newItem.itemWidth = updatedWidth;

      Assert.AreEqual(updatedWidth, newItem.itemWidth);
    }

    [TestMethod]
    public void GetHeight_ReturnsHeight_Double()
    {
      double aWeight = 1;
      double aLength = 2;
      double aWidth = 3;
      double aHeight = 4;
      Item newItem = new Item(aWeight, aLength, aWidth, aHeight);

      Assert.AreEqual(aHeight, newItem.itemHeight);
    }

    [TestMethod]
    public void SetHeight_SetsValueOfHeight_Double()
    {
      double aWeight = 1;
      double aLength = 2;
      double aWidth = 3;
      double aHeight = 4;
      Item newItem = new Item(aWeight, aLength, aWidth, aHeight);

      double updatedHeight = 40;
      newItem.itemHeight = updatedHeight;

      Assert.AreEqual(updatedHeight, newItem.itemHeight);
    }
  }
}