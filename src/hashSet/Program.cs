// See https://aka.ms/new-console-template for more information
HashSet<int> hs1 = new HashSet<int>();
for (int i = 1; i <= 10; i++) {
  hs1.Add(i);
}
foreach (var item in hs1) {
  Console.WriteLine(item);
}
