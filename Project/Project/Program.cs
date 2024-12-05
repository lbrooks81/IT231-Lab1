namespace Project
{
    public class Program
    {
        public static void Main()
        {
            int num1 = 0;
            int num2 = 0;

            Console.Write("Enter an integer: ");

            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.Write("Incorrect type, please enter an integer: ");
            }

            Console.Write("Enter another integer: ");

            while (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.Write("Incorrect type, please enter an integer: ");
            }

            DoMath(num1, num2);
        }

        public static void DoMath(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }
    }
}
