namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(Add(2, 5));

            // Console.WriteLine(Add(2.1, 3.4));

            Console.WriteLine(Add(3, 1, true));
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static string Add(int num1, int num2, bool isCheck)
        {
            var sum = num1 + num2;

            if (isCheck == true && sum >1)
            {
                return $"{sum} dollars";
            }

            else if(isCheck == true && sum == 1)
            {
                return $"{sum} dollar";
            }

            else if(isCheck == true && sum <1)
            {
                return $"{sum} dollars";
            }

            else
            {
                return sum.ToString();
            }
        }
    }
}
