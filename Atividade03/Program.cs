string aluno;
double nota1, nota2, nota3, mediavar;

Console.WriteLine("Informe o nome do aluno:");
aluno = Console.ReadLine();

Console.WriteLine("Informe a primeira nota dele:");
nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("Informe a segunda nota dele:");
nota2 = double.Parse(Console.ReadLine());

Console.WriteLine("Informe a terceira nota dele:");
nota3 = double.Parse(Console.ReadLine());

mediavar = (nota1 + nota2 + nota3) / 3;
Console.WriteLine($"A média aritmética das notas do {aluno} é: {mediavar}");