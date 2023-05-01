using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class SumatorTest
{
  [TestMethod]
  public void SumTestTypicalCase()
  {
    int[] numbers = new int[] { 1, 2 };
    long expected = 3;
    long actual Sumator_Accessor.Sum(numbers)
    Assert.AreEQual(expected, actual);
  }

  [TestMethod]
  public void SumTestOverflow()
  {
    int[] numbers = new int[] { 2000000000, 2000000000 };
    long expected = 4000000000;
    long actual = Sumator_Accessor.Sum(numbers);
    Assert.AreEqual(expected, actual);
  }

  [TestMethod]
  [ExpectedException(typeof(NullReferenceException))]
  public void SumTestNullArray()
  {
    Sumator_Accessor.Sum(null);
  }
}
