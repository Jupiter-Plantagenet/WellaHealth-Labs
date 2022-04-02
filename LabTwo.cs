// See https://aka.ms/new-console-template for more information
class LabTwo
{
    public static void Main(string[] args)
    {
        //Declaration of ten different variables with ten different data types
        string nameOfContact;
        int numOfChildren;
        char alphaNumeric;
        float weight;
        long milliseconds;
        bool isVisible;
        short numOfTrains;
        byte totalSpent;
        ushort temperature;
        double distanceFromTheSun;

        //Implicit type Conversion
        numOfChildren = 7;
        milliseconds = numOfChildren;
        Console.WriteLine(milliseconds);

        //Explicit type Conversion
        distanceFromTheSun = 149.5e6d;
        milliseconds = (long)distanceFromTheSun;
        Console.WriteLine(milliseconds);
    }
}
