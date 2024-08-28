Calculadora calc = new Calculadora();
Console.WriteLine($"Informe o valor de X");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Informe o valor de y: ");
double y = Convert.ToDouble(Console.ReadLine());

double resultado = calc.Soma(x, y);

Console.WriteLine($"A soma de {x} + {y} é igual a: {resultado}");

Console.WriteLine($"O resultado da subtração é: {calc.Subtracao(x,y)}");

Console.WriteLine($"O resultado da multiplicação é: {calc.Multiplicar(x,y)}");

Console.WriteLine($"O resultado da divisão é: {calc.Dividir(x,y)}");
