using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        private const double V = 5.9;

        static void Main(string[] args) {
            double n1, n2, trabalho;
            double media;
            string nome;

            Console.WriteLine("digite o nome do aluno");
            nome = Console.ReadLine();

            Console.WriteLine("digite a nota 1");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("digite a nota 2");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("digite a nota do trabalho");
            trabalho = Convert.ToDouble(Console.ReadLine());

            media =(n1 + n2 + trabalho) / 3;
            Console.WriteLine("nota final" + media);

            if (media >= 8.5 && media <= 10) {
                Console.WriteLine("nota A");
            } else if (media >= 7 && media <= 8.4 ) {
                Console.WriteLine("nota B");
            } else if (media >=6 && media <= 6.9) {
                Console.WriteLine("nota C");
            } else if (media >= 0.1 && media <= 5.9) {
                Console.WriteLine("nota D");
            } else if (media <=0)
                Console.WriteLine("nota E");
            


            Console.ReadKey();
            }    
                
            
 
        

          
        }

    }













           

            
    



