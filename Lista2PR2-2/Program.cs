using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lista2PR2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //atividade 1
            //float l = 0.35f, nl, d= 0.28f, vt;

            //Console.WriteLine("Escreva quantas laranjas vc uqer comprar: ");
            //nl = float.Parse(Console.ReadLine());


            //if (nl >= 12)
            //{
            //    vt = d * nl;
            //}
            //else
            //{
            //    vt= l * nl;
            //}

            //Console.WriteLine("O valor total de sua compra de laranjas é igual a:" + vt );
            //Console.ReadKey();


            ////atividade 2
            //int n, a=2023;

            //Console.WriteLine("digite qual o ano do seu nacimento: ");
            //n = int.Parse(Console.ReadLine());

            //if((a - n) >= 16)
            //{
            //    Console.WriteLine("Você tem direito ao voto ");
            //    Console.ReadKey();

            //}
            //else
            //{
            //    Console.WriteLine("você ainda não tem direito ao voto");
            //    Console.ReadKey();
            //}

            ////atividade 3
            //float l1, l2, l3;

            //Console.WriteLine("Digite o valor do primeiro lado: ");
            //l1 = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o valor do segundo lado: ");
            //l2 = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o valor do terceiro lado: ");
            //l3 = float.Parse(Console.ReadLine());

            //if (l1 == l2 && l1 == l3)
            //{
            //    Console.WriteLine("Seu triângulo é equilátero");
            //    Console.ReadKey();


            //}
            //else if (l1 == l2 || l1 == l3)
            //{
            //    Console.WriteLine("Seu triângulo é isóceles");
            //    Console.ReadKey();
            //}
            //else
            //{
            //    Console.WriteLine("Seu triângulo é escaleno");
            //    Console.ReadKey();
            //}

            //atividade 4

            //int a, b, c, x1, x2, delta;

            //Console.WriteLine("Digite o valor refêrente ao valor A: ");
            //a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o valor refêrente ao valor B: ");
            //b = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o valor refêrente ao valor C: ");
            //c = int.Parse(Console.ReadLine());

            //delta = (b * b) - 4 * a * c;

            //if (delta <= 0)
            //{
            //    Console.WriteLine("Não há resultado");
            //    Console.ReadKey();
            //}
            //else
            //{
            //    x1 = ((b * -1) + Math.sqrt (delta) ) / (2 * a);
            //    x2 = ((b * -1) - Math.sqrt (delta) ) / (2 * a);

            //    Console.WriteLine("O resultado de x1 é igual a: " + x1);
            //    Console.WriteLine("O resultado de x2 é igual a: " + x2);
            //    Console.ReadKey();

            //}
            //atividade 5
            //int v;

            //Console.WriteLine("Digite um valor inteiro; ");
            //v = int.Parse(Console.ReadLine());

            //if (v % 3 == 0 && v % 5 == 0)
            //{
            //    Console.WriteLine("Seu valor é divisível por ambos, 3 e 5.");
            //    Console.ReadKey();

            //}
            //else if (v % 3 == 0)
            //{
            //    Console.WriteLine("Seu valor é divisívle por 3, apenas.");
            //    Console.ReadKey();
            //}
            //else
            //{
            //    Console.WriteLine("Seu valor é divisível por 5, apenas.");
            //    Console.ReadKey();
            //}

            ////atividade 6
            //int a1, a2, a3;

            //Console.WriteLine("Digite o valor do primeiro ângulo");
            //a1=int.Parse(Console.ReadLine());            
            //Console.WriteLine("Digite o valor do segundo ângulo");
            //a2=int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o valor do terceiro ângulo");
            //a3=int.Parse(Console.ReadLine());

            //if (a1 == 90 || a2 == 90 || a3 == 90) 
            //{
            //    Console.WriteLine("O seu triângulo é Acutângulo");
            //    Console.ReadKey();
            //}
            //else if(a1 <90 && a2 < 90 && a3 < 90)
            //{
            //    Console.WriteLine("O seu Triângulo é Obtusângulo");
            //    Console.ReadKey();
            //}
            //else
            //{
            //    Console.WriteLine("O seu Triângulo é Acutângulo ");
            //    Console.ReadKey();
            //}

            ////atividade 7
            //int n1, n2, n3;

            //Console.WriteLine("Digite o primeiro valor: ");
            //n1=int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o segundo valor: ");
            //n2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o terceiro valor: ");
            //n3 = int.Parse(Console.ReadLine());

            //if(n1==n2 && n1 == n3)
            //{
            //    Console.WriteLine("Valores repetidos não são válidos.");
            //}
            //else
            //{
            //    if (n1 < n2 && n2 < n3)
            //    {
            //        Console.WriteLine(n1 + " " + n2 + " " + n3 + " ");
            //        Console.ReadKey();
            //    }
            //    else if (n1 < n2 && n2 > n3)
            //    {
            //        Console.WriteLine(n1 + " " + n3 + " " + n2);
            //        Console.ReadKey();
            //    }
            //    else if (n1 > n2 && n2 < n3) 
            //    {
            //        if (n1 < n3)
            //        {
            //            Console.WriteLine(n2 + " " + n1 + " " + n3);
            //            Console.ReadKey();
            //        }
            //        else
            //        {
            //            Console.WriteLine(n2 + " " + n3 + " " + n1);
            //            Console.ReadKey();
            //        }
            //    }else
            //    {
            //        if (n1 > n2 && n2 > n3) 
            //        {
            //            Console.WriteLine(n3 + " " + n2 + " " + n1);
            //            Console.ReadKey();
            //        }
            //        else
            //        {
            //            Console.WriteLine(n3 + " " + n1 + " " + n2);
            //            Console.ReadKey();
            //        }
            //    }
            //}




            ////atividade 8
            //int ano;

            //Console.WriteLine("Digite um ano: ");
            //ano = int.Parse(Console.ReadLine());

            //if(ano % 4 == 0)
            //{
            //    Console.WriteLine("Seu ano é um ano bissexto");
            //    Console.ReadKey();
            ////}

            ////atividade 9 
            //float n1, n2, result;
            //char op;

            //Console.WriteLine("Digite o primeiro valor: ");
            //n1=float.Parse(Console.ReadLine()); 
            //Console.WriteLine("Digite o segundo valor: ");
            //n2=float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite qual das operações deve ser feitos com os valores, escolha entre +, -,* ou /: ");
            //op = char.Parse(Console.ReadLine());

            //if (op == '+') 
            //{
            //    result = n1 + n2;
            //    Console.WriteLine("O reu resultado será igual a: " + result);
            //    Console.ReadKey();
            //}
            //else if(op == '-')
            //{
            //    result = n1 - n2;
            //    Console.WriteLine("O reu resultado será igual a: " + result);
            //    Console.ReadKey();
            //}
            //else if (op == '*')
            //{
            //    result= n1 * n2;
            //    Console.WriteLine("O reu resultado será igual a: " + result);
            //    Console.ReadKey();
            //}
            //else if (op =='/')
            //{
            //    result= n1 / n2;
            //    Console.WriteLine("O reu resultado será igual a: " + result);
            //    Console.ReadKey();
            //}
            //else
            //{
            //    Console.WriteLine("Erro, digite um dos elementos acima");
            //    Console.ReadKey();
            //}

            //atividade 10

            //Console.WriteLine("Números aleatórios podem ser geredos apartir da classe por nome 'randon', pertencente ao namespace System, nos permite gerar números aleatórios em C# por meio de seus métodos, incluindo números inteiros e de ponto flutuante. " +
            //    "Números aleatórios são empregados em diversas aplicações, tais como criptografia, simulações estatísticas e jogos de computador." +
            //    "Primeiramente, instanciamos a classe:" +
            //    "'\r\n\r\nRandom numAleatorio = new Random();\r\n'" +
            //    "E então invocamos um de seus métodos geradores de números aleatórios, atribuindo o retorno do método a uma variável de tipo compatível." +
            //    "Para gerar um número aleatório inteiro, usamos o método Next(), que permite gerar um valor inteiro (int) positivo entre zero e Int32.MaxValue (2.147.483.647)." +
            //    "'\r\n\r\nint valorInteiro = numAleatorio.Next();\r\n'" +
            //    "Podemos também configurar o intervalo de números gerados adicionando dois argumentos ao método Next(): número inicial e número final + 1. Por exemplo, para gerar apenas números aleatórios entre 1 e 20, escrevemos:" +
            //    "'\r\n\r\nint valorInteiro = numAleatorio.Next(1,21)';");

            //Random numAleatorio = new Random();
            //int valorInteiro = numAleatorio.Next();
            //Console.WriteLine(valorInteiro);
            //Console.ReadKey();
        }
    }
}
