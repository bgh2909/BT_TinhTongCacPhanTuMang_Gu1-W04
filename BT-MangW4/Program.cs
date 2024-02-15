using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace BT_MangW4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[4];

            Console.WriteLine("Moi nhap gia tri cac bien: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Gia tri cac bien da nhap: ");
            for (int i = 0;i < numbers.Length;i++)
            {
                Console.Write(numbers[i] +" ");
            }

            Console.WriteLine();

            int total = 0;
            for (int i = 0; numbers.Length > i;i++)
            {
                total = total + numbers[i];       
            }
            Console.WriteLine("Tong cua gia tri cua cac bien da nhap = " + total);

            Console.ReadKey();
        }
    }
}
