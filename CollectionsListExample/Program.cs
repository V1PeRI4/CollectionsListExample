using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsListExample
{

    // вместо длинные массива как в задании (15) стоит 5, да бы ускориить ввод и простоту дебаггинга

    internal class Program
    {
        static void Main(string[] args)
        {


            //////////////////////////////////////////////
            //Массив У'ков


            List<int> list_Y = new List<int>();
            int listLenght = 5;

            for (int i = 0; i < listLenght; i++)
            {
                Console.Write($"list_Y[{i}] = ");
                bool work = int.TryParse(Console.ReadLine(), out int temp);
                if (work)
                    list_Y.Add(temp);

                Console.Clear();
            }


            Console.WriteLine("Введенный массив: ");
            for (int i = 0; i < listLenght; i++)
                Console.WriteLine($"list_Y[{i}] = " + list_Y[i]);

            Console.WriteLine("------------------");


            //////////////////////////////////////////////
            //Массив Х'ков


            List<double> list_X = new List<double>();
            double numResult;

            for (int i = 0; i < listLenght; i++)
            {
                numResult = (  Math.Pow(Math.Cos(list_Y[i]), 2)   + Math.Pow(Math.Log10(2.971),2)   * Math.Pow(i,2) ) ; 
                list_X.Add(numResult);

                Console.WriteLine($"list_X[{i}] = " + list_X[i]);
            }
            Console.WriteLine("------------------");


            //////////////////////////////////////////////
            /////Конечный массив


            List<double> list_Result = new List<double>();

            for (int i = 0; i < listLenght; i++)
                list_Result.Add(list_X[i]);

            for (int i = 0; i < listLenght; i++)
                list_Result.Add(list_Y[i]);

            list_Result.Sort();
            list_Result.Reverse();

            for (int i = 0; i < listLenght + listLenght; i++)
                Console.WriteLine($"list_Resukt[{i}] = " + list_Result[i]);



        }
    }
}
