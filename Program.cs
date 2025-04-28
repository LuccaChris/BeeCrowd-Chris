using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escolha o exercício (ex: 1001, 1002, etc.):");
        int escolha = int.Parse(Console.ReadLine());

        switch (escolha){

    
    


case 1000:
        Console.WriteLine("//1000// Hello World!");
        Console.WriteLine("Hello World!");
        break;
case 1001:
        Console.WriteLine("//1001// Input and Output 1");
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        int X = A + B;
        Console.WriteLine($"X = {X}");
        break;
case 1002:
        Console.WriteLine("//1002// Input and Output 2");
        int A2 = int.Parse(Console.ReadLine());
        int B2 = int.Parse(Console.ReadLine());
        double X2 = A2 / (double)B2;
        Console.WriteLine($"X = {X2:F2}");
        break;
case 1003:
        Console.WriteLine("//1003// Input and Output 3");
        int A3 = int.Parse(Console.ReadLine());
        int B3 = int.Parse(Console.ReadLine());
        int C3 = int.Parse(Console.ReadLine());
        double X3 = (A3 * B3) / (double)C3;
        Console.WriteLine($"X = {X3:F2}");
        break;
case 1004:
        Console.WriteLine("//1004// Input and Output 4");
         int A4 = int.Parse(Console.ReadLine());
         int B4 = int.Parse(Console.ReadLine());
         int C4 = int.Parse(Console.ReadLine());
         double X4 = (A4 * B4) / (double)C4;
         Console.WriteLine($"X = {X4:F2}");
        break;
case 1005:
        Console.WriteLine("//1005// Media 1 ");
         int A5 = int.Parse(Console.ReadLine());
         int B5 = int.Parse(Console.ReadLine());
        
         int X5 = A5 + B5;
         Console.WriteLine($"X = {X5}");
        break;
case 1006:
        Console.WriteLine("//1006// Media 2");
         float A6 = float.Parse(Console.ReadLine());
         float B6 = float.Parse(Console.ReadLine());
         float C6 = float.Parse(Console.ReadLine());
         float Media = (A6 * 2 + B6 * 3 + C6 * 5) / 10;
         Console.WriteLine($"MEDIA = {Media:F1}");
        break;
case 1007:
        Console.WriteLine("//1007// Difference");
        int A7 = int.Parse(Console.ReadLine());
        int B7 = int.Parse(Console.ReadLine());
        int C7 = int.Parse(Console.ReadLine());
        int D7 = int.Parse(Console.ReadLine());
        int Diferenca = (A7 * B7 - C7 * D7);
        Console.WriteLine($"DIFERENCA = {Diferenca}");
       break;
case 1008:
        Console.WriteLine("//1008// Salary");
         int number = int.Parse(Console.ReadLine());
         double salary = double.Parse(Console.ReadLine());
         double sales = double.Parse(Console.ReadLine());
         double totalSalary = salary + (sales * 0.15);
         Console.WriteLine($"NUMBER = {number}");
         Console.WriteLine($"SALARY = U$ {totalSalary:F2}");
        break;
case 1009:
        Console.WriteLine("//1009// Salary with Bonus");
         string name = Console.ReadLine();
         double salary1009 = double.Parse(Console.ReadLine());
         double sales1009 = double.Parse(Console.ReadLine());
         double totalSalary1009 = salary1009 + (sales1009 * 0.15);
         Console.WriteLine($"TOTAL = R$ {totalSalary1009:F2}");
        break;
case 1010:
        Console.WriteLine("//1010// Simple Calculate");
        string[]produto1 = Console.ReadLine().Split(' ');
        string[]produto2 = Console.ReadLine().Split(' ');
        int cod1 = int.Parse(produto1[0]);
        int num1 = int.Parse(produto1[1]);
        double valor1 = double.Parse(produto1[2]);
        int cod2 = int.Parse(produto2[0]);
        int num2 = int.Parse(produto2[1]);
        double valor2 = double.Parse(produto2[2]);
        double total = (num1 * valor1) + (num2 * valor2);
        Console.WriteLine($"VALOR A PAGAR: R$ {total:F2}"); 
       break;
case 1011:
        Console.WriteLine("//1011// Sphere");
        double Raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double pi = 3.14159;
        double Volume = (4.0 / 3.0) * pi * Math.Pow(Raio, 3);
        Console.WriteLine("VOLUME = " + Volume.ToString("F3", CultureInfo.InvariantCulture));
        break;
case 1012: 
        Console.WriteLine("//1012// Area");
        string[] valores = Console.ReadLine().Split(' ');
        double A12 = double.Parse(valores[0]);
        double B12 = double.Parse(valores[1]);
        double C12 = double.Parse(valores[2]);
        double pi12 = 3.14159;
        double triangulo = (A12 * C12) / 2;
        double circulo = pi12 * Math.Pow(C12, 2);
        double trapezio = ((A12 + B12) * C12) / 2;
        double quadrado = Math.Pow(B12, 2);
        double retangulo = A12 * B12;
        Console.WriteLine($"TRIANGULO: {triangulo:F3}");
        Console.WriteLine($"CIRCULO: {circulo:F3}");
        Console.WriteLine($"TRAPEZIO: {trapezio:F3}");
        Console.WriteLine($"QUADRADO: {quadrado:F3}");
        Console.WriteLine($"RETANGULO: {retangulo:F3}");
        break;
case 1013:
        Console.WriteLine("//1013// Maior");
        string[] valores1013 = Console.ReadLine().Split(' ');
        int a = int.Parse(valores1013[0]);
        int b = int.Parse(valores1013[1]);
        int c = int.Parse(valores1013[2]);
        int MaiorAB = (a + b + Math.Abs(a - b)) / 2;
        int Maior = (MaiorAB + c + Math.Abs(MaiorAB - c)) / 2;
        Console.WriteLine($"{Maior} eh o maior");
        break;
case 1014:
        Console.WriteLine("//1014// Consumo");
        int X14 = int.Parse(Console.ReadLine());
        double Y14 = double.Parse(Console.ReadLine());
        double consumo = X14 / Y14;
        Console.WriteLine($"{consumo:F3} km/l");
        break;
case 1015:
        Console.WriteLine("//1015// Distance Between Two Points");
        string[] p1 = Console.ReadLine().Split(' ');
        string[] p2 = Console.ReadLine().Split(' ');
        float x1 = float.Parse(p1[0]);
        float y1 = float.Parse(p1[1]);
        float x2 = float.Parse(p2[0]);
        float y2 = float.Parse(p2[1]);
        float distancia = (float)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        Console.WriteLine($"{distancia:F4}");
        break;
case 1016:
        Console.WriteLine("//1016// Distance");
        int X16 = int.Parse(Console.ReadLine());
        int tempo = X16 * 2;
        Console.WriteLine($"{tempo} minutos");
        break;
case 1017:
        Console.WriteLine("//1017// Fuel Spent");
        int tempo1017 = int.Parse(Console.ReadLine());
        int velocidade1017 = int.Parse(Console.ReadLine());
        double distancia1017 = tempo1017 * velocidade1017;
        double combustivel = distancia1017 / 12;
        Console.WriteLine($"{combustivel:F3}");
        break;
case 1018:
        Console.WriteLine("//1018// Banknotes");
        int valor = int.Parse(Console.ReadLine());
        int[] notas = {100, 50, 20, 10, 5, 2, 1};
        Console.WriteLine(valor);
        for (int i = 0; i < notas.Length; i++)
        {
            int quantidade = valor / notas[i];
            Console.WriteLine($"{quantidade} nota(s) de R$ {notas[i]},00");
            valor -= quantidade * notas[i];
        }
        break;
case 1019:
        Console.WriteLine("//1019// Time Conversion");
        int N = int.Parse(Console.ReadLine());
        int horas = N / 3600;
        int minutos = (N % 3600) / 60;
        int segundos = (N % 3600) % 60;
        Console.WriteLine($"{horas}:{minutos}:{segundos}");
        break;
case 1020:
        Console.WriteLine("//1020// Age in Days");
        int idade = int.Parse(Console.ReadLine());
        int anos = idade / 365;
        int meses = (idade % 365) / 30;
        int dias = (idade % 365) % 30;
        Console.WriteLine($"{anos} ano(s)");
        Console.WriteLine($"{meses} mes(es)");
        Console.WriteLine($"{dias} dia(s)");
        break;
case 1021:
        Console.WriteLine("//1021// Banknotes and Coins");
        double valor1021 = double.Parse(Console.ReadLine());
        int[] notas1021 = {100, 50, 20, 10, 5, 2};
        int[] moedas1021 = {100, 50, 25, 10, 5, 1};
        Console.WriteLine("NOTAS:");
        for (int i = 0; i < notas1021.Length; i++)
        {
           int quantidade1021 = (int)valor1021 / notas1021[i];
            Console.WriteLine($"{quantidade1021} nota(s) de R$ {notas1021[i]},00");
            valor1021 -= quantidade1021 * notas1021[i];
        }
        Console.WriteLine("MOEDAS:");
        for (int i = 0; i < moedas1021.Length; i++)
        {
            int quantidade1021 = (int)valor1021 / moedas1021[i];
            Console.WriteLine($"{quantidade1021} moeda(s) de R$ {moedas1021[i] / 100.0:F2}");
            valor1021 -= quantidade1021 * moedas1021[i];
        }
        break;
case 1022:
        Console.WriteLine("//1022// Banknotes and Coins");
        double valor1022 = double.Parse(Console.ReadLine());
        int centavos1022 = (int)(valor1022 * 100.0 + 0.5);
        int[] notas1022 = {10000, 5000, 2000, 1000, 500, 200};
        int[] moedas1022 = {100, 50, 25, 10, 5, 1};
        Console.WriteLine("NOTAS:");
        foreach (var nota1022 in notas1022)
        {
        Console.WriteLine($"{centavos1022 / nota1022} nota(s) de R$ {(nota1022 / 100.0):0.00}");
        centavos1022 %= nota1022;
        }
        Console.WriteLine("MOEDAS:");
        foreach (var moeda1022 in moedas1022)
        {
        Console.WriteLine($"{centavos1022 / moeda1022} moeda(s) de R$ {(moeda1022 / 100.0):0.00}");
        centavos1022 %= moeda1022;
        }
        break;
case 1035:
        Console.WriteLine("//1035//  teste de seleçao");

        string[] p11035 = Console.ReadLine().Split(' ');
        int A35 = int.Parse(p11035[0]);
        int B35 = int.Parse(p11035[1]);
        int C35 = int.Parse(p11035[2]);
        int D35 = int.Parse(p11035[3]);
        if (B35 > C35 && D35 > A35 && C35 + D35 > A35 + B35 && C35 > 0 && D35 > 0 && A35 % 2 == 0)
        {
            Console.WriteLine("Valores aceitos");
        }
        else
        {
            Console.WriteLine("Valores nao aceitos");
        }
        break;
case 1036:
        Console.WriteLine("//1036// Formula de Bhaskara");
        string[] Valores1036 = Console.ReadLine().Split(' ');
        double A36 = double.Parse(Valores1036[0]);
        double B36 = double.Parse(Valores1036[1]);
        double C36 = double.Parse(Valores1036[2]);
        double delta = Math.Pow(B36, 2) - 4 * A36 * C36;
        if (delta < 0 || A36 == 0)
        {
        Console.WriteLine("Impossivel calcular");
        }
        else
        {
        double R1 = (-B36 + Math.Sqrt(delta)) / (2 * A36);
        double R2 = (-B36 - Math.Sqrt(delta)) / (2 * A36);
        Console.WriteLine($"R1 = {R1:F5}");
        Console.WriteLine($"R2 = {R2:F5}");
        }
        break;
case 1037:
        Console.WriteLine("//1037// Interval");
        double valor1037 = double.Parse(Console.ReadLine());
        if (valor1037 >= 0 && valor1037 <= 25)
        {
         Console.WriteLine("Intervalo [0,25]");
        }
        else if (valor1037 > 25 && valor1037 <= 50)
        {
        Console.WriteLine("Intervalo (25,50]");
        }
        else if (valor1037 > 50 && valor1037 <= 75)
        {
        Console.WriteLine("Intervalo (50,75]");
        }
        else if (valor1037 > 75 && valor1037 <= 100)
        {
         Console.WriteLine("Intervalo (75,100]");
        }
        else
        {
        Console.WriteLine("Fora de intervalo");
        }
        break;

        default:
                Console.WriteLine("Exercício não encontrado.");
                break;
        }
}}