namespace MathHelper;

public class MathHelper
{
    public double Summ(double value1, double value2)
    {
        return value1 + value2;
    }

    public int Summ(int value1, int value2)
    {
        return value1 + value2;
    }

    public double Subtract(double value1, double value2)
    {
        return value1 - value2;
    }

    public int Subtract(int value1, int value2)
    {
        return value1 - value2;
    }
    public double Multiply(double value1, double value2)
    {
        return value1 * value2;
    }

    public int Multiply(int value1, int value2)
    {
        return value1 * value2;
    }
    public double Divide(double value1, double value2)
    {
        if (value2 == 0)
        {
            throw new DivideByZeroException("Деление на ноль недопустимо");
        }

        return value1 / value2;
    }

    public int Divide(int value1, int value2)
    {
        if (value2 == 0)
        {
            throw new DivideByZeroException("Деление на ноль недопустимо");
        }

        return value1 / value2;
    }


}
