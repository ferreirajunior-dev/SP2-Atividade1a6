int opcao;
double usertemp, convcelsius1, convcelsius2;

Console.Write("Informe a seguir usando somente números, a temperatura em graus celsius que você deseja converter:");
usertemp = int.Parse(Console.ReadLine());

Console.WriteLine("1 - Fahrenheit");
Console.WriteLine("2 - Kelvin");
Console.Write("Informe para qual das unidades de temperatura acima deseja converter: ");
opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
    case 1: // fahrenheit
    convcelsius1 = (usertemp * 1.8) + 32;
    Console.WriteLine($"A conversão de {usertemp}°C é: {convcelsius1}°F");
    break;

    case 2: // kelvin
    convcelsius2 = usertemp + 273.15;
    Console.WriteLine($"A conversão de {usertemp}°C é: {convcelsius2}K");
    break;
}
