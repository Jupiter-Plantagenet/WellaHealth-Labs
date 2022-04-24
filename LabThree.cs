// See https://aka.ms/new-console-template for more information
class LabThree
{
    public static void Main(string[] args)
    {
       Console.WriteLine("Enter number");
        string numOne = Console.ReadLine();
       
        int number = int.Parse(numOne);
        int zoar = 2;
        string result = "Prime Number";

        while ( zoar <= number/2){
            int remainder = number % zoar;
            if (remainder != 0){
                zoar += 1;
            }else{
                result = "Not Prime Number";
                break;
            }
        Console.WriteLine(result);

        }
    }
}
