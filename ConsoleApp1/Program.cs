namespace DesicionMaking
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Hello New User");
            Console.WriteLine("Create your user name");
            string userName = Console.ReadLine();
            Console.WriteLine("Create your password");
            string passWord = Console.ReadLine();

            if (userName == "" || passWord == "")
            {
                Console.WriteLine("your username or password is invalid");
            }
            else
            {
                Console.WriteLine("Successful registration - please, log in");
                Console.WriteLine("Insert Your User Name");
                string userNameRegister = Console.ReadLine();
                Console.WriteLine("Insert your password");
                string passWordRegister = Console.ReadLine();

                if (passWordRegister == passWord &&  userNameRegister == userName)
                {
                    Console.WriteLine("Welcome " + userName);
                }
                else
                {
                    Console.WriteLine("Your user name or password is incorrect");
                }

            }

        }
    }
}