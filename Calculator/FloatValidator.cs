using System;

public class FloatValidator
{
    public bool TryParseFloat(string input, out float result)
    {
        return float.TryParse(input, out result);
    }
}
