namespace L12_Unit_tests;

public static class Kalkulacka
{
    public static double Secti(double x, double y)
    {
        return (x + y);
    }

    public static double Vydel(double x, double y)
    {
        // Divide by zero is thrown only when dividing integers.
        // In case of 'double' numbers the Infinity is returned, so we have to handle it manually if needed.
        if (y == 0)
        {
            throw new DivideByZeroException();
        }

        return (x / y);
    }
}
