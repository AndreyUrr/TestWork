using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testWork.Libs
{

    public class Numbers
    {
        /// <summary>
        /// Поиск неповторяющихся чисел в массиве с сортировкой результата
        /// </summary>
        /// <param name="array">исходный массив</param>
        /// <returns></returns>
        public static int[] FindUniqueWithSort(int[] array)
        {
            int max = 0;
            int min = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                    max = array[i];
                if (min > array[i])
                    min = array[i];
            }

            int[] countArr = new int[max - min + 1];

            for (int i = 0; i < array.Length; i++)
            {
                countArr[array[i] - min] += 1;
            }

            List<int> result = new List<int>();

            for (int i = 0; i < countArr.Length; i++)
            {
                if (countArr[i] == 1)
                {
                    result.Add(i + min);
                }
            }
            return result.ToArray();
        }
        /// <summary>
        /// Поиск неповторяющихся чисел в массиве
        /// </summary>
        /// <param name="array">исходный массив</param>
        /// <returns></returns>
        public static int[] FindUnique(int[] array)
        {
            List<int> result = new List<int>();
            for (int j = 0; j < array.Length; j++)
            {
                bool isUnique = true;
                for (int i = 0; i < array.Length; i++)
                {
                    if (j != i && array[j] == array[i])
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                {
                    result.Add(array[j]);
                }
            }
            return result.ToArray();
        }

        /// <summary>
        /// поиск неповторяющихся чисел в массиве
        /// </summary>
        /// <param name="array">исходный массив</param>
        /// <param name="delta">точность сопоставления чисел</param>
        /// <returns></returns>
        public static float[] FindUnique(float[] array, float delta = 0.0000001f)
        {
            List<float> result = new List<float>();
            for (int j = 0; j < array.Length; j++)
            {
                bool isUnique = true;
                for (int i = 0; i < array.Length; i++)
                {
                    if (j != i && Math.Abs(array[j]-array[i]) <= delta)
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                {
                    result.Add(array[j]);
                }
            }

            return result.ToArray();
        }

    }
}
