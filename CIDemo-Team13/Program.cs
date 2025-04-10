using CIDemo_Team13;

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
        bool exit = false;

        Console.WriteLine("Velkommen til lommeregneren! 😊");
        Console.WriteLine("Den her gang virker det");

        while (!exit)
        {
            Console.WriteLine("Vælg en operation:");
            Console.WriteLine("1. Add (Addition)");
            Console.WriteLine("2. Subtract (Subtraktion)");
            Console.WriteLine("3. Multiply (Multiplikation)");
            Console.WriteLine("4. Divide (Division)");
            Console.WriteLine("5. Power (Potens)");
            Console.WriteLine("6. SquareRoot (Kvadratrod)");
            Console.WriteLine("7. Exit (Afslut)");
            Console.Write("Indtast dit valg: ");

            string choice = Console.ReadLine();

            try
            {
                switch (choice)
                {
                    case "1":
                        Console.Write("Indtast første tal: ");
                        int addA = int.Parse(Console.ReadLine());
                        Console.Write("Indtast andet tal: ");
                        int addB = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Resultat: {calculator.Add(addA, addB)}");
                        break;

                    case "2":
                        Console.Write("Indtast første tal: ");
                        int subA = int.Parse(Console.ReadLine());
                        Console.Write("Indtast andet tal: ");
                        int subB = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Resultat: {calculator.Subtract(subA, subB)}");
                        break;

                    case "3":
                        Console.Write("Indtast første tal: ");
                        int mulA = int.Parse(Console.ReadLine());
                        Console.Write("Indtast andet tal: ");
                        int mulB = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Resultat: {calculator.Multiply(mulA, mulB)}");
                        break;

                    case "4":
                        Console.Write("Indtast første tal: ");
                        int divA = int.Parse(Console.ReadLine());
                        Console.Write("Indtast andet tal: ");
                        int divB = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Resultat: {calculator.Divide(divA, divB)}");
                        break;

                    case "5":
                        Console.Write("Indtast basen: ");
                        double baseNum = double.Parse(Console.ReadLine());
                        Console.Write("Indtast eksponenten: ");
                        double exponent = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Resultat: {calculator.Power(baseNum, exponent)}");
                        break;

                    case "6":
                        Console.Write("Indtast tallet: ");
                        double sqrtNum = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Resultat: {calculator.SquareRoot(sqrtNum)}");
                        break;

                    case "7":
                        exit = true;
                        Console.WriteLine("Afslutter programmet...");
                        break;

                    default:
                        Console.WriteLine("Ugyldigt valg. Prøv igen.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fejl: {ex.Message}");
            }

            Console.WriteLine();
        }
    }
}
 

