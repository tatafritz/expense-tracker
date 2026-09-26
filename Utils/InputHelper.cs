public class InputHelper
{
    public int IntInput (string message)
    {
        while (true)
        {    
            Console.Write(message);

            if (int.TryParse(Console.ReadLine(), out int userInput) && userInput > 0)
            {
                return userInput;
            } 
            
            Console.WriteLine("Please enter a valid number.");
        }
    }

    public decimal DecimalInput (string message)
    {
        while (true)
        {
            Console.Write(message);

            if (decimal.TryParse(Console.ReadLine(), out decimal userInput) && userInput > 0)
            {
                return userInput;
            }

            Console.WriteLine("Please enter a valid decimal number.");
        }
    }
}