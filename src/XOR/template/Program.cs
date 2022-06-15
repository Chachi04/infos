using System;
using System.Collections.Generic;
using System.Linq;

public class Program {
  public static void Main() {
    int[] a = { 1, 2, 3, 4 };
    int[] b = { 3, 4, 5, 6 };
    Console.WriteLine("(" + string.Join(", ", XOR(a, b)) + ")");
  }

  private static int[] XOR(int[] a, int[] b) {
    int[] intersect = a.Intersect(b).ToArray();
    int[] union
    = a.Union(b).ToArray();
    int[] c = union
    .Select(x => x).Where(x => !intersect.Contains(x)).ToArray();
    return c;
  }
}
