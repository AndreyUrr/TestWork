using System;
using testWork.Libs;

namespace testWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 7, 5, 4, 10, 1, 10 };
            float[] arrFloat = new float[] { 1.2f, 1.2f, 1.0009f, 1.0008f, 0.12f, 0.12f, 0.100001f, 0.100002f };

            int[] res = Numbers.FindUnique(arr);
            float[] resFloat = Numbers.FindUnique(arrFloat);

            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.WriteLine();

            Console.WriteLine("тут тестовое сообщение");
            Console.WriteLine("Новый функционал");

            for (int i = 0; i < resFloat.Length; i++)
            {
                Console.WriteLine(resFloat[i]);
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
