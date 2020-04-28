using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, P;
            Console.Write("Введите количество секунд n:");
            n = int.Parse(Console.ReadLine());
            Console.Write("Введите пройденный путь P:");
            P = int.Parse(Console.ReadLine());
            double s=0, sr=0;
            for (int i = 0; i <n; i++)
                s += P*Math.Sqrt(i+1)+i;//общий пройденный путь
            sr = s / n;//пусть пройденный в среднем за 1 секунду
            Console.Write("Путь, проходимый телом за одну секунду в среднем равен sr={0:.###} ", sr);
            Console.ReadKey();
        }
    }
}
