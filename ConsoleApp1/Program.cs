namespace DesicionMaking
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("How is the temperature");
            string temperature = Console.ReadLine();
            int numericTemperature;

            int number;
            if (int.TryParse(temperature, out number))
            {
                numericTemperature = number;
            }
            else
            {
                numericTemperature = 0;
                Console.WriteLine("you did not enter a valid number; the default temperature is set to 0. ");
            }
    
            if (numericTemperature <= 10)
            {
                Console.WriteLine("You Need a Coat, la temperatura es de " + numericTemperature);
            }
            else if (numericTemperature > 10 && numericTemperature < 20)
            {
                Console.WriteLine("It's a good weather, la temperatura es de " + numericTemperature);
            }
            else { Console.WriteLine("it's so Hot, la temperatura es de " + numericTemperature);
            }
       

        }
    }
}