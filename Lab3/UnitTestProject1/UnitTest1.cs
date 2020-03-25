using System.Collections.Generic;
using System.Linq;
using Lab3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestMethod1()
    {
      List<string> listRes = new List<string>();
      string temp = "", tmp = ""; 
      List<string> listExp = new List<string>() { "0", "1,134", "1,155", "0,775", "0", "1,291", "3,464", "7,937" };
      listRes = Calculate.Calc(1, -4, 4, 4, listRes);
      for (int i = 0; i < 8; i++)
      {
        temp = listRes[i];
        tmp = listExp[i];
        Assert.AreEqual(temp, tmp);
      }
      //CollectionAssert.AreEqual(listRes, listExp);
    }

   [TestMethod]
    public void TestMethod2()
    {
      List<string> listRes = new List<string>();
      string temp = "", tmp = "";
      List<string> listExp = new List<string>() { "0", "0,283", "0,289", "0,194", "0", "0,323", "0,866", "1,984" };
      listRes = Calculate.Calc(0.25, -1, 1, 1, listRes);
      for (int i = 0; i < 8; i++)
      {
        temp = listRes[i];
        tmp = listExp[i];
        Assert.AreEqual(temp, tmp);
      }
    }
  }
}
