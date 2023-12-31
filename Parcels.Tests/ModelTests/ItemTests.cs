using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Parcels.Models;
using System;

namespace Parcels.Tests
{
  [TestClass]
  public class ItemTests : IDisposable
  {
    public void Dispose()
    {
      Item.ClearAll();
    }

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
      Assert.AreEqual(aWeight, newItem.ItemWeight);
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
      newItem.ItemWeight = updatedWeight;
      //Assert
      Assert.AreEqual(updatedWeight, newItem.ItemWeight);
    }

    [TestMethod]
    public void GetLength_ReturnsLength_Double()
    {
      double aWeight = 1;
      double aLength = 2;
      double aWidth = 3;
      double aHeight = 4;
      Item newItem = new Item(aWeight, aLength, aWidth, aHeight);
      Assert.AreEqual(aLength, newItem.ItemLength);
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
      newItem.ItemLength = updatedLength;

      Assert.AreEqual(updatedLength, newItem.ItemLength);
    }

    [TestMethod]
    public void GetWidth_ReturnsWidth_Double()
    {
      double aWeight = 1;
      double aLength = 2;
      double aWidth = 3;
      double aHeight = 4;
      Item newItem = new Item(aWeight, aLength, aWidth, aHeight);
      Assert.AreEqual(aWidth, newItem.ItemWidth);
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
      newItem.ItemWidth = updatedWidth;

      Assert.AreEqual(updatedWidth, newItem.ItemWidth);
    }

    [TestMethod]
    public void GetHeight_ReturnsHeight_Double()
    {
      double aWeight = 1;
      double aLength = 2;
      double aWidth = 3;
      double aHeight = 4;
      Item newItem = new Item(aWeight, aLength, aWidth, aHeight);

      Assert.AreEqual(aHeight, newItem.ItemHeight);
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
      newItem.ItemHeight = updatedHeight;

      Assert.AreEqual(updatedHeight, newItem.ItemHeight);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_ItemList()
    {
      List<Item> packagesList = new List<Item> { };
      List<Item> result = Item.GetAll();
      CollectionAssert.AreEqual(packagesList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsItemList_ItemList()
    {
      double aWeight1 = 1;
      double aLength1 = 2;
      double aWidth1 = 3;
      double aHeight1 = 4;
      Item newItem1 = new Item(aWeight1, aLength1, aWidth1, aHeight1);      
      double aWeight2 = 11;
      double aLength2 = 22;
      double aWidth2 = 33;
      double aHeight2 = 44;
      Item newItem2 = new Item(aWeight2, aLength2, aWidth2, aHeight2);

      List<Item> shippingItemList = new List<Item> { newItem1, newItem2 };
      List<Item> result = Item.GetAll();
      
      CollectionAssert.AreEqual(shippingItemList, result);
    }

    [TestMethod]
    public void GetItemVolume_ReturnsItemVolume_Double()
    {
      double aWeight1 = 1;
      double aLength1 = 2;
      double aWidth1 = 3;
      double aHeight1 = 4;
      double aVolume = 24;
      Item newItem1 = new Item(aWeight1, aLength1, aWidth1, aHeight1, aVolume);

      Assert.AreEqual(aVolume, newItem1.ItemVolume);
    }

    [TestMethod]
    public void SetItemVolume_SetsItemVolumeValue_Void()
    {
      double aWeight1 = 1;
      double aLength1 = 2;
      double aWidth1 = 3;
      double aHeight1 = 4;
      Item newItem1 = new Item(aWeight1, aLength1, aWidth1, aHeight1);

      double setVolume = 24;
      newItem1.ItemVolume = setVolume;
      Assert.AreEqual(setVolume, newItem1.ItemVolume);
    }

    [TestMethod]
    public void CalculateVolume_ReturnsItemVolume_Double()
    {
      double aWeight1 = 1;
      double aLength1 = 2;
      double aWidth1 = 3;
      double aHeight1 = 4;
      Item newItem1 = new Item(aWeight1, aLength1, aWidth1, aHeight1);

      double expectedVolumeResult = 24;
      newItem1.CalculateVolume();
      Assert.AreEqual(expectedVolumeResult, newItem1.ItemVolume);
    }

    [TestMethod]
    public void GetItemCostToShip_ReturnsItemCost_Double()
    {
      double aWeight1 = 1;
      double aLength1 = 2;
      double aWidth1 = 3;
      double aHeight1 = 4;
      double aVolume = 24;
      double aCost = 12;
      Item newItem1 = new Item(aWeight1, aLength1, aWidth1, aHeight1, aVolume, aCost);

      Assert.AreEqual(aCost, newItem1.ItemCost);
    }

    [TestMethod]
    public void SetItemCostToShip_SetsItemCost_Void()
    {
      double aWeight1 = 1;
      double aLength1 = 2;
      double aWidth1 = 3;
      double aHeight1 = 4;
      double aVolume = 24;
      double aCost = 12;
      Item newItem1 = new Item(aWeight1, aLength1, aWidth1, aHeight1, aVolume, aCost);

      double setCost = 123;
      newItem1.ItemCost = setCost;
      Assert.AreEqual(setCost, newItem1.ItemCost);
    }

    [TestMethod]
    public void CalculateCost_ReturnsItemCostToShip_Void()
    {
      double aWeight1 = 1;
      double aLength1 = 2;
      double aWidth1 = 3;
      double aHeight1 = 4;
      double aVolume1 = 24;
      Item newItem1 = new Item(aWeight1, aLength1, aWidth1, aHeight1, aVolume1);

      double expectedCost = 12;
      newItem1.CalculateVolume();
      newItem1.CalculateCost();
      Assert.AreEqual(expectedCost, newItem1.ItemCost);
    }

  }
}