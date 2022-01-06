
# How-Many-Numbers

We want to generate all the numbers of three digits where:

 - The sum of their digits is equal to 10.
 
 - Their digits are in increasing order (the numbers may have two or more equal contiguous digits)

The numbers that fulfill the two above constraints are:  `118, 127, 136, 145, 226, 235, 244, 334`

<br>

Make a function that receives two arguments: `118, 127, 136, 145, 226, 235, 244, 334`

 - The sum of digits value
 
 - The desired number of digits for the numbers

<br>

The function should output an array with three values:   

 1. The total number of possible numbers
 
 2. The minimum number
 
 3. The maximum number


## Examples

The example given above should be:
```csharp
HowManyNumbers.FindAll(10, 3) == [8, 118, 334]   // as List<Integer>
```

<br>

If we have only one possible number as a solution, it should output a result like the one below:
```csharp
HowManyNumbers.FindAll(27, 3) == [1, 999, 999]
```

<br>

If there are no possible numbers, the function should output the empty array.
```csharp
HowManyNumbers.FindAll(84, 4) == []
```

<br>

The number of solutions climbs up when the number of digits increases.
```csharp
HowManyNumbers.FindAll(35, 6) == [123, 116999, 566666]
```

## Attention

-   Number of tests:  `112`
-   Sum of digits value between  `20`  and  `65`
-   Amount of digits between  `2`  and  `17`

You have a limit of 12 seconds, you cannot use Nuget packages
