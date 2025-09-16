namespace ChallengeLab4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IfNumberContains3());
        }

        //Actual method - not converting to other types
        public static bool IfNumberContains3()
        {
            Console.Write($"Enter a positive integer number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            bool contains3 = false;
            int currentInput = input;

            while (currentInput > 0)
            {
                int lastDigit = currentInput % 10;
                if (lastDigit == 3)
                {
                    contains3 = true;
                    break;
                }
                currentInput /= 10;
            }
            return contains3;
        }

            

        //Alternative method -  validating positive, integer number and converting to string
        public static bool IfNumberorStringContains3()
        {
            int i = GetPositiveIntegerInput();
            string si = i.ToString();
            bool contains3 = false;
            if(i != -1)
            {
                foreach (char c in si)
                {
                    if (c == '3')
                    {
                        contains3 = true;
                        break;
                    }
                }
            }
            else
            {
                Console.Write($"Invalid input!");
            }
            return contains3;
        }

        public static int GetPositiveIntegerInput()
        {
            Console.Write($"Enter a positive integer number: ");
            object input = Console.ReadLine() ?? "0" ;
            int i = Convert.ToInt32(input);

            if (IsInteger(input) && IsPositive(i))
            {
                return i;
            }
            else
            {
                return -1;
            }
        }

        public static bool IsInteger(object input)
        {
            int i;
            if (int.TryParse(input.ToString(), out i))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsPositive(int input)
        {
            if (input > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
