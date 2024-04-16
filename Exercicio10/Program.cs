/* Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.*/

using System;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourA, hourB, duration;

            Console.WriteLine("DIGITE A PRIMEIRA E A SEGUNDA HORA: ");
            string[] hours = Console.ReadLine().Split(' ');

            hourA = int.Parse(hours[0]);
            hourB = int.Parse(hours[1]);

            if(hourA > hourB)
            {
                duration = hourA - hourB;
            }
            else
            {
                duration = 24 - hourA + hourB;
            }

            Console.WriteLine($"O JOGO DUROU {duration} HORA(S)");
        }
    }
}