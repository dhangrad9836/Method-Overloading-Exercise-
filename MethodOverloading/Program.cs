namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 0, true));
            Console.WriteLine(Add(1,0, false));
            Console.WriteLine(Add(1.0M, 5.2M));

            Console.ReadLine();

        } //end of main method

        //overloaded add methods
        public static int Add(int num1, int num2)
        {
            //return the sum of both integers
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            //return the sum of both decimal
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool isTrue)
        {
            //return an int value if bool type is true
            if (isTrue == true)
            {
                //append word: dollar if total is equal to 1
                if (num2 + num1 == 1)
                {
                    return "1 dollar";
                }
                //append word: dollars if total is greater than 1
                else if (num1 + num2 > 1)
                {
                    return num1 + num2 + " dollars";
                }
            }
            //if false return "false"
            return "false";
            
            
        }
    }// end of Class
}
