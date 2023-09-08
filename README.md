API REST usando C# .NET 7.

FibonacciController.cs
The FibonacciController.cs document contains the get action that is called in the api to orchestrate the logic with its return of the object with the index and its value.

URL https://localhost:7254/swagger/index.html

ServiceFiboIndex.cs
This file gives the logic to get the number in sequence with the index, basically if the index is 0 or 1 the function returns the same number and if it is 2 the function returns 1. If the index is greater we can calculate the number by simply adding the first two numbers we do this in a for loop starting at index 3 which is the number we start calculating until we reach the desired index we add the first two numbers (index 1 and index 2 in this example) we continue from there and when we reach the desired index , we return the calculated value and index. 
I decided to implement some conditionals so that the functionality works correctly.

the idea was to deliver a modularized code for future changes and for maintenance it is more understandable and also for unit tests it is much simpler.
TEST 
RESULTADO {
  "index": 6,
  "value": 8
}
