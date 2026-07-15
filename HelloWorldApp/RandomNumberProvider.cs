
using System.Security.Cryptography;

public class RandomNumberProvider
{
    public RandomNumberProvider()
    {
    }

    public string GetLuckyNumber()
    {
        var randomNumber = RandomNumberGenerator.GetInt32(1, 11);
        return randomNumber.ToString();
    }
}