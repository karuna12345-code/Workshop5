namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();

            // Calling overloaded methods
            printer.Print("Hello World");
            printer.Print(123);
            printer.Print("ChatGPT Rocks!", 3);
        }
    }
}
