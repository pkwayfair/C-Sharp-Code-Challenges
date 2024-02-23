using OODemo;

ArrayCodeChallenges arrayCodeChallenges = new ArrayCodeChallenges();
// pass an array to the function that returns the smallest 
// positive integer that is not present in the array


Console.WriteLine($"The smallest positive integer not present in the " +
    $"array is {arrayCodeChallenges.GetSmallestPositiveInteger([3, 6, 4, 8, 9, 6, 3, 2, 1])}");
