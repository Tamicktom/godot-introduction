


namespace Game.Entities;

public class Conversor
{
  public static int ToInt(string value)
  {
    return int.Parse(value);
  }

  public static int SafeToInt(string value)
  {
    // if conversion fails, return 0
    if (int.TryParse(value, out int result))
    {
      return result;
    }
    return 0;
  }
}