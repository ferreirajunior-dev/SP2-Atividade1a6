double num1, num2, num3, resultado, resultado1;

Console.WriteLine("A seguir, informe três números que serão usados para calcular a média aritmética deles:");
Console.Write("Informe o primeiro número: ");
num1 = double.Parse(Console.ReadLine());

Console.Write("Informe o segundo número: ");
num2 = double.Parse(Console.ReadLine());

Console.Write("Informe o terceiro número: ");
num3 = double.Parse(Console.ReadLine());

resultado = num1 + num2 + num3;
resultado1 = resultado / 3;
Console.WriteLine($"A soma dos três números é: {resultado}, e portanto, a média aritmética é: {resultado1}");