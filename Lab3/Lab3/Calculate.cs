using System;
using System.Collections.Generic;

namespace Lab3
{
  class Calculate
  {
    public static double Calc(double x, double step, double left, double right, double a, List<string> list)
    {
      double y = 0;
      try
      {
          y = x * Math.Sqrt((a + x) / (a - x));
      }
      catch{}
      return y;
    }
  }
}
