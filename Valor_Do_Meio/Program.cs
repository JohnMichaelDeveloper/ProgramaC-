using System;

namespace Valor_Do_Meio
{
    class Program
    {
        static void Main(string[] args)
        {

    /*  
    Fazer um programa para que o usuário informe 3 valores no console e o programa 
    verifique qual é o valor do meio. Exemplo: num1 = 2, num2 = 8 e num3 = 5.
    */

            int num1=0, num2=0, num3=0;

            Console.WriteLine("");
            Console.WriteLine("Olá, Meu nome John! Sou estudante na Recode Pro e Futuro Fullstack.");
            Console.WriteLine("");
            Console.WriteLine("Participe dessa aplicação, é muito simple informe 3 número e o programa vai-lhe mostrar qual será o número do meio.");
            Console.WriteLine("");

            Console.WriteLine("----->Vamos Começar?<-----");
            Console.WriteLine("Informe o primeiro número inteiro de 0 a 10: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Informe o segundo número inteiro de 0 a 10: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Informe o terceiro número inteiro de 0 a 10: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            
            if(((num1 < num2) && (num2 > num3) && (num1 > num3)) || ((num1 > num2) && (num2 < num3) && (num1 < num3)))
            {
                Console.WriteLine("Valor do meio é : "+num1);
                Console.ReadKey();
            }
            else if(((num1 < num2) && (num2 < num3) && (num1 < num3)) || ((num1 > num2) && (num2 > num3) && (num1 > num3)))
            {
                Console.WriteLine("Valor do meio é : "+num2);
                Console.ReadKey();
            }
            else if(((num1 < num2) && (num2 > num3) && (num1 < num3)) || ((num1 > num2) && (num2 < num3) && (num1 > num3)))
            {
                Console.WriteLine("Valor do meio é : "+num3);
                Console.ReadKey();
            }
            Console.WriteLine("------------------------------------");
            Console.WriteLine(" Obrigado por testa essa aplicação! ");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Você gostou então me adicione no GitHub:  https://github.com/JohnMichaelDeveloper");
            Console.WriteLine("E me adicione também na rede do LinkedIn: https://linkedin.com/in/johnmichaelpeixoto/");
            Console.WriteLine("");
            Console.WriteLine("E até a próxima!");
            Console.WriteLine("");
        }
    }
}
