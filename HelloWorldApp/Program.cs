
using HelloWorldApp;

Console.WriteLine("Hello, World!");
Console.WriteLine("HI!");

var provider = new LocalDateTimeProvider();
Console.WriteLine($"Current Date and Time: {provider.GetCurrentDateTime()}");

var luckynumberProvider = new RandomNumberProvider();
Console.WriteLine($"Your lucky number is: {luckynumberProvider.GetLuckyNumber()}");