using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nakovCh06ex10_simpleMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleMatrix();

        }

        private static void SimpleMatrix()
        {
            Console.WriteLine("Please enter a number less or equal to 20: ");

            string userInp = Console.ReadLine();

            int num = 0;

            bool check = int.TryParse(userInp, out num);

            if (check != true)
            {
                Console.WriteLine("Please enter a number");
            }

            for (int i = 0; i < num; i++)
            {
                for (int j = 1 + i; j <= num + i; j++)
                {
                    Console.Write("{0, 3}", j);
                }

                Console.WriteLine();
            }
        }
    }
}
