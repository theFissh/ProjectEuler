namespace Mathematics;

public static partial class Mathf
{
    /// <summary>
    /// Return true if the number is even.
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public static bool IsEven(this int number)
    {
        return number % 2 == 0 ? true : false;
    }
}
