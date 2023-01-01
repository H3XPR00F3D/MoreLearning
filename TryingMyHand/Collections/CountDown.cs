namespace MoreLearning.Collections
{
    public class CountDown
    {


        public static void Count()
        {


            string name;
            int age;
            UserPrompts.UserNameReq();
            name = Console.ReadLine();
            UserPrompts.UserAgeReq();
            age = Convert.ToInt32(Console.ReadLine());
            UserPrompts.CalcToHund(name, age);
            UserPrompts.ExitApp("");

        }

    }
}

