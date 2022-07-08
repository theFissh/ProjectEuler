# Project Euler

Project Euler is a series of challenging problems that require mathematical and programming skills. Somebody who enjoys learning new area of mathematics, project Euler is going to be a fun journey.

I encourage you try solve as much problems as you can, and not see any answer in the notebooks, however, they are here, in case you are having trouble finding a solution, the notebooks also include an explanation in how I found the answers I've found.

Here is the answer to the first problem: (spoiler)

<details>
    <summary> Solution to problem 001 </summary>
    Multiples of 3 or 5
    If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    Find the sum of all the multiples of 3 or 5 below 1000.

   ```c#
   List<int> Multiples = new();
    for (int i = 0; i < 1000; i++)
        if ((i % 3 == 0) | (i % 5 == 0))
            Multiples.Add(i);
    Console.WriteLine(Multiples.Sum());
   ```

Output

```text
233168
```

</details>

 The [notebook 1](Problems(000-100)/Problems(000-100).ipynb) contains not only the answer, but the explanation of how to solve problem itself.

---

## Probems, problems everywhere

A list of all the problems can be found [here](https://projecteuler.net/archives).

The first [notebook](Problems(000-100)/Problems(000-100).ipynb) contains the problems 000 to 100 as it' name suggest, problems are called according to they's respective number according to [the project euler project](https://projecteuler.net/) and **not in the order I've solved it**, so that means, if i try to solve the [problem 105](https://projecteuler.net/problem=105) ["Special subset sums: testing"](<https://projecteuler.net/problem=105>) it belongs to the [notebook 2](Problems(101-200)/Problems(101-200).ipynb), which is currently empty atm, and was created only for the propose of this explanation.
