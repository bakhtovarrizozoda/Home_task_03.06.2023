using System;
var list = new List<Task>();
list.Add(CountUpAsync());
list.Add(CountDownAsync());
await Task.WhenAll(list);

async Task CountDownAsync()
{
    for(int i=10; i>=1; i--)
    {
        Console.WriteLine(($"Timer #1 : {i} seconds"));
        await Task.Delay(1000);
    }
    Console.WriteLine(($"Timer #1 is completed")); 
}
async Task CountUpAsync()
{
    for(int i=1; i<=10; i++)
    {
        Console.WriteLine(($"Timer #2 : {i} seconds"));
        await Task.Delay(1000);
    }
    Console.WriteLine(($"Timer #2 is completed")); 
}