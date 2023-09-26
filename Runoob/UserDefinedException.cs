using System;

namespace UserDefinedException
{
    class TestTemperature
    {
        public static void Main(string[] args)
        {
            Temperature temp = new Temperature();
            try
            {
                temp.showTemp();
            }
            catch (TemIsZeroException e)
            {
                Console.WriteLine("TemIsZeroException:{0}",e.Message);
            }
        }
    }
}

public class TemIsZeroException : ApplicationException
{
    public TemIsZeroException(string message) : base(message)
    {
    }
}

public class Temperature
{
    private int temperature = 0;

    public void showTemp()
    {
        if (temperature == 0)
        {
            throw (new TemIsZeroException("Zero Temperature found"));
        }
        else
        {
            Console.WriteLine("Temperature:{0}",temperature);
        }
    }
}
