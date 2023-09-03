class Calculator
{
    public static int Factorial(int number)
    {
        int factorial = 1;

        if (number >= 2)
        {
            for (int i = 2; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
        else if (number < 0)
        {
            throw new Exception("Number not suitable.");
        }
        else
        {
            return 1;
        }
    }

    public static double Power(int baseNum, int exponent)
    {
        if (exponent > 1)
        {
            for(int i = 1; i < exponent; i++)
            {
                baseNum *= baseNum;
            }
            return baseNum;
        }
        else if (exponent == 0)
        {
            return 1;
        }
        else
        {
            exponent = -exponent;
            for (int i = 1; i < exponent; i++)
            {
                baseNum *= baseNum;
            }
            return 1.0/baseNum;
        }
    }
}