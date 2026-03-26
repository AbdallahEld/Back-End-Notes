
# double & float Special Values

in C# Theres Special Values you can store in these two Data Types like Infinity and NaN

```
double x = double.NaN;
double y = double.PositiveInfinity;
double z = double.NegativeInfinity;
```

## NaN

Stand For **Not A Number**

```
double x = 0.0 / 0.0;  // NaN
double y = Math.Sqrt(-1); // NaN
```

**Note** : NaN doesnt Equal NaN

```
Console.WriteLine(double.NaN == double.NaN); // False ❗
```

## Infinity

There are Two Types Of Infinity

```
double.PositiveInfinity
double.NegativeInfinity
```

## Why We Have Them ?

So Instead of your program Throwing Exception it return Special value a value both ur C# and CPU can understand since both follow the Standard **IEEE 754**

It Could be useful in Projects That require Mathmatical Computations Like :

- Scientfic Apps
- Game Engines

