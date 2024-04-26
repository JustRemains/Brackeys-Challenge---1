namespace Brackeys_Challenge___1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Wonderful adventure in Consolevania..

            Console.Title = "Text Adventure";

           
            Console.WriteLine("Hello Adventurer, welcome to the world of Consolevania\nDo you have a name?\n");

            Console.ForegroundColor = ConsoleColor.Green;

            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine();
            Console.WriteLine("Oh what a wonderful name!\nWhat brings you to Consolevania?\nvacation or adventure?\n");

            Console.ForegroundColor = ConsoleColor.Green;

            //Choice to be made

            if (Console.ReadLine() == "vacation")
            {
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("well.. if you haven't noticed there is alot of dangerous creatures around here!\n" +
                    "OH MY, BEHIND YOU!! A DRAGON!!!\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Before your vacation could even begin a dragons eats you");

                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Adventure!? That is great news there are many creatures to slay and quest to go on!\n" +
                                  "Let's get you sorted out... OH, BEHIND YOU! A DRAGON!!!!!!\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Before your adventure could even begin a dragons eats you");

                Console.ForegroundColor = ConsoleColor.White;
            }













        }
    }
}