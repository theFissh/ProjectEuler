// Problem 001
// * Solved!
List<int> Multiples = new();
for (int i = 0; i < 1000; i++)
    if ((i % 3 == 0) | (i % 5 == 0))
        Multiples.Add(i);
Console.WriteLine(Multiples.Sum());
