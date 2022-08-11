using System;

namespace ExercTriangulo {
    class Program {
        static void Main(string[] args) {
            /*
            int x, y, z;
            Console.WriteLine("Digite o primeiro lado do triângulo: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo lado do triângulo: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o terceiro lado do triângulo: ");
            z = Convert.ToInt32(Console.ReadLine());

            if(x + y > z && x + z > y && y + z > x) 
            { 
                // é um triangulo
                if (x == y && x == z)
                    Console.WriteLine("Triangulo equilátero");
                else if(x != y && x != z && y != z)
                    Console.WriteLine("Tiangulo escaleno");
                else
                    Console.WriteLine("Triangulo Isósceles");

            }
            else
                Console.WriteLine("Esses cumprimentos não formam um triângulo");
 
          */

            /*
            int numero;

            Console.WriteLine("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            switch (numero) 
            {
                case 1:
                    Console.WriteLine("Janeiro");
                    break;
                case 2:
                    Console.WriteLine("Fevereiro");
                    break;
                case 3:
                    Console.WriteLine("Março");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    break;
                case 5:
                    Console.WriteLine("Maio");
                    break;
                case 6:
                    Console.WriteLine("Junho");
                    break;
                case 7:
                    Console.WriteLine("Julho");
                    break;
                case 8:
                    Console.WriteLine("Agosto");
                    break;
                case 9:
                    Console.WriteLine("Setembro");
                    break;
                case 10:
                    Console.WriteLine("Outubro");
                    break;
                case 11:
                    Console.WriteLine("Novembro");
                    break;
                case 12:
                    Console.WriteLine("Dezembro");
                    break;
                default:
                    Console.WriteLine("Este número não corresponde a um mês");
                    break;
                    */
            /*
            int codigo;
            double valor, saldo = 100;

            Console.WriteLine("    Menu    \n[1]Depósito\n[2]Saque\n[3]Ver Saldo\n\nDigite a opção desejada: ");
            codigo = Convert.ToInt32(Console.ReadLine());

            switch (codigo)
            {
                case 1: //Depósito
                    {
                        Console.WriteLine("Valor a ser depositado: ");
                        valor = Convert.ToDouble(Console.ReadLine());
                        saldo += valor;
                        Console.WriteLine("Saldo atualizado: R${0}", saldo.ToString("0.00"));
                    }
                    break;
                case 2: //Saque
                    {
                        Console.WriteLine("Valor a ser sacado: ");
                        valor = Convert.ToDouble(Console.ReadLine());
                        if(saldo >= valor)
                            saldo -= valor;
                        else
                            Console.WriteLine("Saldo insuficiente para saque!");

                        Console.WriteLine("Saldo atualizado: R${0}", saldo.ToString("0.00"));
                    }
                    break;
                case 3: //Ver saldo
                    {
                        Console.WriteLine("Saldo atualizado: R${0}", saldo.ToString("0.00"));
                    }
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
            */

            double nota1, nota2, media, frequencia;
            double quantidadeAulaAssistida, qtdAulasDadas;

            Console.WriteLine("Nota 1: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 2: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            media = (nota1 + nota2) / 2;

            Console.WriteLine("Quantidade de aulas dadas: ");
            qtdAulasDadas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Quantidade de aulas Assistidas: ");
            quantidadeAulaAssistida = Convert.ToDouble(Console.ReadLine());

            frequencia = (quantidadeAulaAssistida / qtdAulasDadas) * 100;

            if (media >= 7 && frequencia >= 75)
                Console.WriteLine("Aluno aprovado, com média = " + media + " e frequencia: " + frequencia + "%" );
            else
                Console.WriteLine("Aluno reprovado, com média = " + media + " e frequencia: " + frequencia + "%");




        }
    }
}
