namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var num = 9; // declare and initialize it

            CheckNumber(num);

            Console.WriteLine($"Hej {AddName()}"); // Print out name of the user

            for (int i = 0; i < num; i++) { Console.WriteLine(i); } // Go through num varible and write out value

            Console.ReadKey();

        }
        static void CheckNumber(int num) // Method that take a int and check if its above/lower or equal to 10
        {
            if (num > 10)
            {
                Console.WriteLine($"Stort! {num} är större än 10");

            }
            else if (num == 10)
            {
                Console.WriteLine("Talen är like");
            }
            else
            {
                Console.WriteLine($"Oj lågt: {num} är mindre än {10}");
            }
        }
        static string AddName() // let user enter a name and returns it
        {
            Console.Write("Skriv in ditt namn: ");
            return Console.ReadLine();
        }
    }
}
