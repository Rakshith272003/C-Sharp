namespace CalculatorApp.Services
{
    public class CalculatorService
    {
        public static void Run()
        {
            while (true)
            {
                try
                {
                    MenuService.ShowMenu();
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1: BinaryOperationsService.HandleOperation(1); break;
                        case 2: BinaryOperationsService.HandleOperation(2); break;
                        case 3: BinaryOperationsService.HandleOperation(3); break;
                        case 4: BinaryOperationsService.HandleOperation(4); break;
                        case 5: BinaryOperationsService.HandleOperation(5); break;
                        case 6: InterestService.CalculateSimpleInterest(); break;
                        case 7: InterestService.CalculateCompoundInterest(); break;
                        case 8:
                            Console.WriteLine("Exiting...");
                            return;
                        default:
                            Console.WriteLine("Invalid choice! Please choose from 1 to 8.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine(" Please enter valid numeric input.");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($" Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"?? Unexpected error: {ex.Message}");
                }
            }
        }
    }
}
