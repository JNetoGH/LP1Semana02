using System;

namespace ManipulaVar {
    
    class Program {
        
        static void Main(string[] args) {

            try {
                int value = int.Parse(args[0]);
                int copy1 = value;
                copy1++;
                Console.WriteLine($"x++: {copy1}");
            }
            catch (FormatException e) {
                Console.WriteLine("args[0] is not a valid integer number");
            }

        }
    }
}