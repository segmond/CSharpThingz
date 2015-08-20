using System;

public class CmdLine {
    static void Main(string[] args) {
        string name;

        Console.Write("Enter your name > ");
        name = Console.ReadLine();
        Console.Write("Hello {0}\n", name);

        if (args.Length == 0) {
            Console.WriteLine("You gave no arguments");
        } else {
            Console.WriteLine("Here are your arguments");
            for (int i = 0; i < args.Length; i++) {
                Console.WriteLine("{0}", args[i]);
            }
        }
    }
}
