namespace MoreLearning.Collections
{
    public class Fibo
    {


        public static void Sequence()
        {

            int fib1;
            int fib2;
            int seq;
            int time = 0;

            fib1 = 0;
            fib2 = 1;

            Console.WriteLine();
            Console.WriteLine("The first 10 numbers in the Fibonacci Sequence.");
            Console.WriteLine();

            while (time <= 0)
            {
                seq = fib1 + fib2;
                Console.WriteLine(seq);
                time++;
            }
            while (time <= 9 && time > 0)
            {
                seq = fib1 + fib2;
                Console.WriteLine(seq);
                time++;
                fib1 = fib2;
                fib2 = seq;
            }

            UserPrompts.ExitApp();
        }

    }
}
