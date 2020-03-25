using System;
using System.Collections.Generic;

namespace Lab3
{
  public class Calculate
  {
    public static List<string> Calc(double step, double left, double right, double a, List<string> list)
    {
      double y = 0;
      try
      {
        for (double i = left; i < right; i = i + step)
        {
          y = i * Math.Sqrt((a + i) / (a - i));
          list.Add(Math.Round(Math.Abs(y), 3).ToString());
        }
      }
      catch { }
      return list;
    }
  }
}
