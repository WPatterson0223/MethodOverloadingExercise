namespace MethodOverloading
{
    public class Program
    {
        static int Add(int x, int y)
        {
            return x + y;
        }

        static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

        static string Add(int x, int y, bool z)
        {
            if (z == true)
            {
                if (x + y == 1 && x + y == -1)
                {
                    return $"{x + y} dollar";
                }
                else
                {
                    return $"{x + y} dollars";
                }
            }
            else
            {
                return "You have no money:)";
            }
        }



        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 2)); 
            Console.WriteLine(Add(1.1m, 1.1m)); 
            Console.WriteLine(Add(1, 2, true)); 
            Console.WriteLine(Add(1, 2, false)); 
        }
    }
}
