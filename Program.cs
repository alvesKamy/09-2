//Peça ao usuário dois números e mostre a soma, subtração, multiplicação e divisão entre eles.

// Console.WriteLine("Digite o primeiro número:");
// double n1 = double.Parse(Console.ReadLine());
// Console.WriteLine("Digite o segundo número:");
// double n2 = double.Parse(Console.ReadLine());

// double soma = n1 + n2;
// double subtracao = n1 - n2;
// double multi = n1 * n2;
// double divisao = n1 / n2;

// Console.WriteLine("A soma dos números é: " + soma);
// Console.WriteLine("A subtração dos números é: " + subtracao);
// Console.WriteLine("A multiplicação dos números é: " + multi);
// Console.WriteLine("A divisão dos números é: " + divisao);

//Leia um número e mostre o seu dobro e o seu triplo.

// double n1 = 10;

// double dobro = n1 * 2;
// double triplo = n1 * 3;
// Console.WriteLine("O dobro de " + n1 + " é: " + dobro);
// Console.WriteLine("O triplo de " + n1 + " é: " + triplo);

//Leia o nome de uma pessoa e exiba uma mensagem de boas-vindas personalizada.

// Console.WriteLine("Digite seu nome:");
// string nome = Console.ReadLine();

// Console.WriteLine("Boas Vindas " + nome);

//Leia a idade de uma pessoa e informe quantos anos ela terá daqui a 10 anos.

// Console.WriteLine("Qual a sua idade?");
// int idade = int.Parse(Console.ReadLine());
// int idadefutura = idade + 10;
// Console.WriteLine("Em 10 anos você terá: " + idadefutura + " anos.");

//Leia um número e informe se ele é par ou ímpar.

// int numero = 10;
// if (numero % 2 == 0)
// {
//     Console.WriteLine("É par.");
// }
// else
// {
//     Console.WriteLine("É ímpar.");
// }

//Leia dois números e mostre qual é o maior ou informe se são iguais.

// Console.WriteLine("Digite o primeiro número: ");
// double n1 = double.Parse(Console.ReadLine());

// Console.WriteLine("Digite o segundo número: ");
// double n2 = double.Parse(Console.ReadLine());

// if (n1 > n2)
// {
//     Console.WriteLine(n1 + " é maior que " + n2);
// } else if(n1 < n2)
// {
//     Console.WriteLine(n2 + " é maior que " + n1);
// }
// else
// {
//     Console.WriteLine("São iguais");
// }

//Leia a nota de um aluno e informe se ele está aprovado, em recuperação ou reprovado.

// Console.WriteLine("Informe a nota.");
// double nota = double.Parse(Console.ReadLine());

// if (nota >= 7)
// {
//     Console.WriteLine("Aprovado");
// } 
// else if(nota >= 6)
// {
//     Console.WriteLine("Recuperação");
// } else
// {
//     Console.WriteLine("Reprovado");
// }

//Leia a idade de uma pessoa e informe se ela é menor de idade, adulta ou idosa.

// Console.WriteLine("Informe sua idade.");
// int idade = int.Parse(Console.ReadLine());

// if (idade >= 60)
// {
//     Console.WriteLine("Você é idoso.");
// } else if (idade >= 18)
// {
//     Console.WriteLine("Você é adulto.");
// } else if (idade >= 13)
// {
//     Console.WriteLine("Você é adolescente");
// } else
// {
//     Console.WriteLine("Você é criança");
// }

//Leia um número e informe se ele é positivo, negativo ou zero.

// Console.WriteLine("Informe o número");
// double numero = double.Parse(Console.ReadLine());

// if (numero > 0)
// {
//     Console.WriteLine("é positivo");
// } else if (numero == 0)
// {
//     Console.WriteLine("é zero");
// } else
// {
//     Console.WriteLine("é negativo");
// }

//Mostre os números de 1 a 10 usando um laço.

// int i = 1;

// while (i <= 10)
// {
//     Console.WriteLine(i);
//     i++;
// }

//Mostre os números pares de 1 a 50.
 
// int i = 1;

// while (i <= 50)
// {
//     if (i % 2 == 0)
//     Console.WriteLine(i);
//     i++;
// }

//Leia um número e mostre a tabuada dele.

// Console.WriteLine("Digite um numéro");
// int numero = int.Parse(Console.ReadLine());

// int i = 0;
// while (i <= 10)
// {
//     int resultado = numero * i;
//     Console.WriteLine(resultado);
//     i++;
// }

//Leia vários números até que o usuário digite 0 e mostre a soma de todos.

// Console.WriteLine("Vamos somar, para finalizar digite 0");
// int numero = int.Parse(Console.ReadLine());
// int soma = 0;

// while (numero != 0)
// {
//     soma += numero;
//     Console.WriteLine("digite o próximo");
//     numero = int.Parse(Console.ReadLine());
// }

// Console.WriteLine("A soma total é: " + soma);

//Leia 5 números e informe quantos são positivos.

// Console.WriteLine("Digite o seu número: ");
// int numero = int.Parse(Console.ReadLine());
// int quantidade = 1;
// int positivo = 0;

// while (quantidade <= 5)
// {
//     if (numero > 0)
//     {
//         positivo++;
//     }
//     if (quantidade == 5)
//     {
//         break;
//     }
//     Console.WriteLine("Digite o próximo: ");
//     numero = int.Parse(Console.ReadLine());
//     quantidade++;
// }
// Console.WriteLine("quantidade de positivos " + positivo);

//Crie um menu com as opções:
// 1 – Somar
// 2 – Subtrair
// 3 – Multiplicar
// 4 – Dividir
// O usuário escolhe a opção e informa dois números.

// Console.WriteLine("Selecione uma opção");
// Console.WriteLine("1 - Somar");
// Console.WriteLine("2 - Subtrair");
// Console.WriteLine("3 - Multiplicar");
// Console.WriteLine("4 - Dividir");

// int opcao = int.Parse(Console.ReadLine());

// Console.WriteLine("Digite o primeiro número:");
// int n1 = int.Parse(Console.ReadLine()); 

// Console.WriteLine("Digite o segundo número:");
// int n2 = int.Parse(Console.ReadLine());

// switch (opcao)
// {
//     case 1:
//     Console.WriteLine("Resultado: " + (n1 + n2));
//     break;
//     case 2:
//     Console.WriteLine("Resultado: " + (n1 - n2));
//     break;
//     case 3:
//     Console.WriteLine("Resultado: " + (n1 * n2));
//     break;
//     case 4:
//     Console.WriteLine("Resultado: " + (n1 / n2));
//     break;
// }

//Leia um número de 1 a 7 e informe o dia da semana correspondente.

// Console.WriteLine("Digite o número para ser correspondido com o dia da semana.");
// int dia = int.Parse(Console.ReadLine());
// switch (dia)
// {
//     case 1:
//     Console.WriteLine("domingo");
//     break;
//     case 2:
//     Console.WriteLine("segunda");
//     break;
//     case 3:
//     Console.WriteLine("terça");
//     break;
//     case 4:
//     Console.WriteLine("quarta");
//     break;
//     case 5:
//     Console.WriteLine("quinta");
//     break;
//     case 6:
//     Console.WriteLine("sexta");
//     break;
//     case 7:
//     Console.WriteLine("sábado");
//     break;
// }

//Leia um código de produto e informe a categoria (ex: 1–Alimento, 2–Bebida, 3–Limpeza).

// Console.WriteLine("Informe o código do produto:");
// Console.WriteLine("1 - Alimento");
// Console.WriteLine("2 - Bebida");
// Console.WriteLine("3 - Limpeza");

// int opcao = int.Parse(Console.ReadLine());
// Console.WriteLine("digite o nome do produto.");
// string produto = Console.ReadLine();   

// switch (opcao)
// {
//     case 1:
//     Console.WriteLine(" o produto " + produto + " pertence aos alimentos ");
//     break;

//     case 2:
//     Console.WriteLine(" o produto " + produto + " pertence as bebidas ");
//     break;

//     case 3:
//     Console.WriteLine(" o produto " + produto + " pertence a limpeza ");
//     break;
// }


// Leia 10 números e informe:
// a soma
// a média
// o maior número

// Console.WriteLine("Digite o 1º número");
// int numero = int.Parse(Console.ReadLine());
// int soma = numero;
// int maior = numero;

// for (int i = 2; i <=10; i++)
// {
//     Console.WriteLine("Digite o " + i + "º número");
//     numero = int.Parse(Console.ReadLine());
//     soma+= numero;
//     if(numero > maior)
//     {
//         maior = numero;
//     }
// }
// double media = soma/10;
// Console.WriteLine("A soma é: " + soma);
// Console.WriteLine("A média é: " + media);
// Console.WriteLine("O maior número é: " + maior);

//Leia idades até que seja digitado um valor negativo e informe a média das idades.

// int soma = 0;
// int contador = 0;

// Console.WriteLine("Digite as idades para calcular a média, numéro negativo pra sair.");
// int idade = int.Parse(Console.ReadLine());

// while (idade >= 0)
// {
//     soma += idade;
//     contador++;

//     Console.WriteLine("Digite as idades para calcular a média, numéro negativo pra sair.");
//     idade = int.Parse(Console.ReadLine());
// }
// if (contador > 0)
// {
//     double media = soma / contador;
//     Console.WriteLine("Média das idades: " + media);
// }

//Leia vários números e informe quantos são pares e quantos são ímpares.

// int par = 0;
// int impar = 0;

// Console.WriteLine("Digite um número, 0 para sair");
// int numero = int.Parse(Console.ReadLine());

// while (numero != 0)
// {
//     if (numero % 2 == 0)
//     {
//         par++;
//     }
//     else
//     {
//         impar++;
//     }
//     Console.WriteLine("Digite um número, 0 para sair");
//     numero = int.Parse(Console.ReadLine());
// }
// Console.WriteLine("Quantidade de números pares: " + par);
// Console.WriteLine("Quantidade de números ímpares: " + impar);

//Leia um número e informe se ele é primo.

// int divisores = 0;

// Console.WriteLine("Digite um número para verificar se é primo.");
// int numero = int.Parse(Console.ReadLine());

// for (int i = 1; i <= numero; i++)
// {
//     if (numero % i == 0)
//     {
//         divisores++;
//     }
// }
// if (divisores == 2)
// {
//     Console.WriteLine("É primo.");
// } else
// {
//     Console.WriteLine("Não é primo.");
// }

//Leia um número e calcule o fatorial.

// Console.WriteLine("Digite um número para calcular o fatorial.");
// int numero = int.Parse(Console.ReadLine());

// int fatorial = 1;

// for ( int i = 1; i <= numero; i++)
// {
//     fatorial *= i;
// }

// Console.WriteLine("O fatorial é: " + fatorial);

//Leia uma senha e permita no máximo 3 tentativas.

// int tentativas = 0;

// Console.WriteLine("Digite a senha:");
// string senha = Console.ReadLine();
// while (senha != "senha")
// {
//     tentativas++;
//     Console.WriteLine("Erro, tente novamente.");
//     senha = Console.ReadLine();
//     if (tentativas == 2)
//     {
//         break;
//     }
// }
// if(senha == "senha"){
//     Console.WriteLine("Logado.");
// }
// else
// {
//     Console.WriteLine("Número máximo de tentativas atingido.");
// }

//Simule um caixa eletrônico que permite saques enquanto houver saldo.

double saldo = 100;
Console.WriteLine("Saldo: " + saldo);
while (saldo > 0)
{
    Console.WriteLine("Quanto deseja sacar?");
    double saque = double.Parse(Console.ReadLine());

    if (saque <= 0)
    {
        Console.WriteLine("Valor Inválido");
    }
    else if(saque > saldo)
    {
        Console.WriteLine("Valor insuficiente");
    }
    else
    {
        saldo -= saque;
        Console.WriteLine("Saque realizado. Saldo restante: " + saldo);
    }
}
Console.WriteLine("Operação finalizada.");

//Leia uma sequência de números e informe qual foi o maior valor digitado.

// Console.WriteLine("Digite o 1º número");
//  int numero = int.Parse(Console.ReadLine());
//  int maior = numero;

// for (int i = 2; i <=10; i++)
// {
//     Console.WriteLine("Digite o " + i + "º número");
//     numero = int.Parse(Console.ReadLine());
//     if(numero > maior)
//     {
//         maior = numero;
//    }
// }
// Console.WriteLine("O maior número é: " + maior);
  









