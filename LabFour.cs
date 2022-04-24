// See https://aka.ms/new-console-template for more information
class LabFour
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter first number");
        string numOne = Console.ReadLine();
       
       Console.WriteLine("Enter second number");
       string numTwo = Console.ReadLine();

        int firstNum = int.Parse(numOne);
        int secondNum = int.Parse(numTwo);


        if (firstNum + secondNum < 100){
            Console.WriteLine("true");

        }else {
            Console.WriteLine("false");
        }

    
    }

}
