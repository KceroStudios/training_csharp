namespace DesicionMaking
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("How is the temperature");
            string temperature = Console.ReadLine();

            int numericTemperature = int.Parse(temperature);
    
            if (numericTemperature <= 10)
            {
                Console.WriteLine("You Need a Coat, la temperatura es de " + numericTemperature);
            }
            if (numericTemperature > 10 && numericTemperature < 20)
            {
                Console.WriteLine("It's a good weather, la temperatura es de " + numericTemperature);
            }
            else { Console.WriteLine("it's so Hot, la temperatura es de " + numericTemperature);
            }
       

        }
    }
}