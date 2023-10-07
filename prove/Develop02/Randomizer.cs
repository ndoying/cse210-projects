using System;

public class Randomizer
{
    //Generate a random number between 0 and 6
    Random _random = new Random();
    public int CreateRandomNumber(int minValue, int maxValue)
    {
        int _randomNumber = _random.Next(minValue, maxValue);
        return _randomNumber;
    }

}