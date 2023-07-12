using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter patient information:");
        Console.Write("First Name: ");
        string firstName = Console.ReadLine();
        Console.Write("Last Name: ");
        string lastName = Console.ReadLine();
        Console.Write("Weight (KG): ");
        double weight = Convert.ToDouble(Console.ReadLine());
        Console.Write("Height (CM): ");
        double height = Convert.ToDouble(Console.ReadLine());

        Patient patient = new Patient(firstName, lastName, weight, height);
        patient.PrintPatientInfo();
    }
}
