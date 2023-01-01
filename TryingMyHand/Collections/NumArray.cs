namespace MoreLearning.Collections
{
    public class NumArray
    {
        public static void RunArray()
        {

            string answer = "1,2,3,4,5";
            int[] ints;


            var source = answer.Split(',');
            int[] cols = new int[source.Length];



            Console.WriteLine("Please come up with 5 numbers, separated by commas. Here is an example: 5,6,7,8");
            answer = Console.ReadLine();



            for (int i = 0; i < source.Length; i++)
            {
                cols[i] = int.Parse(source[i]);
            }

            int sum = cols[0] + cols[1] + cols[2] + cols[3] + cols[4];



            Console.WriteLine(sum);



            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to return to main menu");
            Console.ReadLine();



        }
    }
}
