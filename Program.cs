namespace PasswordControl;

class Program
{
    static void Main(string[] args)
    {
        // Kontrollera lösenordsstyrka
        // Skapa en konsolapp som kontrollerar styrkan på ett lösenord som användaren har angett. Den här appen bör bedöma lösenordets styrka baserat på olika kriterier som längd, närvaro av specialtecken och siffror. Den introducerar strängmanipulation, if-else-satser och loopar.

        // Instruktioner:
        // Be användaren att ange ett lösenord.
        Console.WriteLine("Please enter a password:");
        string userPassword = Console.ReadLine()!;

        // Ge feedback om lösenordet är "Svagt", "Moderat" eller "Starkt" 
        // baserat på dessa kontroller.
        int passwordStrength = 0;

        // Använd en rad villkor för att kontrollera:

        // Innehåller minst ett specialtecken.
        if (userPassword.Any(char.IsSymbol))
        {
            passwordStrength++;
        }
        // Lösenordets längd (bör vara minst 8 tecken).
        int passwordLength = userPassword.Length;
        if (passwordLength >= 8)
        {
            passwordStrength++;
        }
        // Innehåller både stora och små bokstäver.
        if (userPassword.Any(char.IsUpper))
        {
            passwordStrength++;
        }
        // Innehåller minst ett nummer.
        if (userPassword.Any(char.IsDigit))
        {
            passwordStrength++;
        }
        // Ge feedback om lösenordet är "Svagt", "Moderat" eller "Starkt" baserat på dessa kontroller.
        
        switch(passwordStrength)
        {
            case 2 or 3:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Your password is moderate!");
                break;

            case 4:
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Your password is strong!");
                break;

            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your password is weak!");
                break;
        }

    }
}
