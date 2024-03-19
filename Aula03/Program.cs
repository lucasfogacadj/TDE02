// See https://aka.ms/new-console-template for more information
// int idade = 25;
// string nome = "Maria";

// Escreve na mesma linha
// Console.Write(nome);
// Console.Write(" tem ");
// Console.Write(idade);
// Console.Write(" anos");

//usar concatenação de string +
// Console.WriteLine(nome + " tem " + idade + " anos");

// //usar a interpolação de strings
// Console.WriteLine($"{nome} tem {idade} anos");

// //usar Place Holders
// Console.WriteLine("{0} tem {1} anos", nome, idade);

// string local = "c:\\dados\\poesia.txt";
// string frase = "Ele falou: \"Não fui eu\"";
// string pizza = "\nPizza \nde \nMussarela";

// Console.WriteLine(local);
// Console.WriteLine(frase);
// Console.WriteLine(pizza);

//Conversões de tipos
// int varInt = 100;
// double varDouble = varInt;

// //int -> 4 bytes
// //double -> 8 bytes

// Console.WriteLine(varDouble);

// double varDouble = 12.456; 
// int varInt = (int) varDouble;
//Console.WriteLine(varInt);


// int num1 = 10;
// int num2 = 4;

// float resultado = (float) num1 / num2;
// Console.WriteLine(resultado);

// int varInt = 123;
// double varDouble = 12.45;
// decimal varDecimal = 12.45678m;

// string s1 = varInt.ToString();
// string s2 = varDouble.ToString();
// string s3 = varDecimal.ToString();

// Console.WriteLine(s1);
// Console.WriteLine(s2);
// Console.WriteLine(s3);

//conversões usando a classe convert

// int valorInt = 10;
// double valorDouble = 5.35;
// bool valorBool = true;

// Console.WriteLine(Convert.ToString(valorInt));
// Console.WriteLine(Convert.ToDouble(valorInt));
// Console.WriteLine(Convert.ToString(valorBool));
// Console.WriteLine(Convert.ToInt32(valorDouble));

// Console.ReadKey();

// Console.WriteLine("Digite seu nome");

// string nome = Console.ReadLine();

// Console.WriteLine($"O seu nome é {nome}");

// Console.WriteLine("Informe sua idade");

// int idade = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Sua idade é: {idade}");

// Console.ReadKey();

//operadores binarios
// // + - * / %

// Console.WriteLine("Informe o valor de x");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Informe o valor de y");
// int y = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"A some de x + y = {x+y}");
// Console.WriteLine($"A subtração de x - y = {x-y}");
// double divisao = (double) x/y;
// Console.WriteLine($"A divisão de x / y = {divisao}");
// Console.WriteLine($"A multiplicação de x * y = {x*y}");

// Console.WriteLine($"Raiz quadrada de x = {Math.Sqrt(x)}");
// Console.WriteLine($"Valor de x elevado a y {Math.Pow(x, y)}");

// var z = 10;
// var nome2 = "Lucas";

// var teste;

//operador ternario

Console.WriteLine("Informe a temperatura");
var temp = Convert.ToDouble(Console.ReadLine());

var resultado = temp > 27 ? "Quente" : "Normal";


Console.WriteLine($"O tempo esta {resultado}");

